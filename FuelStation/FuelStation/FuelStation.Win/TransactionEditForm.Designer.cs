namespace FuelStation.Win
{
    partial class TransactionEditForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorPaymentMethodLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorEmployeeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.grdTransactionLines = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNewTransactionLine = new System.Windows.Forms.Button();
            this.btnDeleteTransactionLine = new System.Windows.Forms.Button();
            this.errorTransactionLineLabel = new System.Windows.Forms.Label();
            this.textCardNumber = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.numericUpDownTotalValue = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bsTransactionLines = new System.Windows.Forms.BindingSource(this.components);
            this.btnEditTransactionLine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLines)).BeginInit();
            this.SuspendLayout();
            // 
            // errorPaymentMethodLabel
            // 
            this.errorPaymentMethodLabel.AutoSize = true;
            this.errorPaymentMethodLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorPaymentMethodLabel.ForeColor = System.Drawing.Color.Red;
            this.errorPaymentMethodLabel.Location = new System.Drawing.Point(631, 133);
            this.errorPaymentMethodLabel.Name = "errorPaymentMethodLabel";
            this.errorPaymentMethodLabel.Size = new System.Drawing.Size(0, 17);
            this.errorPaymentMethodLabel.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Card Number :";
            // 
            // errorEmployeeLabel
            // 
            this.errorEmployeeLabel.AutoSize = true;
            this.errorEmployeeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorEmployeeLabel.ForeColor = System.Drawing.Color.Red;
            this.errorEmployeeLabel.Location = new System.Drawing.Point(119, 130);
            this.errorEmployeeLabel.Name = "errorEmployeeLabel";
            this.errorEmployeeLabel.Size = new System.Drawing.Size(0, 17);
            this.errorEmployeeLabel.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Employee :";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(119, 98);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(167, 29);
            this.comboBoxEmployee.TabIndex = 18;
            // 
            // grdTransactionLines
            // 
            this.grdTransactionLines.AllowUserToAddRows = false;
            this.grdTransactionLines.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTransactionLines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdTransactionLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTransactionLines.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdTransactionLines.Location = new System.Drawing.Point(12, 220);
            this.grdTransactionLines.MultiSelect = false;
            this.grdTransactionLines.Name = "grdTransactionLines";
            this.grdTransactionLines.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTransactionLines.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdTransactionLines.RowTemplate.Height = 25;
            this.grdTransactionLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTransactionLines.Size = new System.Drawing.Size(595, 259);
            this.grdTransactionLines.TabIndex = 24;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(760, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(634, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 33);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Transaction Lines";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(304, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Surname :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(571, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 21);
            this.label9.TabIndex = 31;
            this.label9.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(492, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Payment Method :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(711, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Total Value :";
            // 
            // btnNewTransactionLine
            // 
            this.btnNewTransactionLine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewTransactionLine.Location = new System.Drawing.Point(315, 185);
            this.btnNewTransactionLine.Name = "btnNewTransactionLine";
            this.btnNewTransactionLine.Size = new System.Drawing.Size(96, 33);
            this.btnNewTransactionLine.TabIndex = 39;
            this.btnNewTransactionLine.Text = "Add";
            this.btnNewTransactionLine.UseVisualStyleBackColor = true;
            this.btnNewTransactionLine.Click += new System.EventHandler(this.btnNewTransactionLine_Click);
            // 
            // btnDeleteTransactionLine
            // 
            this.btnDeleteTransactionLine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteTransactionLine.Location = new System.Drawing.Point(516, 185);
            this.btnDeleteTransactionLine.Name = "btnDeleteTransactionLine";
            this.btnDeleteTransactionLine.Size = new System.Drawing.Size(91, 33);
            this.btnDeleteTransactionLine.TabIndex = 40;
            this.btnDeleteTransactionLine.Text = "Delete";
            this.btnDeleteTransactionLine.UseVisualStyleBackColor = true;
            this.btnDeleteTransactionLine.Click += new System.EventHandler(this.btnDeleteTransactionLine_Click);
            // 
            // errorTransactionLineLabel
            // 
            this.errorTransactionLineLabel.AutoSize = true;
            this.errorTransactionLineLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorTransactionLineLabel.ForeColor = System.Drawing.Color.Red;
            this.errorTransactionLineLabel.Location = new System.Drawing.Point(634, 426);
            this.errorTransactionLineLabel.Name = "errorTransactionLineLabel";
            this.errorTransactionLineLabel.Size = new System.Drawing.Size(0, 17);
            this.errorTransactionLineLabel.TabIndex = 45;
            // 
            // textCardNumber
            // 
            this.textCardNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCardNumber.Location = new System.Drawing.Point(119, 27);
            this.textCardNumber.Name = "textCardNumber";
            this.textCardNumber.ReadOnly = true;
            this.textCardNumber.Size = new System.Drawing.Size(167, 29);
            this.textCardNumber.TabIndex = 46;
            // 
            // textSurname
            // 
            this.textSurname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textSurname.Location = new System.Drawing.Point(389, 27);
            this.textSurname.Name = "textSurname";
            this.textSurname.ReadOnly = true;
            this.textSurname.Size = new System.Drawing.Size(167, 29);
            this.textSurname.TabIndex = 47;
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textName.Location = new System.Drawing.Point(634, 27);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(167, 29);
            this.textName.TabIndex = 48;
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(634, 101);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(167, 29);
            this.comboBoxPaymentMethod.TabIndex = 49;
            // 
            // numericUpDownTotalValue
            // 
            this.numericUpDownTotalValue.DecimalPlaces = 2;
            this.numericUpDownTotalValue.Enabled = false;
            this.numericUpDownTotalValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownTotalValue.InterceptArrowKeys = false;
            this.numericUpDownTotalValue.Location = new System.Drawing.Point(808, 364);
            this.numericUpDownTotalValue.Name = "numericUpDownTotalValue";
            this.numericUpDownTotalValue.ReadOnly = true;
            this.numericUpDownTotalValue.Size = new System.Drawing.Size(62, 29);
            this.numericUpDownTotalValue.TabIndex = 50;
            this.numericUpDownTotalValue.TabStop = false;
            this.numericUpDownTotalValue.Tag = "";
            this.numericUpDownTotalValue.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(634, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 52;
            this.label6.Text = "Date :";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(634, 246);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(234, 23);
            this.dateTimePicker.TabIndex = 53;
            // 
            // btnEditTransactionLine
            // 
            this.btnEditTransactionLine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditTransactionLine.Location = new System.Drawing.Point(417, 185);
            this.btnEditTransactionLine.Name = "btnEditTransactionLine";
            this.btnEditTransactionLine.Size = new System.Drawing.Size(93, 33);
            this.btnEditTransactionLine.TabIndex = 54;
            this.btnEditTransactionLine.Text = "Edit";
            this.btnEditTransactionLine.UseVisualStyleBackColor = true;
            this.btnEditTransactionLine.Click += new System.EventHandler(this.btnEditTransactionLine_Click);
            // 
            // TransactionEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 491);
            this.Controls.Add(this.btnEditTransactionLine);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownTotalValue);
            this.Controls.Add(this.comboBoxPaymentMethod);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textCardNumber);
            this.Controls.Add(this.errorTransactionLineLabel);
            this.Controls.Add(this.btnDeleteTransactionLine);
            this.Controls.Add(this.btnNewTransactionLine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdTransactionLines);
            this.Controls.Add(this.errorEmployeeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.errorPaymentMethodLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransactionEditForm";
            this.Text = "Transaction Edit";
            this.Load += new System.EventHandler(this.TransactionEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label errorPaymentMethodLabel;
        private Label label1;
        private Label errorEmployeeLabel;
        private Label label3;
        private ComboBox comboBoxEmployee;
        private DataGridView grdTransactionLines;
        private Button btnCancel;
        private Button btnSave;
        private Label label5;
        private Label label7;
        private Label label9;
        private Label label2;
        private Label label4;
        private Button btnNewTransactionLine;
        private Button btnDeleteTransactionLine;
        private Label errorTransactionLineLabel;
        private TextBox textCardNumber;
        private TextBox textSurname;
        private TextBox textName;
        private ComboBox comboBoxPaymentMethod;
        private NumericUpDown numericUpDownTotalValue;
        private Label label6;
        private DateTimePicker dateTimePicker;
        private BindingSource bsTransactionLines;
        private Button btnEditTransactionLine;
    }
}