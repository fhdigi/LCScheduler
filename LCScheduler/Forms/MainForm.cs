
using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using LCScheduler.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraPrinting;
using LCScheduler.Data;
using LCScheduler.Model;
using LCScheduler.Reports;

namespace LCScheduler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // initialize SQLite
            DataExtender.CreateProgramTables();

            // Load the default settings 
            LoadSettings();

            // Fill in the client list 
            FillClientTreeView();

            // Hide the tabs 
            ribbonControlMain.SelectedPage = clientRibbonPage;
            xtraTabControlMain.ShowTabHeader = DefaultBoolean.False;
            
            // Fill in the data for the scheduler 
            InitResources();
            InitAppointments();

            // Run the today report 
            ShowTodayReport();
        }

        private void InitResources()
        {
            ResourceMappingInfo mappings = schedulerStorageMain.Resources.Mappings;
            mappings.Id = "Id";
            mappings.Color = "ResColor";
            mappings.Caption = "Name";

            // fills in the resources from the database 
            schedulerStorageMain.Resources.DataSource = AgencyResource.GetAgencyResources(); 
        }

        private void InitAppointments()
        {
            AppointmentMappingInfo mappings = schedulerStorageMain.Appointments.Mappings;
            mappings.AppointmentId = "Id";
            mappings.Start = "StartTime";
            mappings.End = "EndTime";
            mappings.Subject = "Subject";
            mappings.AllDay = "AllDay";
            mappings.Description = "Description";
            mappings.Label = "Label";
            mappings.Location = "Location";
            mappings.RecurrenceInfo = "RecurrenceInfo";
            mappings.ReminderInfo = "ReminderInfo";
            mappings.ResourceId = "ResourceId";
            mappings.Status = "Status";
            mappings.Type = "EventType";

            // add in the client Id field 
            schedulerStorageMain.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("ClientId", "ClientId"));

            // fills in the appointments from the database 
            schedulerStorageMain.Appointments.DataSource = ClientAppointment.GetClientAppointments();
        }

        private void FillClientTreeView()
        {
            // Remove all of the nodes 
            treeViewClients.Nodes.Clear();

            // Create the main node
            TreeNode mainNode = treeViewClients.Nodes.Add("Clients");
            mainNode.Tag = 0;

            foreach (ClientInformation client in ClientInformation.ReturnAllClients())
            {
                // Add a client to the main node
                TreeNode clientNode = mainNode.Nodes.Add(client.FullName);
                clientNode.Tag = client.Id;

                // if the current client has progress notes ... add them 
                //foreach (ProgressNoteInformation pnObj in ProgressNoteInformation.ReturnClientProgressNotes(client.Id))
                //{
                //    TreeNode pNode = clientNode.Nodes.Add(pnObj.DateOfService.ToShortDateString());
                //    pNode.Tag = -1 * pnObj.Id;
                //}
            }

            treeViewClients.ExpandAll();
        }

        private void LoadSettings()
        {
            schedulerControlMain.Start = DateTime.Today;
            schedulerControlMain.DayView.WorkTime.Start = TimeSpan.FromHours(8);
            schedulerControlMain.DayView.WorkTime.End = TimeSpan.FromHours(19);
            schedulerControlMain.DayView.ShowWorkTimeOnly = true;

            schedulerControlMain.FullWeekView.WorkTime.Start = TimeSpan.FromHours(8);
            schedulerControlMain.FullWeekView.WorkTime.End = TimeSpan.FromHours(19);
            schedulerControlMain.FullWeekView.ShowWorkTimeOnly = true;

            schedulerControlMain.WorkWeekView.WorkTime.Start = TimeSpan.FromHours(8);
            schedulerControlMain.WorkWeekView.WorkTime.End = TimeSpan.FromHours(19);
            schedulerControlMain.WorkWeekView.ShowWorkTimeOnly = true;

            schedulerControlMain.ActiveViewType = SchedulerViewType.FullWeek;
        }

        private void ShowProgressNote(int clientId, int noteId = 0)
        {
            ProgressNoteInformation clientProgressNote = null;

            // Create a note object 
            if (noteId == 0)
            {
                // Create a new note object 
                clientProgressNote = new ProgressNoteInformation { ClientId = clientId};

                ClientAppointment lastAppointment = ClientAppointment.GetLastAppointmentForClient(clientId);

                if (lastAppointment != null)
                {
                    clientProgressNote.DateOfService = lastAppointment.StartTime.Date;
                    clientProgressNote.TimeStarted = lastAppointment.StartTime;
                    clientProgressNote.TimeEnded = lastAppointment.EndTime;
                }
            }
            else
            {
                clientProgressNote = ProgressNoteInformation.ReturnClientProgressNote(noteId);
            }

            // Create the progress note form 
            ProgressNoteForm progressForm = new ProgressNoteForm
            {
                MainFormObject = this,
                CurrentProgressNote = clientProgressNote
            };

            // Pass in the note 
            if (noteId > 0) progressForm.EditMode = true;

            // Show the screen 
            DialogResult dlgResult = progressForm.ShowDialog();

            // Refresh the list 
            FillClientTreeView();

            // If we deleted what we had selected, select the first item in the list 
            if (dlgResult == DialogResult.Abort) treeViewClients.SelectedNode = treeViewClients.Nodes[0].Nodes[0];
        }

        private ClientAppointment MapToClientAppointment(Appointment apt)
        {
            ClientAppointment newAppointment = new ClientAppointment();

            if (apt.Id == null)
            {
                newAppointment.Id = 0;
            }
            else
            {
                newAppointment.Id = (int)apt.Id;
            }
            
            newAppointment.ClientId = (int)apt.CustomFields["ClientId"];
            newAppointment.Description = apt.Description;
            newAppointment.StartTime = apt.Start;
            newAppointment.EndTime = apt.End;
            newAppointment.Subject = apt.Subject;
            newAppointment.AllDay = apt.AllDay;
            newAppointment.Location = apt.Location;
            newAppointment.ResourceId = apt.ResourceId;

            return newAppointment;
        }

        private void schedulerStorageMain_AppointmentsChanged(object sender, PersistentObjectsEventArgs e)
        {
            foreach (Appointment schedAppointment in e.Objects)
            {
                ClientAppointment clientAppt = MapToClientAppointment(schedAppointment);

                if (clientAppt != null)
                {
                    if (clientAppt.Id == 0)
                    {
                        clientAppt.Insert();
                    }
                    else
                    {
                        clientAppt.Update();
                    }
                }
            }
        }

        private void schedulerControlMain_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.Menu.Id == SchedulerMenuItemId.AppointmentMenu)
            {
                // Insert a new item into the Scheduler popup menu and handle its click event.
                SchedulerMenuItem menuPn = new SchedulerMenuItem("Progress Note", ProgressNoteContextMenuHandler)
                {
                    BeginGroup = true
                };
                e.Menu.Items.Add(menuPn);

                e.Menu.Items.Add(new SchedulerMenuItem("Edit Client Info...", EditClientInfoContextMenuHandler));
            }
        }

        public void ProgressNoteContextMenuHandler(object sender, EventArgs e)
        {
            // Get the apppintment 
            Appointment appt = schedulerControlMain.SelectedAppointments[0];

            // Make sure we have a client Id
            if (appt.CustomFields["ClientId"] != null)
            {
                // Get the client id
                int clientId = (int) appt.CustomFields["ClientId"];

                // At this point, see if a Progress Note for this day exists
                ProgressNoteInformation pNote = ProgressNoteInformation.ReturnClientProgressNoteBySessionDate(clientId, appt.Start);

                if (pNote == null)
                {
                    ShowProgressNote(clientId);
                }
                else
                {
                    ShowProgressNote(0, pNote.Id);
                }
            }
        }

        public void EditClientInfoContextMenuHandler(object sender, EventArgs e)
        {
            Appointment appt = schedulerControlMain.SelectedAppointments[0];

            if (appt.CustomFields["ClientId"] != null)
            {
                int clientId = (int)appt.CustomFields["ClientId"];
                ClientInfoForm frm = new ClientInfoForm { EditMode = true, ClientId = clientId };
                frm.ShowDialog();
            }
        }

        private void ribbonControlMain_SelectedPageChanged(object sender, EventArgs e)
        {
            RibbonControl ribbonControl = sender as RibbonControl;

            if (ribbonControl != null && ribbonControl.SelectedPage.Name == "scheduleRibbonPage")
            {
                xtraTabControlMain.SelectedTabPage = xtraTabPageSchedule;
            }

            if (ribbonControl != null && ribbonControl.SelectedPage.Name == "clientRibbonPage")
            {
                xtraTabControlMain.SelectedTabPage = xtraTabPageClient;
            }
        }

        private void barButtonItemNewClient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Show the edit form for the client 
            ClientInfoForm frm = new ClientInfoForm {EditMode = false};
            if (frm.ShowDialog() == DialogResult.OK) FillClientTreeView();
        }

        private void barButtonItemEditClient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int currentId = GetSelectedNodeId();
            if (currentId < 0) currentId = ProgressNoteInformation.ReturnClientIdFromNote(Math.Abs(currentId));

            // Show the edit form for the client 
            if (currentId > 0)
            {
                ClientInfoForm frm = new ClientInfoForm {EditMode = true, ClientId = currentId};
                if (frm.ShowDialog() == DialogResult.OK) FillClientTreeView();
            }
        }
        
        private void barButtonItemAddProgressNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Attach a client 
            int clientId = GetSelectedNodeId();
            if (clientId > 0) ShowProgressNote(clientId);
        }

        private void barButtonItemEditProgressNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // get the client id
            int clientId = GetSelectedNodeId();

            if (clientId > 0)
            {
                ProgressNoteLists noteLists = new ProgressNoteLists();
                noteLists.Client = ClientInformation.GetClientInfo(clientId);
                noteLists.ShowDialog();
            }
            // Attach a client 
            //int noteId = GetSelectedNodeId();
            //if (noteId < 0)
            //{
            //    ShowProgressNote(0, Math.Abs(noteId));
            //    ShowProgressNoteReport(Math.Abs(noteId));
            //}
            //else
            //{
            //    MessageBox.Show("Please select a progress note from the current client list.", "Select Note",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void barButtonItemClientAssessment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int currentId = GetSelectedNodeId();
            if (currentId < 0) currentId = ProgressNoteInformation.ReturnClientIdFromNote(Math.Abs(currentId));

            if (currentId > 0)
            {
                ClientAssessment clientAssessment = ClientAssessment.GetAssessment(currentId) ??
                                                    ClientAssessment.CreateNewClientAssessment(currentId);

                // call the form 
                ClientAssessmentForm assessmentForm = new ClientAssessmentForm {ClientAssessment = clientAssessment};
                if (assessmentForm.ShowDialog() == DialogResult.OK)
                {
                    ShowAssessmentReport(assessmentForm.ClientAssessment);
                }
            }
        }


        private void schedulerControlMain_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            int clientId = 0;
            Appointment appt = e.Appointment;

            // See if we have an existing appointment
            if (appt.CustomFields["ClientId"] != null)
            {
                clientId = (int) appt.CustomFields["ClientId"];
            }
            
            // Set the default duration to one hour
            appt.Duration = TimeSpan.FromHours(1);

            // Display the form 
            CustomAppointmentForm customForm = new CustomAppointmentForm((SchedulerControl) sender, appt, false)
            {
                ClientId = clientId
            };

            e.DialogResult = customForm.ShowDialog();
            schedulerControlMain.Refresh();
            e.Handled = true;
        }

        private void schedulerStorageMain_AppointmentDeleting(object sender, PersistentObjectCancelEventArgs e)
        {
            string msg =
                "Are you sure you would like to delete this appointment?  Once confirmed, the deletion process cannot be reversed.";
            if (
                MessageBox.Show(msg, "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void treeViewClients_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null) return;
            int nodeId = (int)e.Node.Tag;

            if (nodeId == 0) ShowTodayReport();
            if (nodeId > 0) ShowClientInfoReport(nodeId);
            if (nodeId < 0) ShowProgressNoteReport(Math.Abs(nodeId));
        }

        #region Reports
        private void ShowClientInfoReport(int clientId)
        {
            ClientInformation selClientInfo = ClientInformation.GetClientInfo(clientId);
            if (selClientInfo != null)
            {
                ClientInfoReport infoReport = new ClientInfoReport
                {
                    objectDataSourceClient = {DataSource = selClientInfo}
                };

                documentViewerMain.PrintingSystem = infoReport.PrintingSystem;
                infoReport.CreateDocument();
            }
        }

        private void ShowProgressNoteReport(int progressNoteId)
        {
            ProgressNoteInformation selProgressNote = ProgressNoteInformation.ReturnClientProgressNote(progressNoteId);
            if (selProgressNote != null)
            {
                ProgressNoteReport progressNoteReport = new ProgressNoteReport
                {
                    objectDataSourcePN = {DataSource = selProgressNote}
                };

                documentViewerMain.PrintingSystem = progressNoteReport.PrintingSystem;
                progressNoteReport.CreateDocument();
            }
        }

        private void ShowTodayReport()
        {
            TodayReport todayRpt = new TodayReport
            {
                DataSource = AppointmentExtender.GetAppointments(DateTime.Today, DateTime.Today.AddDays(2))
            };

            documentViewerMain.PrintingSystem = todayRpt.PrintingSystem;
            todayRpt.CreateDocument();
        }

        private void ShowAssessmentReport(ClientAssessment clientAssessment)
        {
            ClientAssessmentReport assessmentReport = new ClientAssessmentReport
            {
                objectDataSourceAssessmentData = {DataSource = clientAssessment}
            };

            documentViewerMain.PrintingSystem = assessmentReport.PrintingSystem;
            assessmentReport.CreateDocument();
        }

        #endregion

        private int GetSelectedNodeId()
        {
            if (treeViewClients.SelectedNode == null) return 0;
            return (int) treeViewClients.SelectedNode.Tag;
        }

        private void barButtonItemPrintClientInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            documentViewerMain.ExecCommand(PrintingSystemCommand.Print);
        }
    }
}
