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
using CarServiceCenterLibrary;
using Services;

namespace Session_11
{
    public partial class TransactionForm : DevExpress.XtraEditors.XtraForm
    {
        OpenForm openF = new OpenForm();
        ServiceCenter serviceCenter;
        public readonly StorageService storageService = new StorageService();
        public Transaction transaction;
        public TransactionForm()
        {
            InitializeComponent();
        }


        private void TransactionForm_Load(object sender, EventArgs e)
        {
            LoadData();
            bsTransactions.DataSource = serviceCenter.Transactions;
            PopulateControls();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            NewData();
            SaveData();
        
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }
        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            SaveData();
            this.Close();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            EditData();
        }

        private void NewData()
        {
            var serviceCenter = bsServiceCenter.Current as ServiceCenter;
            var transaction =new Transaction();
            var editForm = new NewTransaction(serviceCenter, transaction, State.New);

            editForm.ShowDialog();
            grvTransactions.RefreshData();
        }
        private void PopulateControls()
        {          
            openF.PopulateCustomer(repCustomer);
            openF.PopulateCar(repCar);
            openF.PopulateManager(repManager);
            bsServiceCenter.DataSource = serviceCenter;
            bsTransactions.DataSource = bsServiceCenter;
            bsTransactions.DataMember = "Transactions";
            grdTransactions.DataSource = bsTransactions;
            grvTransactions.RefreshData();

        }
        private void EditData()
        {
            var serviceCenter = bsServiceCenter.Current as ServiceCenter;
            var transaction = bsTransactions.Current as Transaction;
            NewTransaction editForm = new NewTransaction(serviceCenter, transaction, State.Edit);
            editForm.ShowDialog();
            grvTransactions.RefreshData();
        }

        private void DeleteData()
        {
            var res = MessageBox.Show(this, "Are you sure you want to delete the selected Transaction?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;
            var transaction = bsTransactions.Current as Transaction;
            bsTransactions.Remove(transaction);

            SaveData();
        }
        private void LoadData()
        {
            serviceCenter = storageService.GetSeviceCenter();
        }
        private void SaveData()
        {
            storageService.SaveServiceCenter(serviceCenter);
        }

    }
}