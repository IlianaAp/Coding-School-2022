using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using CarServiceCenterLibrary;
using Services;

namespace Session_11
{
    public partial class NewTransactionLine : DevExpress.XtraEditors.XtraForm
    {
        TransactionLine _transactionLine;
        TransactionLine _transactionLineBackup;
        Transaction _transaction;
        ServiceCenter _serviceCenter;
        CalculateTotalPrice _calculateTotalPrice= new CalculateTotalPrice();
        //public NewTransactionLine()
        //{
        //    InitializeComponent();
        //}
        public NewTransactionLine(Transaction transaction,ServiceCenter serviceCenter)
        {
            _serviceCenter = serviceCenter;
            _transaction=transaction;
            InitializeComponent();
        }


        private void NewTransactionLine_Load(object sender, EventArgs e)
        {
            Populate();
            SetDataBindings();
        }
        private void Populate()
        {
            SetCtrlServiceTask();
            SetCtrlEngineer();
            _transactionLine = new TransactionLine();
             bsTransactionLines.DataSource = _transactionLine;
           
        }
        private void SetCtrlServiceTask()
        {
            ctrlHours.Properties.DataSource = _serviceCenter.ServiceTasks;
            ctrlServiceTask.Properties.DataSource = _serviceCenter.ServiceTasks;
            ctrlServiceTask.Properties.Columns.Add(new LookUpColumnInfo("Description", "Description"));
            ctrlServiceTask.Properties.Columns.Add(new LookUpColumnInfo("Code", "Code"));
            ctrlServiceTask.Properties.Columns.Add(new LookUpColumnInfo("Hours", "Hours"));
            ctrlServiceTask.Properties.DisplayMember = "Description";
            ctrlHours.Properties.DisplayMember = "Hours";
            ctrlHours.Properties.ValueMember = "ID";
            ctrlServiceTask.Properties.ValueMember = "ID";
        }
        private void SetCtrlEngineer()
        {
            ctrlEngineer.Properties.DataSource = _serviceCenter.Engineers;
            ctrlEngineer.Properties.Columns.Add(new LookUpColumnInfo("Name", "Name"));
            ctrlEngineer.Properties.Columns.Add(new LookUpColumnInfo("Surname", "Surname"));
            ctrlEngineer.Properties.DisplayMember = "Surname";
            ctrlEngineer.Properties.ValueMember = "ID";
        }
        private void SetDataBindings()
        {
            ctrlServiceTask.DataBindings.Add(new Binding("EditValue", bsTransactionLines, "ServiceTaskID", true));
            ctrlEngineer.DataBindings.Add(new Binding("EditValue", bsTransactionLines, "EngineerID", true));
            ctrlHours.DataBindings.Add(new Binding("EditValue", bsTransactionLines, "ServiceTaskID", true));
            txtPricePerHour.DataBindings.Add(new Binding("EditValue", bsTransactionLines, "PRICE_PER_HOUR", true)); 
        }
        

        private void txtHours_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }
        private void Save()
        {
            ServiceTask serviceTask = ctrlServiceTask.GetSelectedDataRow() as ServiceTask;
            _transactionLine.Hours = serviceTask.Hours;
            _calculateTotalPrice.SetPrice(_transactionLine);
            _transaction.TransactionLines.Add(_transactionLine);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}