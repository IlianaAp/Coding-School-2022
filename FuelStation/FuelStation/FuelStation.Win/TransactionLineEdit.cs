using FuelStation.Shared;
using FuelStation.Win.Calculations;
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
    public partial class TransactionLineEdit : Form
    {
        private TransactionViewModel _transactionView;
        private TransactionLineViewModel _transactionLineView;
        private TransactionLineViewModel _transactionLineViewEdit;
        private bool _isNew;
        private TransactionEditForm _transactionEditForm;
        private List<ItemViewModel> _items;
        private ItemViewModel selectedItem;
        public TransactionLineEdit(TransactionViewModel transactionView, bool isNew, TransactionLineViewModel transactionLineView, TransactionEditForm transactionEditForm)
        {    
            _transactionEditForm = transactionEditForm;
            _transactionView = transactionView;
            _isNew = isNew;
            _transactionLineView = transactionLineView;
            _transactionLineView.TransactionID = _isNew ? _transactionView.ID : transactionLineView.TransactionID;
            _transactionLineViewEdit = new TransactionLineViewModel
            {
                DiscountPercent = transactionLineView.DiscountPercent,
                ItemID = transactionLineView.ItemID,
                DiscountValue = transactionLineView.DiscountValue,
                ID = transactionLineView.ID,
                ItemDescription = transactionLineView.ItemDescription,
                ItemPrice = transactionLineView.ItemPrice,
                NetValue = transactionLineView.NetValue,
                Quantity = transactionLineView.Quantity,
                TotalValue = transactionLineView.TotalValue,
                TransactionID = transactionLineView.TransactionID
            };
            InitializeComponent();
        }

        private async void TransactionLineEdit_Load(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var items = await httpClient.GetFromJsonAsync<List<ItemViewModel>>("https://localhost:7056/Item");
            _items = items;
            comboBoxItem.DisplayMember = "Text";
            comboBoxItem.ValueMember = "Value";
            List<object> itemList = new();
            foreach (var item in _items)
            {
                itemList.Add(new { Text = item.Description, Value = item.ID});
            }
            comboBoxItem.DataSource = itemList;
            comboBoxItem.DataBindings.Add(new Binding("SelectedValue", _transactionLineViewEdit, nameof(TransactionLineViewModel.ItemID), true));
            numericQuantity.DataBindings.Add(new Binding("Value", _transactionLineViewEdit, nameof(TransactionLineViewModel.Quantity), true));
            if(_transactionLineView.ItemID == Guid.Empty)
            {
                numericQuantity.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            errorItemLabel.Text = string.Empty;
            errorQuantityLabel.Text = string.Empty;
            if (HasValidData())
            {
                _transactionLineView = _transactionLineViewEdit;
                _transactionLineView.ItemDescription = comboBoxItem.Text;
                if (_isNew)
                {
                    
                    _transactionView.TransactionLineViewModels.Add(_transactionLineView);
                }
                else
                {
                    var trLine = _transactionView.TransactionLineViewModels.FirstOrDefault(x => x.ID == _transactionLineView.ID);
                    trLine.DiscountValue = _transactionLineView.DiscountValue;
                    trLine.ItemDescription = _transactionLineView.ItemDescription;
                    trLine.ItemID = _transactionLineView.ItemID;
                    trLine.DiscountPercent = _transactionLineView.DiscountPercent;
                    trLine.Quantity = _transactionLineView.Quantity;
                    trLine.NetValue = _transactionLineView.NetValue;
                    trLine.TotalValue = _transactionLineView.TotalValue;
                    trLine.ID = _transactionLineView.ID;
                    trLine.ItemPrice = _transactionLineView.ItemPrice;
                    
                }
               
                _transactionEditForm.ReloadGrid();
                _transactionEditForm.DoCalc();
                this.Close();
            }
            else
                return;
            
        }

        private bool HasValidData()
        {
            bool isValid = true;
            if(comboBoxItem.SelectedValue is null)
            {
                errorItemLabel.Text = "Item is required";
                isValid = false;
            }
            if(numericQuantity.Value <= 0)
            {
                errorQuantityLabel.Text = "Add at least one Item";
            }
            return isValid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxItem_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxItem.SelectedValue is not null)
            {

                selectedItem = _items.FirstOrDefault(x => x.ID == Guid.Parse(comboBoxItem.SelectedValue.ToString()));
                _transactionLineViewEdit.ItemPrice = selectedItem.Price;
                numericQuantity.Enabled = true;
                CalculateLines();
            }
            

        }
        

        private void numericQuantity_ValueChanged(object sender, EventArgs e)
        {
            if(numericQuantity.Value > 0)
            {
                CalculateLines();
            }
        }

        private void CalculateLines()
        {
            var calcLine = new TransactionLineCalculation();
            calcLine.CalcAll(_transactionLineViewEdit, selectedItem.ItemType);
            numericItemPrice.Value = _transactionLineViewEdit.ItemPrice;
            numericNetValue.Value = _transactionLineViewEdit.NetValue;
            numericTotalValue.Value = _transactionLineViewEdit.TotalValue;
            numericDiscountPercent.Value = (_transactionLineViewEdit.DiscountPercent ?? 0);
            numericDiscountValue.Value = (_transactionLineViewEdit.DiscountValue ?? 0);
        }
    }
}
