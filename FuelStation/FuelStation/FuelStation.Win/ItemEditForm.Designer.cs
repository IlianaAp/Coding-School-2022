namespace FuelStation.Win
{
    partial class ItemEditForm
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
            this.textCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxItemType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownCost = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorCodeLabel = new System.Windows.Forms.Label();
            this.errorDescriptionLabel = new System.Windows.Forms.Label();
            this.errorItemTypeLabel = new System.Windows.Forms.Label();
            this.errorCostLabel = new System.Windows.Forms.Label();
            this.errorPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).BeginInit();
            this.SuspendLayout();
            // 
            // textCode
            // 
            this.textCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCode.Location = new System.Drawing.Point(100, 42);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(167, 29);
            this.textCode.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code";
            // 
            // textDescription
            // 
            this.textDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDescription.Location = new System.Drawing.Point(396, 42);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(263, 29);
            this.textDescription.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(301, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // comboBoxItemType
            // 
            this.comboBoxItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItemType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxItemType.FormattingEnabled = true;
            this.comboBoxItemType.Location = new System.Drawing.Point(100, 133);
            this.comboBoxItemType.Name = "comboBoxItemType";
            this.comboBoxItemType.Size = new System.Drawing.Size(167, 29);
            this.comboBoxItemType.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Item Type";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownPrice.Location = new System.Drawing.Point(353, 134);
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownPrice.TabIndex = 8;
            this.numericUpDownPrice.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(492, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(301, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // numericUpDownCost
            // 
            this.numericUpDownCost.DecimalPlaces = 2;
            this.numericUpDownCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownCost.Location = new System.Drawing.Point(539, 134);
            this.numericUpDownCost.Name = "numericUpDownCost";
            this.numericUpDownCost.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownCost.TabIndex = 11;
            this.numericUpDownCost.Tag = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(549, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(423, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 33);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorCodeLabel
            // 
            this.errorCodeLabel.AutoSize = true;
            this.errorCodeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorCodeLabel.ForeColor = System.Drawing.Color.Red;
            this.errorCodeLabel.Location = new System.Drawing.Point(100, 74);
            this.errorCodeLabel.Name = "errorCodeLabel";
            this.errorCodeLabel.Size = new System.Drawing.Size(0, 17);
            this.errorCodeLabel.TabIndex = 14;
            // 
            // errorDescriptionLabel
            // 
            this.errorDescriptionLabel.AutoSize = true;
            this.errorDescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorDescriptionLabel.ForeColor = System.Drawing.Color.Red;
            this.errorDescriptionLabel.Location = new System.Drawing.Point(396, 74);
            this.errorDescriptionLabel.Name = "errorDescriptionLabel";
            this.errorDescriptionLabel.Size = new System.Drawing.Size(0, 17);
            this.errorDescriptionLabel.TabIndex = 15;
            // 
            // errorItemTypeLabel
            // 
            this.errorItemTypeLabel.AutoSize = true;
            this.errorItemTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorItemTypeLabel.ForeColor = System.Drawing.Color.Red;
            this.errorItemTypeLabel.Location = new System.Drawing.Point(100, 165);
            this.errorItemTypeLabel.Name = "errorItemTypeLabel";
            this.errorItemTypeLabel.Size = new System.Drawing.Size(0, 17);
            this.errorItemTypeLabel.TabIndex = 16;
            // 
            // errorCostLabel
            // 
            this.errorCostLabel.AutoSize = true;
            this.errorCostLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorCostLabel.ForeColor = System.Drawing.Color.Red;
            this.errorCostLabel.Location = new System.Drawing.Point(492, 165);
            this.errorCostLabel.Name = "errorCostLabel";
            this.errorCostLabel.Size = new System.Drawing.Size(0, 17);
            this.errorCostLabel.TabIndex = 17;
            // 
            // errorPriceLabel
            // 
            this.errorPriceLabel.AutoSize = true;
            this.errorPriceLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorPriceLabel.ForeColor = System.Drawing.Color.Red;
            this.errorPriceLabel.Location = new System.Drawing.Point(301, 165);
            this.errorPriceLabel.Name = "errorPriceLabel";
            this.errorPriceLabel.Size = new System.Drawing.Size(0, 17);
            this.errorPriceLabel.TabIndex = 18;
            // 
            // ItemEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 322);
            this.Controls.Add(this.errorPriceLabel);
            this.Controls.Add(this.errorCostLabel);
            this.Controls.Add(this.errorItemTypeLabel);
            this.Controls.Add(this.errorDescriptionLabel);
            this.Controls.Add(this.errorCodeLabel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numericUpDownCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxItemType);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCode);
            this.Controls.Add(this.label1);
            this.Name = "ItemEditForm";
            this.Text = "ItemEditForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ItemEditForm_FormClosed);
            this.Load += new System.EventHandler(this.ItemEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textCode;
        private Label label1;
        private TextBox textDescription;
        private Label label2;
        private ComboBox comboBoxItemType;
        private Label label3;
        private NumericUpDown numericUpDownPrice;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDownCost;
        private Button btnCancel;
        private Button btnSave;
        private Label errorCodeLabel;
        private Label errorDescriptionLabel;
        private Label errorItemTypeLabel;
        private Label errorCostLabel;
        private Label errorPriceLabel;
    }
}