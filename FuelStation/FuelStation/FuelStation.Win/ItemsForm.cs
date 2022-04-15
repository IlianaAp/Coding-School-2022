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
    
    public partial class ItemsForm : Form
    {
        List<ItemViewModel> items;
        public ItemsForm()
        {
            InitializeComponent();
        }

        private async void ItemsForm_Load(object sender, EventArgs e)
        {
            await LoadData();
            grdItems.Columns[0].Visible = false;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var item = new ItemViewModel();
            var form = new ItemEditForm(item, true, this);
            form.ShowDialog();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedItem = GetSelectedItem();
            if (selectedItem != null)
            {
                var item = selectedItem;
                var form = new ItemEditForm(item, false, this);
                form.ShowDialog();
            }

        }

        public async Task LoadData()
        {
            var httpClient = new HttpClient();
            items = await httpClient.GetFromJsonAsync<List<ItemViewModel>>("https://localhost:7056/Item");
            grdItems.DataSource = items;
        }
        private ItemViewModel? GetSelectedItem()
        {
            if (grdItems.SelectedRows.Count > 0)
            {
                return grdItems.SelectedRows[0].DataBoundItem as ItemViewModel;
            }
            return null;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedItem = GetSelectedItem();
            if(selectedItem != null)
            {
                var result = MessageBox.Show($"Are you sure that you want to delete this Item : {selectedItem.Code} {selectedItem.Description} ?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var httpClient = new HttpClient();
                    await httpClient.DeleteAsync($"https://localhost:7056/Item/{selectedItem.ID}");
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
