namespace LCScheduler.Forms
{
    partial class CustomAppointmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxEditClients = new DevExpress.XtraEditors.ComboBoxEdit();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.buttonAddNewClient = new DevExpress.XtraEditors.SimpleButton();
            this.buttonViewClient = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtShowTimeAs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.ResourcesCheckedListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReminder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReminder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            this.progressPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditClients.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubject
            // 
            this.lblSubject.Location = new System.Drawing.Point(224, 566);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Visible = false;
            // 
            // lblLocation
            // 
            this.lblLocation.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblLocation.Location = new System.Drawing.Point(333, 169);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblLocation.Size = new System.Drawing.Size(52, 16);
            this.lblLocation.TabIndex = 10;
            // 
            // lblLabel
            // 
            this.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblLabel.Location = new System.Drawing.Point(22, 12);
            this.lblLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblLabel.TabIndex = 1;
            // 
            // lblStartTime
            // 
            this.lblStartTime.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblStartTime.Location = new System.Drawing.Point(335, 61);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblStartTime.Size = new System.Drawing.Size(28, 16);
            this.lblStartTime.TabIndex = 3;
            this.lblStartTime.Text = "S&tart";
            // 
            // lblEndTime
            // 
            this.lblEndTime.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblEndTime.Location = new System.Drawing.Point(335, 92);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblEndTime.Size = new System.Drawing.Size(21, 16);
            this.lblEndTime.TabIndex = 6;
            this.lblEndTime.Text = "&End";
            // 
            // lblShowTimeAs
            // 
            this.lblShowTimeAs.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblShowTimeAs.Location = new System.Drawing.Point(326, 222);
            this.lblShowTimeAs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblShowTimeAs.Size = new System.Drawing.Size(83, 16);
            this.lblShowTimeAs.TabIndex = 12;
            // 
            // chkAllDay
            // 
            this.chkAllDay.Location = new System.Drawing.Point(0, 46);
            this.chkAllDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkAllDay.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.Location = new System.Drawing.Point(408, 295);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Size = new System.Drawing.Size(87, 28);
            this.btnOk.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(501, 295);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Size = new System.Drawing.Size(87, 28);
            this.btnCancel.TabIndex = 16;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Image = global::LCScheduler.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(13, 295);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Size = new System.Drawing.Size(87, 28);
            this.btnDelete.TabIndex = 14;
            // 
            // btnRecurrence
            // 
            this.btnRecurrence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRecurrence.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnRecurrence.Appearance.Options.UseFont = true;
            this.btnRecurrence.Image = global::LCScheduler.Properties.Resources.Recurrence;
            this.btnRecurrence.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnRecurrence.Location = new System.Drawing.Point(336, 120);
            this.btnRecurrence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRecurrence.Size = new System.Drawing.Size(220, 28);
            this.btnRecurrence.TabIndex = 9;
            this.btnRecurrence.Text = "Make Appointment &Recurring";
            // 
            // edtStartDate
            // 
            this.edtStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.edtStartDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartDate.Location = new System.Drawing.Point(369, 60);
            this.edtStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edtStartDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.edtStartDate.Properties.Appearance.Options.UseFont = true;
            this.edtStartDate.Size = new System.Drawing.Size(94, 22);
            this.edtStartDate.TabIndex = 4;
            // 
            // edtEndDate
            // 
            this.edtEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.edtEndDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndDate.Location = new System.Drawing.Point(369, 90);
            this.edtEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edtEndDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.edtEndDate.Properties.Appearance.Options.UseFont = true;
            this.edtEndDate.Size = new System.Drawing.Size(94, 22);
            this.edtEndDate.TabIndex = 7;
            // 
            // edtStartTime
            // 
            this.edtStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.edtStartTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartTime.Location = new System.Drawing.Point(469, 60);
            this.edtStartTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edtStartTime.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.edtStartTime.Properties.Appearance.Options.UseFont = true;
            this.edtStartTime.Properties.Mask.EditMask = "t";
            this.edtStartTime.Size = new System.Drawing.Size(86, 22);
            this.edtStartTime.TabIndex = 5;
            // 
            // edtEndTime
            // 
            this.edtEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.edtEndTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndTime.Location = new System.Drawing.Point(469, 90);
            this.edtEndTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edtEndTime.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.edtEndTime.Properties.Appearance.Options.UseFont = true;
            this.edtEndTime.Properties.Mask.EditMask = "t";
            this.edtEndTime.Size = new System.Drawing.Size(86, 22);
            this.edtEndTime.TabIndex = 8;
            // 
            // edtLabel
            // 
            this.edtLabel.Location = new System.Drawing.Point(87, 14);
            this.edtLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edtLabel.Size = new System.Drawing.Size(131, 20);
            // 
            // edtShowTimeAs
            // 
            this.edtShowTimeAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.edtShowTimeAs.Location = new System.Drawing.Point(335, 242);
            this.edtShowTimeAs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edtShowTimeAs.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.edtShowTimeAs.Properties.Appearance.Options.UseFont = true;
            this.edtShowTimeAs.Size = new System.Drawing.Size(220, 22);
            this.edtShowTimeAs.TabIndex = 13;
            // 
            // tbSubject
            // 
            this.tbSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSubject.Location = new System.Drawing.Point(255, 562);
            this.tbSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSubject.Size = new System.Drawing.Size(79, 20);
            this.tbSubject.TabIndex = 3;
            this.tbSubject.Visible = false;
            // 
            // edtResource
            // 
            this.edtResource.Location = new System.Drawing.Point(87, 76);
            this.edtResource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edtResource.Size = new System.Drawing.Size(131, 20);
            this.edtResource.Visible = false;
            // 
            // lblResource
            // 
            this.lblResource.Location = new System.Drawing.Point(2, 80);
            this.lblResource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblResource.Visible = false;
            // 
            // edtResources
            // 
            this.edtResources.Location = new System.Drawing.Point(87, 76);
            this.edtResources.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.edtResources.ResourcesCheckedListBoxControl.CheckOnClick = true;
            this.edtResources.ResourcesCheckedListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtResources.ResourcesCheckedListBoxControl.Location = new System.Drawing.Point(0, 0);
            this.edtResources.ResourcesCheckedListBoxControl.Name = "";
            this.edtResources.ResourcesCheckedListBoxControl.Size = new System.Drawing.Size(200, 100);
            this.edtResources.ResourcesCheckedListBoxControl.TabIndex = 0;
            this.edtResources.Size = new System.Drawing.Size(131, 20);
            // 
            // chkReminder
            // 
            this.chkReminder.Location = new System.Drawing.Point(0, 122);
            this.chkReminder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkReminder.Visible = false;
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDescription.Location = new System.Drawing.Point(30, 195);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbDescription.Properties.Appearance.Options.UseFont = true;
            this.tbDescription.Size = new System.Drawing.Size(264, 69);
            this.tbDescription.TabIndex = 1;
            // 
            // cbReminder
            // 
            this.cbReminder.Location = new System.Drawing.Point(87, 122);
            this.cbReminder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbReminder.Size = new System.Drawing.Size(131, 20);
            this.cbReminder.Visible = false;
            // 
            // tbLocation
            // 
            this.tbLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbLocation.Location = new System.Drawing.Point(335, 188);
            this.tbLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLocation.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbLocation.Properties.Appearance.Options.UseFont = true;
            this.tbLocation.Size = new System.Drawing.Size(220, 22);
            this.tbLocation.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Location = new System.Drawing.Point(367, 566);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Size = new System.Drawing.Size(223, 154);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // progressPanel
            // 
            this.progressPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.progressPanel.Location = new System.Drawing.Point(153, 629);
            this.progressPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressPanel.Size = new System.Drawing.Size(437, 42);
            this.progressPanel.TabIndex = 15;
            // 
            // tbProgress
            // 
            this.tbProgress.Location = new System.Drawing.Point(93, 1);
            this.tbProgress.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.tbProgress.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tbProgress.Size = new System.Drawing.Size(310, 38);
            // 
            // lblPercentComplete
            // 
            this.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentComplete.Location = new System.Drawing.Point(0, 12);
            this.lblPercentComplete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // lblPercentCompleteValue
            // 
            this.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentCompleteValue.Location = new System.Drawing.Point(416, 12);
            this.lblPercentCompleteValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // comboBoxEditClients
            // 
            this.comboBoxEditClients.Location = new System.Drawing.Point(18, 38);
            this.comboBoxEditClients.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEditClients.Name = "comboBoxEditClients";
            this.comboBoxEditClients.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxEditClients.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditClients.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxEditClients.Properties.AppearanceDropDown.Options.UseFont = true;
            this.comboBoxEditClients.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxEditClients.Properties.AppearanceFocused.Options.UseFont = true;
            this.comboBoxEditClients.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditClients.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditClients.Size = new System.Drawing.Size(264, 22);
            this.comboBoxEditClients.TabIndex = 0;
            this.comboBoxEditClients.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditClients_SelectedIndexChanged);
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // buttonAddNewClient
            // 
            this.buttonAddNewClient.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonAddNewClient.Appearance.Options.UseFont = true;
            this.buttonAddNewClient.Location = new System.Drawing.Point(18, 70);
            this.buttonAddNewClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddNewClient.Name = "buttonAddNewClient";
            this.buttonAddNewClient.Size = new System.Drawing.Size(128, 27);
            this.buttonAddNewClient.TabIndex = 1;
            this.buttonAddNewClient.Text = "Add New Client...";
            this.buttonAddNewClient.Click += new System.EventHandler(this.buttonAddNewClient_Click);
            // 
            // buttonViewClient
            // 
            this.buttonViewClient.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonViewClient.Appearance.Options.UseFont = true;
            this.buttonViewClient.Location = new System.Drawing.Point(154, 70);
            this.buttonViewClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonViewClient.Name = "buttonViewClient";
            this.buttonViewClient.Size = new System.Drawing.Size(128, 27);
            this.buttonViewClient.TabIndex = 2;
            this.buttonViewClient.Text = "View Client...";
            this.buttonViewClient.Click += new System.EventHandler(this.buttonViewClient_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(18, 120);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Comments";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImage = global::LCScheduler.Properties.Resources.Man_Blue_New;
            this.groupControl1.Controls.Add(this.comboBoxEditClients);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.buttonAddNewClient);
            this.groupControl1.Controls.Add(this.buttonViewClient);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(292, 267);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Select Client";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.CaptionImage = global::LCScheduler.Properties.Resources.Scheduling;
            this.groupControl2.Location = new System.Drawing.Point(310, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(277, 267);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Appointment Times / Location";
            // 
            // CustomAppointmentForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(599, 336);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(518, 306);
            this.Name = "CustomAppointmentForm";
            this.Load += new System.EventHandler(this.CustomAppointmentForm_Load);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            this.Controls.SetChildIndex(this.edtShowTimeAs, 0);
            this.Controls.SetChildIndex(this.edtEndTime, 0);
            this.Controls.SetChildIndex(this.edtEndDate, 0);
            this.Controls.SetChildIndex(this.btnRecurrence, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lblShowTimeAs, 0);
            this.Controls.SetChildIndex(this.lblEndTime, 0);
            this.Controls.SetChildIndex(this.tbLocation, 0);
            this.Controls.SetChildIndex(this.lblSubject, 0);
            this.Controls.SetChildIndex(this.lblLocation, 0);
            this.Controls.SetChildIndex(this.tbSubject, 0);
            this.Controls.SetChildIndex(this.lblStartTime, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.edtStartDate, 0);
            this.Controls.SetChildIndex(this.edtStartTime, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.progressPanel, 0);
            this.Controls.SetChildIndex(this.tbDescription, 0);
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtShowTimeAs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.ResourcesCheckedListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReminder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReminder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditClients.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditClients;
        private System.Windows.Forms.Timer timerMain;
        private DevExpress.XtraEditors.SimpleButton buttonAddNewClient;
        private DevExpress.XtraEditors.SimpleButton buttonViewClient;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}
