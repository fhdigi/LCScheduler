namespace LCScheduler.Forms
{
    partial class ProgressNoteLists
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelControlClientName = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonEdit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonView = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewNoteList = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTreatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNoteList)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlClientName
            // 
            this.labelControlClientName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlClientName.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControlClientName.Location = new System.Drawing.Point(26, 33);
            this.labelControlClientName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labelControlClientName.Name = "labelControlClientName";
            this.labelControlClientName.Size = new System.Drawing.Size(171, 28);
            this.labelControlClientName.TabIndex = 1;
            this.labelControlClientName.Text = "{Client Name}";
            // 
            // simpleButtonEdit
            // 
            this.simpleButtonEdit.Location = new System.Drawing.Point(1623, 33);
            this.simpleButtonEdit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.simpleButtonEdit.Name = "simpleButtonEdit";
            this.simpleButtonEdit.Size = new System.Drawing.Size(125, 40);
            this.simpleButtonEdit.TabIndex = 4;
            this.simpleButtonEdit.Text = "Edit...";
            this.simpleButtonEdit.Click += new System.EventHandler(this.simpleButtonEdit_Click);
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonCancel.Location = new System.Drawing.Point(1623, 136);
            this.simpleButtonCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(125, 40);
            this.simpleButtonCancel.TabIndex = 5;
            this.simpleButtonCancel.Text = "Close";
            // 
            // simpleButtonView
            // 
            this.simpleButtonView.Location = new System.Drawing.Point(1623, 85);
            this.simpleButtonView.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.simpleButtonView.Name = "simpleButtonView";
            this.simpleButtonView.Size = new System.Drawing.Size(125, 40);
            this.simpleButtonView.TabIndex = 6;
            this.simpleButtonView.Text = "View...";
            this.simpleButtonView.Click += new System.EventHandler(this.simpleButtonView_Click);
            // 
            // dataGridViewNoteList
            // 
            this.dataGridViewNoteList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNoteList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colTreatment});
            this.dataGridViewNoteList.Location = new System.Drawing.Point(26, 95);
            this.dataGridViewNoteList.MultiSelect = false;
            this.dataGridViewNoteList.Name = "dataGridViewNoteList";
            this.dataGridViewNoteList.ReadOnly = true;
            this.dataGridViewNoteList.RowHeadersWidth = 20;
            this.dataGridViewNoteList.RowTemplate.Height = 31;
            this.dataGridViewNoteList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNoteList.Size = new System.Drawing.Size(1556, 716);
            this.dataGridViewNoteList.TabIndex = 7;
            // 
            // colDate
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDate.HeaderText = "Date of Service";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colTreatment
            // 
            this.colTreatment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colTreatment.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTreatment.HeaderText = "Treatment";
            this.colTreatment.Name = "colTreatment";
            this.colTreatment.ReadOnly = true;
            // 
            // ProgressNoteLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1787, 838);
            this.Controls.Add(this.dataGridViewNoteList);
            this.Controls.Add(this.simpleButtonView);
            this.Controls.Add(this.simpleButtonEdit);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.labelControlClientName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressNoteLists";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Progress Note Lists";
            this.Load += new System.EventHandler(this.ProgressNoteLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNoteList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControlClientName;
        private DevExpress.XtraEditors.SimpleButton simpleButtonEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonView;
        private System.Windows.Forms.DataGridView dataGridViewNoteList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTreatment;
    }
}