namespace Session_11
{
    partial class CarServiceCenterForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.engineerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEngineer = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editServiceTask = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTrasaction = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyLedgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.labelUsername = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.carToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.engineerToolStripMenuItem,
            this.serviceTaskToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.monthlyLedgerToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCustomer});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // editCustomer
            // 
            this.editCustomer.Name = "editCustomer";
            this.editCustomer.Size = new System.Drawing.Size(103, 22);
            this.editCustomer.Text = "Edit...";
            this.editCustomer.Click += new System.EventHandler(this.editCustomer_Click);
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem1});
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.carToolStripMenuItem.Text = "Car";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.editToolStripMenuItem1.Text = "Edit...";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editCar_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem2});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.staffToolStripMenuItem.Text = "Manager";
            // 
            // editToolStripMenuItem2
            // 
            this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            this.editToolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
            this.editToolStripMenuItem2.Text = "Edit...";
            this.editToolStripMenuItem2.Click += new System.EventHandler(this.editToolStripMenuItem2_Click);
            // 
            // engineerToolStripMenuItem
            // 
            this.engineerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editEngineer});
            this.engineerToolStripMenuItem.Name = "engineerToolStripMenuItem";
            this.engineerToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.engineerToolStripMenuItem.Text = "Engineer";
            // 
            // editEngineer
            // 
            this.editEngineer.Name = "editEngineer";
            this.editEngineer.Size = new System.Drawing.Size(100, 22);
            this.editEngineer.Text = "Edit..";
            this.editEngineer.Click += new System.EventHandler(this.editEngineer_Click);
            // 
            // serviceTaskToolStripMenuItem
            // 
            this.serviceTaskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editServiceTask});
            this.serviceTaskToolStripMenuItem.Name = "serviceTaskToolStripMenuItem";
            this.serviceTaskToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.serviceTaskToolStripMenuItem.Text = "Service Task";
            // 
            // editServiceTask
            // 
            this.editServiceTask.Name = "editServiceTask";
            this.editServiceTask.Size = new System.Drawing.Size(103, 22);
            this.editServiceTask.Text = "Edit...";
            this.editServiceTask.Click += new System.EventHandler(this.editServiceTask_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTrasaction});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // newTrasaction
            // 
            this.newTrasaction.Name = "newTrasaction";
            this.newTrasaction.Size = new System.Drawing.Size(103, 22);
            this.newTrasaction.Text = "Edit...";
            this.newTrasaction.Click += new System.EventHandler(this.newTrasaction_Click);
            // 
            // monthlyLedgerToolStripMenuItem
            // 
            this.monthlyLedgerToolStripMenuItem.Name = "monthlyLedgerToolStripMenuItem";
            this.monthlyLedgerToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.monthlyLedgerToolStripMenuItem.Text = "Monthly Ledger";
            this.monthlyLedgerToolStripMenuItem.Click += new System.EventHandler(this.monthlyLedgerToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.labelUsername);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(765, 345);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelUsername
            // 
            this.labelUsername.Location = new System.Drawing.Point(705, 12);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(48, 13);
            this.labelUsername.StyleController = this.layoutControl1;
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Username";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(765, 345);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(693, 17);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(52, 308);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.labelUsername;
            this.layoutControlItem1.Location = new System.Drawing.Point(693, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(52, 17);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(693, 325);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // CarServiceCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 369);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CarServiceCenterForm";
            this.Text = "Car Service Center";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.CarServiceCenterForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem transactionToolStripMenuItem;
        private ToolStripMenuItem newTrasaction;
        private ToolStripMenuItem staffToolStripMenuItem;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private ToolStripMenuItem monthlyLedgerToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem editCustomer;
        private ToolStripMenuItem carToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem2;
        private ToolStripMenuItem engineerToolStripMenuItem;
        private ToolStripMenuItem editEngineer;
        private ToolStripMenuItem serviceTaskToolStripMenuItem;
        private ToolStripMenuItem editServiceTask;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private DevExpress.XtraEditors.LabelControl labelUsername;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}