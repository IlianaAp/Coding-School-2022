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
    public partial class ItemEditForm : Form
    {
        private ItemViewModel _item;
        private bool _isNew;
        ItemsForm _itemsForm;
        public ItemEditForm(ItemViewModel item, bool isNew, ItemsForm itemsForm)
        {
            _item = item;
            _isNew = isNew;
            _itemsForm = itemsForm;
            InitializeComponent();
        }

        private void ItemEditForm_Load(object sender, EventArgs e)
        {
            numericUpDownCost.Minimum = 0;
            numericUpDownPrice.Minimum = 0;
            numericUpDownCost.Maximum = 1000000;
            numericUpDownPrice.Maximum = 1000000;
            comboBoxItemType.DataSource = Enum.GetValues(typeof(ItemType));
            textCode.DataBindings.Add(new Binding("Text", _item, nameof(ItemViewModel.Code), true));
            textDescription.DataBindings.Add(new Binding("Text", _item, nameof(ItemViewModel.Description), true));
            numericUpDownCost.DataBindings.Add(new Binding("Value", _item, nameof(ItemViewModel.Cost), true));
            numericUpDownPrice.DataBindings.Add(new Binding("Value", _item, nameof(ItemViewModel.Price), true));
            comboBoxItemType.DataBindings.Add(new Binding("SelectedValue", _item, nameof(ItemViewModel.ItemType), true));
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            errorCodeLabel.Text = string.Empty;
            errorItemTypeLabel.Text = string.Empty;
            errorDescriptionLabel.Text =string.Empty;
            HttpResponseMessage res;
            if (HasValidData())
            {
                if (_isNew)
                {
                    var httpClient = new HttpClient();
                    res = await httpClient.PostAsJsonAsync("https://localhost:7056/Item", _item);

                }
                else
                {
                    var httpClient = new HttpClient();
                    res = await httpClient.PutAsJsonAsync("https://localhost:7056/Item", _item);

                }

                if (res.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    errorCodeLabel.Text = await res.Content.ReadAsStringAsync();
                }
                else
                {
                    this.Close();
                }
            }

        }
        private bool HasValidData()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(textCode.Text))
            {
                errorCodeLabel.Text = "The Code is required";
                isValid = false;
            }
            if (textCode.Text.Length > 30)
            {
                errorCodeLabel.Text = "The Code must be maximum 30 characters";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(textDescription.Text))
            {
                errorDescriptionLabel.Text = "The Description is required";
                isValid = false;
            }
            if (textDescription.Text.Length > 30)
            {
                errorDescriptionLabel.Text = "The Description must be maximum 30 characters";
                isValid = false;
            }
            if (comboBoxItemType.SelectedItem == null)
            {
                errorItemTypeLabel.Text = "The Item Type is required";
                isValid = false;
            }
            return isValid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void ItemEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            await _itemsForm.LoadData();
        }
    }
}
