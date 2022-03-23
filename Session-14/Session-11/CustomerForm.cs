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
using System.Text.Json;
using System.IO;
using Services;

namespace Session_11
{
    public partial class CustomerForm : DevExpress.XtraEditors.XtraForm
    {
        OpenForm openF = new OpenForm();
        ServiceCenter serviceCenter;
        public readonly StorageService storageService = new StorageService();
 
        public CustomerForm()
        {
            InitializeComponent();
            
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            serviceCenter = storageService.GetSeviceCenter();
            bsCustomers.DataSource = serviceCenter.Customers;
        }
        #region UI Controls
        private void btnNew_Click(object sender, EventArgs e)
        {
            NewData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            serviceCenter.Customers = bsCustomers.DataSource as List<Customer>;
            storageService.SaveServiceCenter(serviceCenter);
            this.Close();
        }
        #endregion
        private void EditData()
        {
            var customer = GetSelectedCustomer();
            if (customer != null)
            {
                var editForm = openF.GetForm<CustomerF>(State.Edit, customer, bsCustomers);
                editForm.ShowDialog();
                grvCustomers.RefreshData();

            }
        }
        private void DeleteData()
        {
            var result = MessageBox.Show("Are you sure that you want to delete this Customer?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var selectedCustomer = GetSelectedCustomer();
                ((List<Customer>)bsCustomers.DataSource).Remove(selectedCustomer);
                grvCustomers.RefreshData();
            }
        }
        private void NewData()
        {
            var customer = new Customer();
            var editForm = openF.GetForm<CustomerF>(State.New, customer, bsCustomers);
            serviceCenter.Customers = bsCustomers.DataSource as List<Customer>;
            storageService.SaveServiceCenter(serviceCenter);
            editForm.ShowDialog();

            grvCustomers.RefreshData();
        }
        private Customer? GetSelectedCustomer()
        {

            var selectedIndexes = grvCustomers.GetSelectedRows();
            if (selectedIndexes is not null)
            {
                return grvCustomers.GetRow(selectedIndexes[0]) as Customer;
            }
            else
            {
                return null;
            }
        }
    }


}