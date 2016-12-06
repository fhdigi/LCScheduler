using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LCScheduler.Data;
using LCScheduler.Model;

namespace LCScheduler.Forms
{
    public partial class ProgressNoteEntry : XtraForm
    {
        public ProgressNoteInformation CurrentNote;

        public ProgressNoteEntry()
        {
            InitializeComponent();
        }

        private void ProgressNoteEntry_Load(object sender, EventArgs e)
        {
            // fill in the mental status drop downs
            AppearanceTextEdit.Properties.Items.AddRange(typeof(ProgressNoteInformation.AppearanceOptions).GetEnumValues());
            BehaviorTextEdit.Properties.Items.AddRange(typeof(ProgressNoteInformation.BehaviorOptions).GetEnumValues());
            MoodAffectComboBoxEdit.Properties.Items.AddRange(typeof(ProgressNoteInformation.MoodAffectOptions).GetEnumValues());
            CognitionsComboBoxEdit.Properties.Items.AddRange(typeof(ProgressNoteInformation.CognitionsOptions).GetEnumValues());

            // set the data source 
            progressNoteBindingSource.DataSource = CurrentNote;
            //this.progressNoteTableAdapter.Fill(this.lCScheduleDataDataSet.ProgressNote);

            // Write out the client name 
            simpleLabelItemClientName.Text = ClientInformation.GetClientInfo(CurrentNote.ClientId).FullName;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Get the data from the binding source
            progressNoteBindingSource.EndEdit();

            // Pull the object from the data source 
            CurrentNote = progressNoteBindingSource.DataSource as ProgressNoteInformation;
            
            // save the progress note 
            CurrentNote?.Insert();

            // close the screen 
            DialogResult = DialogResult.OK;
        }

        private void BehaviorTextEdit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}