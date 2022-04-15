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
    public partial class CustomerEditForm : Form
    {
        private CustomerViewModel _customer;
        private bool _isNew;
        CustomersForm _customersForm;
        public CustomerEditForm(CustomerViewModel customer, bool isNew, CustomersForm customersForm)
        {
            _isNew = isNew;
            _customer = customer;
            _customersForm = customersForm;
            InitializeComponent();
        }

        private void CustomerEditForm_Load(object sender, EventArgs e)
        {
            textName.DataBindings.Add(new Binding("Text", _customer, nameof(CustomerViewModel.Name), true));
            textSurname.DataBindings.Add(new Binding("Text", _customer, nameof(CustomerViewModel.Surname), true));
            textCardNumber.DataBindings.Add(new Binding("Text", _customer, nameof(CustomerViewModel.CardNumber), true));
            
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            errorCardNumberLabel.Text = string.Empty;
            errorNameLabel.Text = string.Empty;
            errorSurnameLabel.Text = string.Empty;
            HttpResponseMessage res;
            if (HasValidData())
            {
                if (_isNew)
                {
                    var httpClient = new HttpClient();
                    res = await httpClient.PostAsJsonAsync("https://localhost:7056/Customer", _customer);
                   
                }
                else
                {
                    var httpClient = new HttpClient();
                    res = await httpClient.PutAsJsonAsync("https://localhost:7056/Customer", _customer);

                }

                if (res.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    errorCardNumberLabel.Text = await res.Content.ReadAsStringAsync();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private async void CustomerEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            await _customersForm.LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool HasValidData()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                errorNameLabel.Text = "The Name is required";
                isValid = false;
            }
            else if (textName.Text.Length > 30)
            {
                errorNameLabel.Text = "The Name must be maximum 30 characters";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(textSurname.Text))
            {
                errorSurnameLabel.Text = "The Surname is required";
                isValid = false;
            }
            else if(textSurname.Text.Length > 30)
            {
                errorSurnameLabel.Text = "The Surname must be maximum 30 characters";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(textCardNumber.Text))
            {
                errorCardNumberLabel.Text = "The Card Number is required";
                isValid = false;
            }
            else if(!textCardNumber.Text.StartsWith('A'))
            {
                errorCardNumberLabel.Text = "Card Number must begin with the letter 'A'";
                isValid = false;
            }
            return isValid;
            
        }
    }
}
