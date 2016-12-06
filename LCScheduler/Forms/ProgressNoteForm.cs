using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using LCScheduler.Data;
using LCScheduler.Model;

namespace LCScheduler.Forms
{
    public partial class ProgressNoteForm : XtraForm
    {
        public MainForm MainFormObject { get; set; }
        public ProgressNoteInformation CurrentProgressNote { get; set; }
        public bool EditMode { get; set; } = false;

        public ProgressNoteForm()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            progressNoteBindingSource.EndEdit();
            CurrentProgressNote = progressNoteBindingSource.DataSource as ProgressNoteInformation;

            if (CurrentProgressNote != null && CurrentProgressNote.TimeEnded < CurrentProgressNote.TimeStarted)
            {
                MessageBox.Show("Please check the session times.  The end time should not be prior to the start time.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (EditMode)
            {
                CurrentProgressNote?.Update();
            }
            else
            {
                // Save the progress note 
                CurrentProgressNote?.Insert();
            }

            // Close the screen 
            DialogResult = DialogResult.OK;
        }

        private void ProgressNoteForm_Load(object sender, EventArgs e)
        {
            // Fill the mental status drop downs
            FillDropDownLists();

            // Only can delete a note that previously exists
            ButtonDeleteNote.Enabled = EditMode;

            // Write out the full name 
            labelControlClientName.Text = ClientInformation.GetClientInfo(CurrentProgressNote.ClientId).FullName;

            //if (CurrentProgressNote.NextSession == null)
            //{
            //    DateTime? nextAppt = AppointmentExtender.GetNextClientAppointment(CurrentProgressNote.ClientId);

            //    if (nextAppt != null)
            //    {
            //        CurrentProgressNote.NextSession = Convert.ToDateTime(nextAppt);
            //    }
            //}

            // Set the binding source 
            progressNoteBindingSource.DataSource = CurrentProgressNote;
        }

        private void FillDropDownLists()
        {
            comboBoxEditAppearance.Properties.Items.AddRange(typeof(ProgressNoteInformation.AppearanceOptions).GetEnumValues());
            comboBoxEditBehavior.Properties.Items.AddRange(typeof(ProgressNoteInformation.BehaviorOptions).GetEnumValues());
            comboBoxEditMoodAffect.Properties.Items.AddRange(typeof(ProgressNoteInformation.MoodAffectOptions).GetEnumValues());
            comboBoxEditCognition.Properties.Items.AddRange(typeof(ProgressNoteInformation.CognitionsOptions).GetEnumValues());
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void checkEditDanger_CheckedChanged(object sender, EventArgs e)
        {
            textEditDescribeDanger.Enabled = checkEditDanger.Checked;
        }

        private void ButtonDeleteNote_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Are you sure you would like to delete this note?  Once confirmed, the process cannot be undone.",
                    "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                CurrentProgressNote.Delete();
                DialogResult = DialogResult.Abort;
            }
        }
    }
}