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
    public partial class TransactionsForm : Form
    {
        List<TransactionViewModel> transactions;
        public TransactionsForm()
        {
            InitializeComponent();
        }
        private async void TransactionsForm_Load(object sender, EventArgs e)
        {
            await LoadData();
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var form = new CustomerCardNumberForm(this);
            form.ShowDialog();
            
        }
        public async Task LoadData()
        {
            bsTransactions.DataSource = null;
            var httpClient = new HttpClient();
            transactions = await httpClient.GetFromJsonAsync<List<TransactionViewModel>>("https://localhost:7056/Transaction");
            bsTransactions.DataSource = transactions;
            grdTransactions.DataSource = bsTransactions;
            grdTransactions.Columns[0].Visible = false;
            grdTransactions.Columns[1].Visible = false;
            grdTransactions.Columns[2].Visible = false;
            grdTransactions.Columns[4].Visible = false;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedTransaction = GetSelectedTransaction();
            if(selectedTransaction != null)
            {
                var form = new TransactionEditForm(selectedTransaction, this);
                form.ShowDialog();
            }
        }
        private TransactionViewModel? GetSelectedTransaction()
        {
            if(grdTransactions.SelectedRows.Count > 0)
            {
                return grdTransactions.SelectedRows[0].DataBoundItem as TransactionViewModel;
            }
            return null;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedTransaction = GetSelectedTransaction();
            if (selectedTransaction != null)
            {
                var result = MessageBox.Show($"Are you sure that you want to delete this Transaction ?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var httpClient = new HttpClient();
                    await httpClient.DeleteAsync($"https://localhost:7056/Transaction/{selectedTransaction.ID}");
                    await LoadData();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
