namespace FuelStation.Win
{
    partial class TransactionLineEdit
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
            this.errorItemLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.errorQuantityLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericItemPrice = new System.Windows.Forms.NumericUpDown();
            this.numericNetValue = new System.Windows.Forms.NumericUpDown();
            this.numericDiscountPercent = new System.Windows.Forms.NumericUpDown();
            this.numericDiscountValue = new System.Windows.Forms.NumericUpDown();
            this.numericTotalValue = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNetValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscountPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscountValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTotalValue)).BeginInit();
            this.SuspendLayout();
            // 
            // errorItemLabel
            // 
            this.errorItemLabel.AutoSize = true;
            this.errorItemLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorItemLabel.ForeColor = System.Drawing.Color.Red;
            this.errorItemLabel.Location = new System.Drawing.Point(94, 69);
            this.errorItemLabel.Name = "errorItemLabel";
            this.errorItemLabel.Size = new System.Drawing.Size(0, 17);
            this.errorItemLabel.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Item :";
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(94, 37);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(167, 29);
            this.comboBoxItem.TabIndex = 17;
            this.comboBoxItem.SelectedValueChanged += new System.EventHandler(this.comboBoxItem_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(326, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Quantity :";
            // 
            // numericQuantity
            // 
            this.numericQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericQuantity.Location = new System.Drawing.Point(416, 42);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(37, 29);
            this.numericQuantity.TabIndex = 20;
            this.numericQuantity.Tag = "";
            this.numericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantity.ValueChanged += new System.EventHandler(this.numericQuantity_ValueChanged);
            // 
            // errorQuantityLabel
            // 
            this.errorQuantityLabel.AutoSize = true;
            this.errorQuantityLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorQuantityLabel.ForeColor = System.Drawing.Color.Red;
            this.errorQuantityLabel.Location = new System.Drawing.Point(285, 69);
            this.errorQuantityLabel.Name = "errorQuantityLabel";
            this.errorQuantityLabel.Size = new System.Drawing.Size(0, 17);
            this.errorQuantityLabel.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Item Price :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(301, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Net Value :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(40, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Discount Percent :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(40, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Discount Value :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(301, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Total Value :";
            // 
            // numericItemPrice
            // 
            this.numericItemPrice.DecimalPlaces = 2;
            this.numericItemPrice.Enabled = false;
            this.numericItemPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericItemPrice.InterceptArrowKeys = false;
            this.numericItemPrice.Location = new System.Drawing.Point(179, 106);
            this.numericItemPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericItemPrice.Name = "numericItemPrice";
            this.numericItemPrice.ReadOnly = true;
            this.numericItemPrice.Size = new System.Drawing.Size(106, 29);
            this.numericItemPrice.TabIndex = 51;
            this.numericItemPrice.TabStop = false;
            this.numericItemPrice.Tag = "";
            // 
            // numericNetValue
            // 
            this.numericNetValue.DecimalPlaces = 2;
            this.numericNetValue.Enabled = false;
            this.numericNetValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericNetValue.InterceptArrowKeys = false;
            this.numericNetValue.Location = new System.Drawing.Point(391, 108);
            this.numericNetValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericNetValue.Name = "numericNetValue";
            this.numericNetValue.ReadOnly = true;
            this.numericNetValue.Size = new System.Drawing.Size(91, 29);
            this.numericNetValue.TabIndex = 52;
            this.numericNetValue.TabStop = false;
            this.numericNetValue.Tag = "";
            // 
            // numericDiscountPercent
            // 
            this.numericDiscountPercent.DecimalPlaces = 2;
            this.numericDiscountPercent.Enabled = false;
            this.numericDiscountPercent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericDiscountPercent.InterceptArrowKeys = false;
            this.numericDiscountPercent.Location = new System.Drawing.Point(179, 150);
            this.numericDiscountPercent.Name = "numericDiscountPercent";
            this.numericDiscountPercent.ReadOnly = true;
            this.numericDiscountPercent.Size = new System.Drawing.Size(106, 29);
            this.numericDiscountPercent.TabIndex = 53;
            this.numericDiscountPercent.TabStop = false;
            this.numericDiscountPercent.Tag = "";
            // 
            // numericDiscountValue
            // 
            this.numericDiscountValue.DecimalPlaces = 2;
            this.numericDiscountValue.Enabled = false;
            this.numericDiscountValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericDiscountValue.InterceptArrowKeys = false;
            this.numericDiscountValue.Location = new System.Drawing.Point(179, 192);
            this.numericDiscountValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericDiscountValue.Name = "numericDiscountValue";
            this.numericDiscountValue.ReadOnly = true;
            this.numericDiscountValue.Size = new System.Drawing.Size(106, 29);
            this.numericDiscountValue.TabIndex = 54;
            this.numericDiscountValue.TabStop = false;
            this.numericDiscountValue.Tag = "";
            // 
            // numericTotalValue
            // 
            this.numericTotalValue.DecimalPlaces = 2;
            this.numericTotalValue.Enabled = false;
            this.numericTotalValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericTotalValue.InterceptArrowKeys = false;
            this.numericTotalValue.Location = new System.Drawing.Point(391, 194);
            this.numericTotalValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericTotalValue.Name = "numericTotalValue";
            this.numericTotalValue.ReadOnly = true;
            this.numericTotalValue.Size = new System.Drawing.Size(91, 29);
            this.numericTotalValue.TabIndex = 55;
            this.numericTotalValue.TabStop = false;
            this.numericTotalValue.Tag = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(343, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(217, 281);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 33);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TransactionLineEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 331);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numericTotalValue);
            this.Controls.Add(this.numericDiscountValue);
            this.Controls.Add(this.numericDiscountPercent);
            this.Controls.Add(this.numericNetValue);
            this.Controls.Add(this.numericItemPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorQuantityLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.errorItemLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxItem);
            this.Name = "TransactionLineEdit";
            this.Text = "TransactionLineEdit";
            this.Load += new System.EventHandler(this.TransactionLineEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNetValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscountPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscountValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTotalValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label errorItemLabel;
        private Label label3;
        private ComboBox comboBoxItem;
        private Label label5;
        private NumericUpDown numericQuantity;
        private Label errorQuantityLabel;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label7;
        private NumericUpDown numericItemPrice;
        private NumericUpDown numericNetValue;
        private NumericUpDown numericDiscountPercent;
        private NumericUpDown numericDiscountValue;
        private NumericUpDown numericTotalValue;
        private Button btnCancel;
        private Button btnSave;
    }
}