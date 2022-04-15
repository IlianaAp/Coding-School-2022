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
    public partial class CustomersForm : Form
    {
        List<CustomerViewModel> customers;
        public CustomersForm()
        {
            InitializeComponent();
            
        }

        private async void CustomersForm_Load(object sender, EventArgs e)
        {
            await LoadData();

            dataGridView1.Columns[0].Visible = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var customer = new CustomerViewModel();
            var form = new CustomerEditForm(customer, true, this);
            form.ShowDialog();

        }
        public async Task LoadData()
        {
            var httpClient = new HttpClient();
            customers = await httpClient.GetFromJsonAsync<List<CustomerViewModel>>("https://localhost:7056/Customer");
            dataGridView1.DataSource = customers;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedCustomer = GetSelectedCustomer();
            if(selectedCustomer != null)
            {
                var customer = selectedCustomer;
                var form = new CustomerEditForm(customer, false, this);
                form.ShowDialog();
            }
        }
        private CustomerViewModel? GetSelectedCustomer()
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                return dataGridView1.SelectedRows[0].DataBoundItem as CustomerViewModel;
            }
            return null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedCustomer = GetSelectedCustomer();
            if( selectedCustomer != null)
            {
                var result = MessageBox.Show($"Are you sure that you want to delete this Customer : {selectedCustomer.Surname} {selectedCustomer.Name} ?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    var httpClient = new HttpClient();
                    await httpClient.DeleteAsync($"https://localhost:7056/Customer/{selectedCustomer.ID}");
                    await LoadData();
                }
            }
        }
    }
}
