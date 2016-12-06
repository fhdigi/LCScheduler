using System.Windows.Forms;
using LCScheduler.Model;

namespace LCScheduler.Forms
{
	public partial class ProgressNoteLists: DevExpress.XtraEditors.XtraForm
	{
        public ClientInformation  Client { get; set; }

        public ProgressNoteLists()
		{
            InitializeComponent();
		}
        private void ProgressNoteLists_Load(object sender, System.EventArgs e)
        {
            // set the client name 
            labelControlClientName.Text = Client.FullName;

            // load the client progress notes 
            LoadProgressNotes();
        }

	    private void LoadProgressNotes()
	    {
            foreach (ProgressNoteInformation pnObj in ProgressNoteInformation.ReturnClientProgressNotes(Client.Id))
            {
                int newRow = dataGridViewNoteList.Rows.Add();
                DataGridViewRow dgr = dataGridViewNoteList.Rows[newRow];
                dgr.Cells["colDate"].Value = pnObj.DateOfService.ToShortDateString();
                dgr.Cells["colTreatment"].Value = pnObj.TreatmentGoalAddressed;
                dgr.Tag = pnObj.Id;
            }
        }

        private void simpleButtonView_Click(object sender, System.EventArgs e)
        {

        }

        private void simpleButtonEdit_Click(object sender, System.EventArgs e)
        {
            if (dataGridViewNoteList.SelectedRows.Count > 0)
            {
                DataGridViewRow dgr = dataGridViewNoteList.SelectedRows[0];

                // get the progress note id from the tag of the selected item
                int progressNoteId = (int) dgr.Tag;

                ProgressNoteForm noteForm = new ProgressNoteForm
                {
                    CurrentProgressNote = ProgressNoteInformation.ReturnClientProgressNote(progressNoteId)
                };

                // Show the screen 
                noteForm.ShowDialog();
            }
        }
    }
}