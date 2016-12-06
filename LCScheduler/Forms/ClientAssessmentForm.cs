using System;
using System.Windows.Forms;
using LCScheduler.Model;

namespace LCScheduler.Forms
{
    public partial class ClientAssessmentForm : DevExpress.XtraEditors.XtraForm
    {
        public ClientAssessment ClientAssessment { get; set; }
        public ClientAssessmentForm()
        {
            InitializeComponent();
        }

        private void ClientAssessmentForm_Load(object sender, EventArgs e)
        {
            if (ClientAssessment != null)
            {
                if (string.IsNullOrEmpty(ClientAssessment.ClientDateOfBirth))
                {
                    labelControlClientName.Text = ClientAssessment.ClientName;
                }
                else
                {
                    labelControlClientName.Text =
                        $"{ClientAssessment.ClientName} - Date of Birth {ClientAssessment.ClientDateOfBirth}";
                }
                clientAssessmentBindingSource.DataSource = ClientAssessment;
            }
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            ClientAssessment = clientAssessmentBindingSource.DataSource as ClientAssessment;
            if (ClientAssessment != null)
            {
                if (ClientAssessment.Id == 0)
                {
                    ClientAssessment.Insert();
                }
                else
                {
                    ClientAssessment.Update();
                }
            }
            DialogResult = DialogResult.OK;
        }
    }
}