#region Note
/*
{**************************************************************************************************************}
{  This file is automatically created when you open the Scheduler Control smart tag                            }
{  *and click Create Customizable Appointment Dialog.                                                          }
{  It contains a a descendant of the default appointment editing form created by visual inheritance.           }
{  In Visual Studio Designer add an editor that is required to edit your appointment custom field.             }
{  Modify the LoadFormData method to get data from a custom field and fill your editor with data.              }
{  Modify the SaveFormData method to retrieve data from the editor and set the appointment custom field value. }
{  The code that displays this form is automatically inserted                                                  }
{  *in the EditAppointmentFormShowing event handler of the SchedulerControl.                                   }
{                                                                                                              }
{**************************************************************************************************************}
*/
#endregion Note

using System;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using LCScheduler.Data;
using LCScheduler.Model;

namespace LCScheduler.Forms
{
    public partial class CustomAppointmentForm : DevExpress.XtraScheduler.UI.AppointmentForm
    {
        public int ClientId { get; set; } = 0;

        RecurrenceType recurringType;

        public CustomAppointmentForm()
        {
            InitializeComponent();
        }
        public CustomAppointmentForm(SchedulerControl control, Appointment apt)
            : base(control, apt)
        {
            InitializeComponent();
        }
        public CustomAppointmentForm(SchedulerControl control, Appointment apt, bool openRecurrenceForm)
            : base(control, apt, openRecurrenceForm)
        {
            InitializeComponent();
        }

        public CustomAppointmentForm(SchedulerControl control,
            Appointment apt, bool openRecurrenceForm, RecurrenceType type)
            : base(control, apt, openRecurrenceForm)
        {
            recurringType = type;
            InitializeComponent();
        }

        /// <summary>
        /// Add your code to obtain a custom field value and fill the editor with data.
        /// </summary>
        public override void LoadFormData(Appointment appointment)
        {
            // if we are editing an existing client, then display it
            if (ClientId > 0)
            {
                // fill in the selected client 
                ClientInformation selClient = ClientInformation.GetClientInfo(ClientId);
                comboBoxEditClients.EditValue = selClient;
            }
            else
            {
                tbLocation.Text = "Office";
                edtLabel.SelectedIndex = 2;
            }

            base.LoadFormData(appointment);
        }
        /// <summary>
        /// Add your code to retrieve a value from the editor and set the custom appointment field.
        /// </summary>
        public override bool SaveFormData(Appointment appointment)
        {
            ClientInformation clientInfo = comboBoxEditClients.EditValue as ClientInformation;
            if (clientInfo != null)
            {
                appointment.CustomFields["ClientId"] = clientInfo.Id;

                // Make the client info the subject 
                appointment.Subject = clientInfo.FullName;
            }

            return base.SaveFormData(appointment);
        }

        protected override Form CreateAppointmentRecurrenceForm(Appointment patternCopy,
            FirstDayOfWeek firstDayOfWeek)
        {
            return new CustomRecurrenceForm(patternCopy, firstDayOfWeek,
                Controller, recurringType);
        }

        /// <summary>
        /// Add your code to notify that any custom field is changed. Return true if a custom field is changed, otherwise false.
        /// </summary>
        public override bool IsAppointmentChanged(Appointment appointment)
        {
            return false;
        }

        private void CustomAppointmentForm_Load(object sender, EventArgs e)
        {
            RefreshClientList();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            ClientInformation clientInfo = comboBoxEditClients.EditValue as ClientInformation;
            buttonViewClient.Enabled = clientInfo != null;
            btnOk.Enabled = clientInfo != null;
        }

        private void buttonAddNewClient_Click(object sender, EventArgs e)
        {
            ClientInfoForm frm = new ClientInfoForm {EditMode = false};
            if (frm.ShowDialog() == DialogResult.OK)
            {
                RefreshClientList();
            }
        }

        private void RefreshClientList()
        {
            // Load the clients 
            comboBoxEditClients.Properties.Items.Clear();
            comboBoxEditClients.Properties.Items.AddRange(ClientInformation.ReturnAllClients());
        }

        private void buttonViewClient_Click(object sender, EventArgs e)
        {
            ClientInformation clientInfo = comboBoxEditClients.EditValue as ClientInformation;
            if (clientInfo != null)
            {
                ClientInfoForm frm = new ClientInfoForm
                {
                    ClientId = clientInfo.Id,
                    EditMode = true
                };

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    RefreshClientList();
                }
            }
        }

        private void comboBoxEditClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Write in where they usually go to
            ClientInformation clientInfo = comboBoxEditClients.EditValue as ClientInformation;
            if (clientInfo != null)
            {
                if (clientInfo.LocationIndex == 0)
                {
                    tbLocation.Text = "Office";
                }
                else
                {
                    tbLocation.Text = "Hope House";
                }
            }
        }
    }
}
