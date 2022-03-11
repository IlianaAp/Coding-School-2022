namespace Session_07
{
    partial class FormStudents
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
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textName = new DevExpress.XtraEditors.TextEdit();
            this.textAge = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textRegistrationNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRegistrationNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewStudents
            // 
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(12, 37);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(298, 401);
            this.listViewStudents.TabIndex = 0;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "List of Students";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(429, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Name";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(533, 30);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(189, 20);
            this.textName.TabIndex = 3;
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(533, 60);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(189, 20);
            this.textAge.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(429, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(19, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Age";
            // 
            // textRegistrationNumber
            // 
            this.textRegistrationNumber.Location = new System.Drawing.Point(533, 92);
            this.textRegistrationNumber.Name = "textRegistrationNumber";
            this.textRegistrationNumber.Size = new System.Drawing.Size(189, 20);
            this.textRegistrationNumber.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(429, 99);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(98, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Registration Number";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(699, 392);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 47);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "CLOSE";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(595, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 48);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "SAVE";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(414, 390);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 49);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "DELETE";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(316, 390);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(92, 48);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "NEW";
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.textRegistrationNumber);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.listViewStudents);
            this.Name = "FormStudents";
            this.Text = "FormStudents";
            this.Load += new System.EventHandler(this.FormStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRegistrationNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewStudents;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textName;
        private DevExpress.XtraEditors.TextEdit textAge;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textRegistrationNumber;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnNew;
    }
}