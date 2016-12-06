namespace LCScheduler.Forms
{
    partial class ProgressNoteForm
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
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.progressNoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.labelControlNextSession = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.timeEdit2 = new DevExpress.XtraEditors.TimeEdit();
            this.timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.textEditNoteType = new DevExpress.XtraEditors.TextEdit();
            this.labelControlNext = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPageTreatmentGoal = new DevExpress.XtraTab.XtraTabPage();
            this.memoEditTreatmentGoal = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPageInterventions = new DevExpress.XtraTab.XtraTabPage();
            this.memoEditClientResponse = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.memoEditIntervention = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPageHomework = new DevExpress.XtraTab.XtraTabPage();
            this.memoEditHomeworkCompleted = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.memoEditHomeworkAssigned = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPageMentalStatus = new DevExpress.XtraTab.XtraTabPage();
            this.checkEditDanger = new DevExpress.XtraEditors.CheckEdit();
            this.comboBoxEditCognition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditMoodAffect = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditBehavior = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditAppearance = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditDescribeDanger = new DevExpress.XtraEditors.MemoEdit();
            this.ButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControlClientName = new DevExpress.XtraEditors.LabelControl();
            this.ButtonDeleteNote = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressNoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNoteType.Properties)).BeginInit();
            this.xtraTabPageTreatmentGoal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditTreatmentGoal.Properties)).BeginInit();
            this.xtraTabPageInterventions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditClientResponse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditIntervention.Properties)).BeginInit();
            this.xtraTabPageHomework.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditHomeworkCompleted.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditHomeworkAssigned.Properties)).BeginInit();
            this.xtraTabPageMentalStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditDanger.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditCognition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMoodAffect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditBehavior.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditAppearance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDescribeDanger.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.progressNoteBindingSource, "SessionNumber", true));
            this.textEdit1.Location = new System.Drawing.Point(121, 41);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(100, 22);
            this.textEdit1.TabIndex = 1;
            // 
            // progressNoteBindingSource
            // 
            this.progressNoteBindingSource.DataSource = typeof(LCScheduler.Data.ProgressNote);
            // 
            // dateEdit1
            // 
            this.dateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.progressNoteBindingSource, "DateOfService", true));
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(122, 41);
            this.dateEdit1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(131, 22);
            this.dateEdit1.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(17, 44);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Date of Service";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabControl1.Appearance.Options.UseFont = true;
            this.xtraTabControl1.AppearancePage.Header.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xtraTabControl1.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl1.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xtraTabControl1.AppearancePage.HeaderActive.Options.UseFont = true;
            this.xtraTabControl1.AppearancePage.HeaderHotTracked.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xtraTabControl1.AppearancePage.HeaderHotTracked.Options.UseFont = true;
            this.xtraTabControl1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.progressNoteBindingSource, "TreatmentGoalAddressed", true));
            this.xtraTabControl1.Location = new System.Drawing.Point(11, 71);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageGeneral;
            this.xtraTabControl1.Size = new System.Drawing.Size(536, 336);
            this.xtraTabControl1.TabIndex = 6;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageGeneral,
            this.xtraTabPageTreatmentGoal,
            this.xtraTabPageInterventions,
            this.xtraTabPageHomework,
            this.xtraTabPageMentalStatus});
            // 
            // xtraTabPageGeneral
            // 
            this.xtraTabPageGeneral.Controls.Add(this.labelControlNextSession);
            this.xtraTabPageGeneral.Controls.Add(this.groupControl1);
            this.xtraTabPageGeneral.Controls.Add(this.labelControl10);
            this.xtraTabPageGeneral.Controls.Add(this.textEditNoteType);
            this.xtraTabPageGeneral.Controls.Add(this.textEdit1);
            this.xtraTabPageGeneral.Controls.Add(this.labelControlNext);
            this.xtraTabPageGeneral.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.xtraTabPageGeneral.Name = "xtraTabPageGeneral";
            this.xtraTabPageGeneral.Size = new System.Drawing.Size(530, 305);
            this.xtraTabPageGeneral.Text = "General";
            // 
            // labelControlNextSession
            // 
            this.labelControlNextSession.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControlNextSession.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControlNextSession.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.progressNoteBindingSource, "NextSession", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "f"));
            this.labelControlNextSession.Location = new System.Drawing.Point(22, 214);
            this.labelControlNextSession.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControlNextSession.Name = "labelControlNextSession";
            this.labelControlNextSession.Size = new System.Drawing.Size(178, 16);
            this.labelControlNextSession.TabIndex = 17;
            this.labelControlNextSession.Text = "Next Session not Scheduled";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Calibri", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.dateEdit1);
            this.groupControl1.Controls.Add(this.timeEdit2);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.timeEdit1);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Location = new System.Drawing.Point(242, 44);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(270, 153);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "Scheduling";
            // 
            // timeEdit2
            // 
            this.timeEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.progressNoteBindingSource, "TimeEnded", true));
            this.timeEdit2.EditValue = new System.DateTime(2015, 5, 23, 0, 0, 0, 0);
            this.timeEdit2.Location = new System.Drawing.Point(122, 105);
            this.timeEdit2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.timeEdit2.Name = "timeEdit2";
            this.timeEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.timeEdit2.Properties.Appearance.Options.UseFont = true;
            this.timeEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit2.Properties.Mask.EditMask = "t";
            this.timeEdit2.Size = new System.Drawing.Size(131, 22);
            this.timeEdit2.TabIndex = 15;
            // 
            // timeEdit1
            // 
            this.timeEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.progressNoteBindingSource, "TimeStarted", true));
            this.timeEdit1.EditValue = new System.DateTime(2015, 5, 23, 0, 0, 0, 0);
            this.timeEdit1.Location = new System.Drawing.Point(122, 73);
            this.timeEdit1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.timeEdit1.Name = "timeEdit1";
            this.timeEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.timeEdit1.Properties.Appearance.Options.UseFont = true;
            this.timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit1.Properties.Mask.EditMask = "t";
            this.timeEdit1.Size = new System.Drawing.Size(131, 22);
            this.timeEdit1.TabIndex = 14;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Location = new System.Drawing.Point(17, 76);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(75, 16);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Time Started";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl9.Location = new System.Drawing.Point(17, 108);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(68, 16);
            this.labelControl9.TabIndex = 9;
            this.labelControl9.Text = "Time Ended";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl10.Location = new System.Drawing.Point(22, 76);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(28, 16);
            this.labelControl10.TabIndex = 11;
            this.labelControl10.Text = "Type";
            // 
            // textEditNoteType
            // 
            this.textEditNoteType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.progressNoteBindingSource, "NoteType", true));
            this.textEditNoteType.Location = new System.Drawing.Point(121, 73);
            this.textEditNoteType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textEditNoteType.Name = "textEditNoteType";
            this.textEditNoteType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEditNoteType.Properties.Appearance.Options.UseFont = true;
            this.textEditNoteType.Size = new System.Drawing.Size(100, 22);
            this.textEditNoteType.TabIndex = 10;
            // 
            // labelControlNext
            // 
            this.labelControlNext.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControlNext.Location = new System.Drawing.Point(22, 44);
            this.labelControlNext.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControlNext.Name = "labelControlNext";
            this.labelControlNext.Size = new System.Drawing.Size(82, 16);
            this.labelControlNext.TabIndex = 13;
            this.labelControlNext.Text = "Next Session";
            // 
            // xtraTabPageTreatmentGoal
            // 
            this.xtraTabPageTreatmentGoal.Controls.Add(this.memoEditTreatmentGoal);
            this.xtraTabPageTreatmentGoal.Controls.Add(this.labelControl12);
            this.xtraTabPageTreatmentGoal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.xtraTabPageTreatmentGoal.Name = "xtraTabPageTreatmentGoal";
            this.xtraTabPageTreatmentGoal.Size = new System.Drawing.Size(530, 305);
            this.xtraTabPageTreatmentGoal.Text = "Treatment";
            // 
            // memoEditTreatmentGoal
            // 
            this.memoEditTreatmentGoal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.progressNoteBindingSource, "TreatmentGoalAddressed", true));
            this.memoEditTreatmentGoal.Location = new System.Drawing.Point(20, 40);
            this.memoEditTreatmentGoal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.memoEditTreatmentGoal.Name = "memoEditTreatmentGoal";
            this.memoEditTreatmentGoal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.memoEditTreatmentGoal.Properties.Appearance.Options.UseFont = true;
            this.memoEditTreatmentGoal.Size = new System.Drawing.Size(400, 100);
            this.memoEditTreatmentGoal.TabIndex = 8;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl12.Location = new System.Drawing.Point(20, 15);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(153, 16);
            this.labelControl12.TabIndex = 7;
            this.labelControl12.Text = "Treatment Goal Addressed";
            // 
            // xtraTabPageInterventions
            // 
            this.xtraTabPageInterventions.Controls.Add(this.memoEditClientResponse);
            this.xtraTabPageInterventions.Controls.Add(this.labelControl14);
            this.xtraTabPageInterventions.Controls.Add(this.memoEditIntervention);
            this.xtraTabPageInterventions.Controls.Add(this.labelControl13);
            this.xtraTabPageInterventions.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.xtraTabPageInterventions.Name = "xtraTabPageInterventions";
            this.xtraTabPageInterventions.Size = new System.Drawing.Size(530, 305);
            this.xtraTabPageInterventions.Text = "Interventions";
            // 
            // memoEditClientResponse
            // 
            this.memoEditClientResponse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.progressNoteBindingSource, "ClientResponse", true));
            this.memoEditClientResponse.Location = new System.Drawing.Point(20, 190);
            this.memoEditClientResponse.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.memoEditClientResponse.Name = "memoEditClientResponse";
            this.memoEditClientResponse.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.memoEditClientResponse.Properties.Appearance.Options.UseFont = true;
            this.memoEditClientResponse.Size = new System.Drawing.Size(400, 100);
            this.memoEditClientResponse.TabIndex = 12;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl14.Location = new System.Drawing.Point(20, 165);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(174, 16);
            this.labelControl14.TabIndex = 11;
            this.labelControl14.Text = "Client Response / Participation";
            // 
            // memoEditIntervention
            // 
            this.memoEditIntervention.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.progressNoteBindingSource, "Interventions", true));
            this.memoEditIntervention.Location = new System.Drawing.Point(20, 40);
            this.memoEditIntervention.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.memoEditIntervention.Name = "memoEditIntervention";
            this.memoEditIntervention.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.memoEditIntervention.Properties.Appearance.Options.UseFont = true;
            this.memoEditIntervention.Size = new System.Drawing.Size(400, 100);
            this.memoEditIntervention.TabIndex = 10;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl13.Location = new System.Drawing.Point(20, 15);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(74, 16);
            this.labelControl13.TabIndex = 9;
            this.labelControl13.Text = "Interventions";
            // 
            // xtraTabPageHomework
            // 
            this.xtraTabPageHomework.Controls.Add(this.memoEditHomeworkCompleted);
            this.xtraTabPageHomework.Controls.Add(this.labelControl15);
            this.xtraTabPageHomework.Controls.Add(this.memoEditHomeworkAssigned);
            this.xtraTabPageHomework.Controls.Add(this.labelControl16);
            this.xtraTabPageHomework.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.xtraTabPageHomework.Name = "xtraTabPageHomework";
            this.xtraTabPageHomework.Size = new System.Drawing.Size(530, 305);
            this.xtraTabPageHomework.Text = "Homework";
            // 
            // memoEditHomeworkCompleted
            // 
            this.memoEditHomeworkCompleted.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.progressNoteBindingSource, "HomeworkCompletedLastSession", true));
            this.memoEditHomeworkCompleted.Location = new System.Drawing.Point(20, 190);
            this.memoEditHomeworkCompleted.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.memoEditHomeworkCompleted.Name = "memoEditHomeworkCompleted";
            this.memoEditHomeworkCompleted.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.memoEditHomeworkCompleted.Properties.Appearance.Options.UseFont = true;
            this.memoEditHomeworkCompleted.Size = new System.Drawing.Size(400, 100);
            this.memoEditHomeworkCompleted.TabIndex = 16;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl15.Location = new System.Drawing.Point(20, 165);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(232, 16);
            this.labelControl15.TabIndex = 15;
            this.labelControl15.Text = "Homework Completed from Last Session";
            // 
            // memoEditHomeworkAssigned
            // 
            this.memoEditHomeworkAssigned.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.progressNoteBindingSource, "HomeworkAssignedToday", true));
            this.memoEditHomeworkAssigned.Location = new System.Drawing.Point(20, 40);
            this.memoEditHomeworkAssigned.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.memoEditHomeworkAssigned.Name = "memoEditHomeworkAssigned";
            this.memoEditHomeworkAssigned.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.memoEditHomeworkAssigned.Properties.Appearance.Options.UseFont = true;
            this.memoEditHomeworkAssigned.Size = new System.Drawing.Size(400, 100);
            this.memoEditHomeworkAssigned.TabIndex = 14;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl16.Location = new System.Drawing.Point(20, 15);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(155, 16);
            this.labelControl16.TabIndex = 13;
            this.labelControl16.Text = "Homework Assigned Today";
            // 
            // xtraTabPageMentalStatus
            // 
            this.xtraTabPageMentalStatus.Controls.Add(this.checkEditDanger);
            this.xtraTabPageMentalStatus.Controls.Add(this.comboBoxEditCognition);
            this.xtraTabPageMentalStatus.Controls.Add(this.comboBoxEditMoodAffect);
            this.xtraTabPageMentalStatus.Controls.Add(this.comboBoxEditBehavior);
            this.xtraTabPageMentalStatus.Controls.Add(this.comboBoxEditAppearance);
            this.xtraTabPageMentalStatus.Controls.Add(this.labelControl7);
            this.xtraTabPageMentalStatus.Controls.Add(this.labelControl6);
            this.xtraTabPageMentalStatus.Controls.Add(this.labelControl5);
            this.xtraTabPageMentalStatus.Controls.Add(this.labelControl4);
            this.xtraTabPageMentalStatus.Controls.Add(this.textEditDescribeDanger);
            this.xtraTabPageMentalStatus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.xtraTabPageMentalStatus.Name = "xtraTabPageMentalStatus";
            this.xtraTabPageMentalStatus.Size = new System.Drawing.Size(530, 305);
            this.xtraTabPageMentalStatus.Text = "Mental Status";
            // 
            // checkEditDanger
            // 
            this.checkEditDanger.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.progressNoteBindingSource, "DangerToOthers", true));
            this.checkEditDanger.Location = new System.Drawing.Point(20, 165);
            this.checkEditDanger.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkEditDanger.Name = "checkEditDanger";
            this.checkEditDanger.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.checkEditDanger.Properties.Appearance.Options.UseFont = true;
            this.checkEditDanger.Properties.Caption = "Danger to Others (if checked, describe)";
            this.checkEditDanger.Size = new System.Drawing.Size(417, 20);
            this.checkEditDanger.TabIndex = 8;
            this.checkEditDanger.CheckedChanged += new System.EventHandler(this.checkEditDanger_CheckedChanged);
            // 
            // comboBoxEditCognition
            // 
            this.comboBoxEditCognition.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", this.progressNoteBindingSource, "Cognitions", true));
            this.comboBoxEditCognition.Location = new System.Drawing.Point(296, 81);
            this.comboBoxEditCognition.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboBoxEditCognition.Name = "comboBoxEditCognition";
            this.comboBoxEditCognition.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxEditCognition.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditCognition.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxEditCognition.Properties.AppearanceDropDown.Options.UseFont = true;
            this.comboBoxEditCognition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditCognition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditCognition.Size = new System.Drawing.Size(141, 22);
            this.comboBoxEditCognition.TabIndex = 7;
            // 
            // comboBoxEditMoodAffect
            // 
            this.comboBoxEditMoodAffect.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", this.progressNoteBindingSource, "MoodAffect", true));
            this.comboBoxEditMoodAffect.Location = new System.Drawing.Point(97, 81);
            this.comboBoxEditMoodAffect.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboBoxEditMoodAffect.Name = "comboBoxEditMoodAffect";
            this.comboBoxEditMoodAffect.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxEditMoodAffect.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditMoodAffect.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxEditMoodAffect.Properties.AppearanceDropDown.Options.UseFont = true;
            this.comboBoxEditMoodAffect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditMoodAffect.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditMoodAffect.Size = new System.Drawing.Size(128, 22);
            this.comboBoxEditMoodAffect.TabIndex = 7;
            // 
            // comboBoxEditBehavior
            // 
            this.comboBoxEditBehavior.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", this.progressNoteBindingSource, "Behavior", true));
            this.comboBoxEditBehavior.Location = new System.Drawing.Point(296, 32);
            this.comboBoxEditBehavior.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboBoxEditBehavior.Name = "comboBoxEditBehavior";
            this.comboBoxEditBehavior.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxEditBehavior.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditBehavior.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxEditBehavior.Properties.AppearanceDropDown.Options.UseFont = true;
            this.comboBoxEditBehavior.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditBehavior.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditBehavior.Size = new System.Drawing.Size(141, 22);
            this.comboBoxEditBehavior.TabIndex = 7;
            // 
            // comboBoxEditAppearance
            // 
            this.comboBoxEditAppearance.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", this.progressNoteBindingSource, "Appearance", true));
            this.comboBoxEditAppearance.Location = new System.Drawing.Point(97, 32);
            this.comboBoxEditAppearance.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboBoxEditAppearance.Name = "comboBoxEditAppearance";
            this.comboBoxEditAppearance.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxEditAppearance.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditAppearance.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxEditAppearance.Properties.AppearanceDropDown.Options.UseFont = true;
            this.comboBoxEditAppearance.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditAppearance.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditAppearance.Size = new System.Drawing.Size(128, 22);
            this.comboBoxEditAppearance.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Location = new System.Drawing.Point(231, 84);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(59, 16);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Cognitions";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Location = new System.Drawing.Point(13, 85);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(77, 16);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Mood / Affect";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Location = new System.Drawing.Point(231, 34);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 16);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Behavior";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Location = new System.Drawing.Point(23, 35);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 16);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Appearance";
            // 
            // textEditDescribeDanger
            // 
            this.textEditDescribeDanger.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.progressNoteBindingSource, "DescribeDanger", true));
            this.textEditDescribeDanger.Location = new System.Drawing.Point(20, 190);
            this.textEditDescribeDanger.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textEditDescribeDanger.Name = "textEditDescribeDanger";
            this.textEditDescribeDanger.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEditDescribeDanger.Properties.Appearance.Options.UseFont = true;
            this.textEditDescribeDanger.Size = new System.Drawing.Size(400, 100);
            this.textEditDescribeDanger.TabIndex = 9;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Appearance.Options.UseFont = true;
            this.ButtonSave.Location = new System.Drawing.Point(367, 417);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(87, 30);
            this.ButtonSave.TabIndex = 7;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.Appearance.Options.UseFont = true;
            this.ButtonCancel.Location = new System.Drawing.Point(460, 417);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(87, 30);
            this.ButtonCancel.TabIndex = 8;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // labelControlClientName
            // 
            this.labelControlClientName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControlClientName.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControlClientName.Location = new System.Drawing.Point(12, 23);
            this.labelControlClientName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControlClientName.Name = "labelControlClientName";
            this.labelControlClientName.Size = new System.Drawing.Size(78, 19);
            this.labelControlClientName.TabIndex = 9;
            this.labelControlClientName.Text = "{ Client }";
            // 
            // ButtonDeleteNote
            // 
            this.ButtonDeleteNote.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteNote.Appearance.Options.UseFont = true;
            this.ButtonDeleteNote.Image = global::LCScheduler.Properties.Resources.Delete;
            this.ButtonDeleteNote.Location = new System.Drawing.Point(12, 417);
            this.ButtonDeleteNote.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonDeleteNote.Name = "ButtonDeleteNote";
            this.ButtonDeleteNote.Size = new System.Drawing.Size(205, 30);
            this.ButtonDeleteNote.TabIndex = 10;
            this.ButtonDeleteNote.Text = "Delete Note...";
            this.ButtonDeleteNote.Click += new System.EventHandler(this.ButtonDeleteNote_Click);
            // 
            // ProgressNoteForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(556, 459);
            this.Controls.Add(this.ButtonDeleteNote);
            this.Controls.Add(this.labelControlClientName);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.xtraTabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressNoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Progress Note";
            this.Load += new System.EventHandler(this.ProgressNoteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressNoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageGeneral.ResumeLayout(false);
            this.xtraTabPageGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNoteType.Properties)).EndInit();
            this.xtraTabPageTreatmentGoal.ResumeLayout(false);
            this.xtraTabPageTreatmentGoal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditTreatmentGoal.Properties)).EndInit();
            this.xtraTabPageInterventions.ResumeLayout(false);
            this.xtraTabPageInterventions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditClientResponse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditIntervention.Properties)).EndInit();
            this.xtraTabPageHomework.ResumeLayout(false);
            this.xtraTabPageHomework.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditHomeworkCompleted.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditHomeworkAssigned.Properties)).EndInit();
            this.xtraTabPageMentalStatus.ResumeLayout(false);
            this.xtraTabPageMentalStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditDanger.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditCognition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMoodAffect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditBehavior.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditAppearance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDescribeDanger.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageGeneral;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageMentalStatus;
        private DevExpress.XtraEditors.CheckEdit checkEditDanger;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditCognition;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditMoodAffect;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditBehavior;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditAppearance;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton ButtonSave;
        private DevExpress.XtraEditors.LabelControl labelControlNext;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit textEditNoteType;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageTreatmentGoal;
        private DevExpress.XtraEditors.MemoEdit memoEditTreatmentGoal;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageInterventions;
        private DevExpress.XtraEditors.MemoEdit memoEditClientResponse;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.MemoEdit memoEditIntervention;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageHomework;
        private DevExpress.XtraEditors.MemoEdit memoEditHomeworkCompleted;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.MemoEdit memoEditHomeworkAssigned;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.SimpleButton ButtonCancel;
        private System.Windows.Forms.BindingSource progressNoteBindingSource;
        private DevExpress.XtraEditors.TimeEdit timeEdit1;
        private DevExpress.XtraEditors.TimeEdit timeEdit2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControlClientName;
        private DevExpress.XtraEditors.MemoEdit textEditDescribeDanger;
        private DevExpress.XtraEditors.LabelControl labelControlNextSession;
        private DevExpress.XtraEditors.SimpleButton ButtonDeleteNote;
    }
}