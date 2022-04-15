using FuelStation.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win
{
    public partial class CustomerCardNumberForm : Form
    {
        public CustomerViewModel customer = new();
        public TransactionsForm _transactionsForm;
        public CustomerCardNumberForm(TransactionsForm transactionsForm)
        {
            _transactionsForm = transactionsForm;
            InitializeComponent();
        }

        private void CustomerCardNumberForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            errorCardNumberLabel.Text = string.Empty;
            
            if (HasValidData())
            {
                var httpClient = new HttpClient();
                var foundCustomer = await httpClient.GetFromJsonAsync<CustomerViewModel>($"https://localhost:7056/CardNumber/{textCardNumber.Text}");
                if (foundCustomer == null)
                {
                    errorCardNumberLabel.Text = "There is no Customer with this Card Number";
                    return;
                }
                customer = foundCustomer;
                var transaction = new TransactionViewModel
                {
                    Customer = foundCustomer,
                    CustomerID = foundCustomer.ID
                };
                var form = new TransactionEditForm(transaction, _transactionsForm);   
                this.Close();
                _transactionsForm.Close();
                form.ShowDialog();
            }
           
        }
        private void addNewCustomerLabel_Click(object sender, EventArgs e)
        {
            var form = new CustomersForm();
            form.ShowDialog();
        }

        private bool HasValidData()
        {
            
            if (string.IsNullOrWhiteSpace(textCardNumber.Text))
            {                
                errorCardNumberLabel.Text = "Card Number is required";
                return false;
            }
            if (!textCardNumber.Text.StartsWith('A'))
            {
                errorCardNumberLabel.Text = "Card Number must begin with 'A'";
                return false;
            }
            return true;
        }

    }
}
