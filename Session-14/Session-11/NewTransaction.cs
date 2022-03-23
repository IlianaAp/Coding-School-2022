using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarServiceCenterLibrary;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Services;

namespace Session_11
{
    public partial class NewTransaction : DevExpress.XtraEditors.XtraForm
    {
        State _state;
        Transaction _transaction = new Transaction();
        Transaction _transactionBackup;
        ServiceCenter _serviceCenter;
        OpenForm openF = new OpenForm();
        bool pressedNew = false;
        CalculateTotalPrice calc = new CalculateTotalPrice();


        public readonly StorageService storageService = new StorageService();
        public NewTransaction()
        {
            InitializeComponent();
        }
        public NewTransaction(ServiceCenter serviceCenter)
        { 
            _serviceCenter = serviceCenter;
            InitializeComponent();
        }
        public NewTransaction(ServiceCenter serviceCenter, Transaction transaction, State state)
        {
            _state = state;
            _transaction = transaction;
            _serviceCenter = serviceCenter;
            InitializeComponent();
        }


        private void NewTransanction_Load(object sender, EventArgs e)
        {
            if (_state == State.New)
            {
                pressedNew = true;
                _transactionBackup = new Transaction();          
            }
            else
            {
                _transactionBackup = new Transaction
                {
                    Date = _transaction.Date,
                    ID = _transaction.ID,
                    CustomerID = _transaction.CustomerID,
                    CarID = _transaction.CarID,
                    ManagerID = _transaction.ManagerID,
                    TotalPrice = _transaction.TotalPrice,
                    TransactionLines = _transaction.TransactionLines
                };
            }
            bsTransactions.DataSource = _transactionBackup;

            Populate();
            //bsTransactions.DataSource = _serviceCenter.Transactions;
            bsTransactionsLines.DataSource = bsTransactions;
            bsTransactionsLines.DataMember = "TransactionLines";
            grdTransactionsLines.DataSource = bsTransactionsLines;
            SetRepServiceTask();
            SetRepEngineer();
            SetDataBindings();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //_transaction = 
            //((List<Transaction>)bsTransactions.DataSource).Add(_transactionBackup);

            calc.SetTotalPrice(_transactionBackup);
            if(pressedNew)
                _serviceCenter.Transactions.Add(_transactionBackup); 
            else
            {
                var selectedItem = _serviceCenter.Transactions.FindIndex(x => x.ID == _transactionBackup.ID);
                _serviceCenter.Transactions[selectedItem] = _transactionBackup;
            }

            DialogResult = DialogResult.OK;
        }

        private void Populate()
        {
            SetCtrlManager();
            SetCtrlCustomer();
            SetCtrlCar();
        }
        private void SetCtrlManager()
        {
            ctrlManager.Properties.DataSource = _serviceCenter.Managers;
            ctrlManager.Properties.Columns.Add(new LookUpColumnInfo("Name", "Name"));
            ctrlManager.Properties.Columns.Add(new LookUpColumnInfo("Surname", "Surname"));
            ctrlManager.Properties.DisplayMember = "Surname";
            ctrlManager.Properties.ValueMember = "ID";
        }
        private void SetCtrlCustomer()
        {
            ctrlCustomer.Properties.DataSource = _serviceCenter.Customers;
            ctrlCustomer.Properties.Columns.Add(new LookUpColumnInfo("Name", "Name"));
            ctrlCustomer.Properties.Columns.Add(new LookUpColumnInfo("Surname", "Surname"));
            ctrlCustomer.Properties.DisplayMember = "Surname";
            ctrlCustomer.Properties.ValueMember = "ID";
        }
        private void SetCtrlCar()
        {
            ctrlCar.Properties.DataSource = _serviceCenter.Cars;
            ctrlCar.Properties.Columns.Add(new LookUpColumnInfo("Brand", "Brand"));
            ctrlCar.Properties.Columns.Add(new LookUpColumnInfo("Model", "Model"));
            ctrlCar.Properties.DisplayMember = "Brand";
            ctrlCar.Properties.ValueMember = "ID";
        }
        

        private void SetDataBindings()
        {
            ctrlCustomer.DataBindings.Add(new Binding("EditValue", bsTransactions, "CustomerID", true));
            ctrlCar.DataBindings.Add(new Binding("EditValue", bsTransactions, "CarID", true));
            ctrlManager.DataBindings.Add(new Binding("EditValue", bsTransactions, "ManagerID", true));
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            //if (pressedNew)
            //{
            //    _serviceCenter.Transactions.Remove(_transaction);
            //    this.DialogResult = DialogResult.Cancel;
            //}
            //else
            //{
            //    int index = _serviceCenter.Transactions.IndexOf(_transaction);

            //    _serviceCenter.Transactions.RemoveAt(index);
            //    _serviceCenter.Transactions.Insert(index, _transactionBackup);

            //    this.DialogResult = DialogResult.Cancel;
            //}
        }
        private void SetRepServiceTask()
        {
            
            var serviceTask = _serviceCenter.ServiceTasks;
            repServiceTask.DataSource = serviceTask;
            repServiceTask.Columns.Add(new LookUpColumnInfo("Description", "Description"));
            repServiceTask.Columns.Add(new LookUpColumnInfo("Code", "Code"));
            repServiceTask.DisplayMember = "Description";
            repServiceTask.ValueMember = "ID";
        }
        private void SetRepEngineer()
        {
            var engineer = _serviceCenter.Engineers;
            repEngineer.DataSource = engineer;
            repEngineer.Columns.Add(new LookUpColumnInfo("Name", "Name"));
            repEngineer.Columns.Add(new LookUpColumnInfo("Surname", "Surname"));
            repEngineer.DisplayMember = "Surname";
            repEngineer.ValueMember = "ID";
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            var editForm = openF.GetForm<NewTransactionLine>(_transactionBackup, _serviceCenter);
            editForm.ShowDialog();
            grvTransactionLines.RefreshData();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            TransactionLine transactionLine = bsTransactionsLines.Current as TransactionLine;
            bsTransactionsLines.Remove(transactionLine);
            grvTransactionLines.RefreshData();
        }
    }
}