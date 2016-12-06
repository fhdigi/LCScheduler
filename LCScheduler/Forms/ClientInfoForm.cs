using System;
using System.Windows.Forms;
using LCScheduler.Data;
using LCScheduler.Model;

namespace LCScheduler.Forms
{
    public partial class ClientInfoForm : DevExpress.XtraEditors.XtraForm
    {
        public bool EditMode { get; set; } = false;
        public int ClientId { get; set; } = 0;

        private ClientInformation _clientObj;

        public ClientInfoForm()
        {
            InitializeComponent();
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            FillDropDowns();

            _clientObj = EditMode ? ClientInformation.GetClientInfo(ClientId) : new ClientInformation() { State = "NY", Gender = 0, MaritalStatus = 0, DateOfBirth = DateTime.Today.ToShortDateString(), InsuredDateOfBirth = DateTime.Today.ToShortDateString(), RelationshipToInsured = 0};
            bindingSourceClient.DataSource = _clientObj;
        }

        private void FillDropDowns()
        {
            GenderComboBoxEdit.Properties.Items.Add("Male");
            GenderComboBoxEdit.Properties.Items.Add("Female");

            InsuredGenderComboBoxEdit.Properties.Items.Add("Male");
            InsuredGenderComboBoxEdit.Properties.Items.Add("Female");

            MaritalStatusComboBoxEdit.Properties.Items.Add("Single");
            MaritalStatusComboBoxEdit.Properties.Items.Add("Married");
            MaritalStatusComboBoxEdit.Properties.Items.Add("Other");

            RelationshipToInsuredComboBoxEdit.Properties.Items.Add("Self");
            RelationshipToInsuredComboBoxEdit.Properties.Items.Add("Spouse");
            RelationshipToInsuredComboBoxEdit.Properties.Items.Add("Child");
            RelationshipToInsuredComboBoxEdit.Properties.Items.Add("Other");

            // Added 14-November-2015
            LocationIndexComboBoxEdit.Properties.Items.Add("Office");
            LocationIndexComboBoxEdit.Properties.Items.Add("Hope House");
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProviderClient.Validate())
            {
                // Get the data from the binding source
                bindingSourceClient.EndEdit();

                // Pull the object from the data source 
                _clientObj = bindingSourceClient.DataSource as ClientInformation;

                if (EditMode)
                {
                    _clientObj?.Update();
                }
                else
                {
                    // Save the data to the database 
                    _clientObj?.Insert();
                }

                // close the screen 
                DialogResult = DialogResult.OK;
            }
        }

        private void RelationshipToInsuredComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonCopyToInsured.Enabled = RelationshipToInsuredComboBoxEdit.SelectedIndex == 0;
            InsuredNameTextEdit.Enabled = RelationshipToInsuredComboBoxEdit.SelectedIndex != 0;
            InsuredDateOfBirthDateEdit.Enabled = RelationshipToInsuredComboBoxEdit.SelectedIndex != 0;
            InsuredGenderComboBoxEdit.Enabled = RelationshipToInsuredComboBoxEdit.SelectedIndex != 0;
        }

        private void UpdateInsuredName()
        {
            InsuredNameTextEdit.Text = $"{FirstNameTextEdit.Text} {LastNameTextEdit.Text}";
        }

        private void buttonCopyToInsured_Click(object sender, EventArgs e)
        {
            if (RelationshipToInsuredComboBoxEdit.SelectedIndex == 0)
            {
                UpdateInsuredName();
                InsuredDateOfBirthDateEdit.DateTime = DateOfBirthDateEdit.DateTime;
                InsuredGenderComboBoxEdit.SelectedIndex = GenderComboBoxEdit.SelectedIndex;
            }
        }
    }
}