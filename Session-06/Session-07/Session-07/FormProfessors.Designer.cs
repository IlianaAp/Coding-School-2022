namespace Session_07
{
    partial class FormProfessors
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
            this.listViewProfessors = new System.Windows.Forms.ListView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textAge = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxRank = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxRank.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewProfessors
            // 
            this.listViewProfessors.HideSelection = false;
            this.listViewProfessors.Location = new System.Drawing.Point(12, 34);
            this.listViewProfessors.Name = "listViewProfessors";
            this.listViewProfessors.Size = new System.Drawing.Size(329, 404);
            this.listViewProfessors.TabIndex = 0;
            this.listViewProfessors.UseCompatibleStateImageBehavior = false;
            this.listViewProfessors.SelectedIndexChanged += new System.EventHandler(this.listViewProfessors_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(121, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "List of Professors";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(490, 34);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(150, 20);
            this.textName.TabIndex = 2;
            this.textName.EditValueChanged += new System.EventHandler(this.textName_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(409, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Name";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(409, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(19, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Age";
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(490, 64);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(150, 20);
            this.textAge.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(409, 93);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Rank";
            // 
            // comboBoxRank
            // 
            this.comboBoxRank.Location = new System.Drawing.Point(490, 93);
            this.comboBoxRank.Name = "comboBoxRank";
            this.comboBoxRank.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxRank.Size = new System.Drawing.Size(150, 20);
            this.comboBoxRank.TabIndex = 8;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(383, 381);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(92, 48);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "NEW";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(481, 381);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 49);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(580, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 48);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(684, 381);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 47);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "CLOSE";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormProfessors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.comboBoxRank);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.listViewProfessors);
            this.Name = "FormProfessors";
            this.Text = "Professors Edit";
            this.Load += new System.EventHandler(this.FormProfessors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxRank.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewProfessors;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textAge;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxRank;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}