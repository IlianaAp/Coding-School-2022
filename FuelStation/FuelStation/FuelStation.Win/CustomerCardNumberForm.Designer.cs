namespace FuelStation.Win
{
    partial class CustomerCardNumberForm
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
            this.textCardNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorCardNumberLabel = new System.Windows.Forms.Label();
            this.addNewCustomerLabel = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCardNumber
            // 
            this.textCardNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCardNumber.Location = new System.Drawing.Point(120, 102);
            this.textCardNumber.Name = "textCardNumber";
            this.textCardNumber.Size = new System.Drawing.Size(263, 33);
            this.textCardNumber.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(143, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Customer Card Number";
            // 
            // errorCardNumberLabel
            // 
            this.errorCardNumberLabel.AutoSize = true;
            this.errorCardNumberLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorCardNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.errorCardNumberLabel.Location = new System.Drawing.Point(120, 151);
            this.errorCardNumberLabel.Name = "errorCardNumberLabel";
            this.errorCardNumberLabel.Size = new System.Drawing.Size(0, 17);
            this.errorCardNumberLabel.TabIndex = 16;
            // 
            // addNewCustomerLabel
            // 
            this.addNewCustomerLabel.AutoSize = true;
            this.addNewCustomerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewCustomerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.addNewCustomerLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addNewCustomerLabel.Location = new System.Drawing.Point(12, 254);
            this.addNewCustomerLabel.Name = "addNewCustomerLabel";
            this.addNewCustomerLabel.Size = new System.Drawing.Size(146, 21);
            this.addNewCustomerLabel.TabIndex = 17;
            this.addNewCustomerLabel.Text = "Add New Customer";
            this.addNewCustomerLabel.Click += new System.EventHandler(this.addNewCustomerLabel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(407, 242);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOk.Location = new System.Drawing.Point(282, 242);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(110, 33);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // CustomerCardNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 285);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.addNewCustomerLabel);
            this.Controls.Add(this.errorCardNumberLabel);
            this.Controls.Add(this.textCardNumber);
            this.Controls.Add(this.label2);
            this.Name = "CustomerCardNumberForm";
            this.Text = "CustomerCardNumberForm";
            this.Load += new System.EventHandler(this.CustomerCardNumberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textCardNumber;
        private Label label2;
        private Label errorCardNumberLabel;
        private Label addNewCustomerLabel;
        private Button btnCancel;
        private Button btnOk;
    }
}