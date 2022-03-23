namespace Session_11
{
    partial class EngineerEditForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ctrlManager = new DevExpress.XtraEditors.LookUpEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlSallary = new DevExpress.XtraEditors.TextEdit();
            this.ctrlSurname = new DevExpress.XtraEditors.TextEdit();
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Name = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Manager = new DevExpress.XtraLayout.LayoutControlItem();
            this.bsEngineers = new System.Windows.Forms.BindingSource(this.components);
            this.bsListOfEngineers = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlManager.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSallary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Manager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEngineers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListOfEngineers)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ctrlManager);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.ctrlSallary);
            this.layoutControl1.Controls.Add(this.ctrlSurname);
            this.layoutControl1.Controls.Add(this.ctrlName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(504, 420);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ctrlManager
            // 
            this.ctrlManager.Location = new System.Drawing.Point(66, 84);
            this.ctrlManager.Name = "ctrlManager";
            this.ctrlManager.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlManager.Size = new System.Drawing.Size(426, 20);
            this.ctrlManager.StyleController = this.layoutControl1;
            this.ctrlManager.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(254, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(238, 22);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(238, 22);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlSallary
            // 
            this.ctrlSallary.Location = new System.Drawing.Point(66, 60);
            this.ctrlSallary.Name = "ctrlSallary";
            this.ctrlSallary.Size = new System.Drawing.Size(426, 20);
            this.ctrlSallary.StyleController = this.layoutControl1;
            this.ctrlSallary.TabIndex = 8;
            // 
            // ctrlSurname
            // 
            this.ctrlSurname.Location = new System.Drawing.Point(66, 36);
            this.ctrlSurname.Name = "ctrlSurname";
            this.ctrlSurname.Size = new System.Drawing.Size(426, 20);
            this.ctrlSurname.StyleController = this.layoutControl1;
            this.ctrlSurname.TabIndex = 6;
            // 
            // ctrlName
            // 
            this.ctrlName.Location = new System.Drawing.Point(66, 12);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(426, 20);
            this.ctrlName.StyleController = this.layoutControl1;
            this.ctrlName.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Name,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.Manager});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(504, 420);
            this.Root.TextVisible = false;
            // 
            // Name
            // 
            this.Name.Control = this.ctrlName;
            this.Name.Location = new System.Drawing.Point(0, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(484, 24);
            this.Name.TextSize = new System.Drawing.Size(42, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 96);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(484, 278);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ctrlSurname;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(484, 24);
            this.layoutControlItem3.Text = "Surname";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ctrlSallary;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(484, 24);
            this.layoutControlItem5.Text = "Sallary";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnSave;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 374);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(242, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnCancel;
            this.layoutControlItem2.Location = new System.Drawing.Point(242, 374);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(242, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // Manager
            // 
            this.Manager.Control = this.ctrlManager;
            this.Manager.CustomizationFormText = "Manager";
            this.Manager.Location = new System.Drawing.Point(0, 72);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(484, 24);
            this.Manager.TextSize = new System.Drawing.Size(42, 13);
            // 
            // EngineerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 420);
            this.Controls.Add(this.layoutControl1);
            //this.Name = "EngineerEditForm";
            this.Text = "New Engineer";
            this.Load += new System.EventHandler(this.EngineerEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlManager.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSallary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Manager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEngineers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListOfEngineers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit ctrlSallary;
        private DevExpress.XtraEditors.TextEdit ctrlSurname;
        private DevExpress.XtraEditors.TextEdit ctrlName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem Name;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private BindingSource bsEngineers;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LookUpEdit ctrlManager;
        private DevExpress.XtraLayout.LayoutControlItem Manager;
        private BindingSource bsListOfEngineers;
    }
}