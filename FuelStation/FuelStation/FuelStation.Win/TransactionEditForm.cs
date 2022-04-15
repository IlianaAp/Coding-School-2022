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
    public partial class TransactionEditForm : Form
    {
        private TransactionViewModel _transaction;
        private TotalValueCalculation _calc;
        private TransactionsForm _transactionsForm;
        private HttpClient httpClient;
        public TransactionEditForm(TransactionViewModel transactionView, TransactionsForm transactionsForm)
        {
            _transactionsForm = transactionsForm;
            _transaction = transactionView;
            InitializeComponent();
        }

        private async void TransactionEditForm_Load(object sender, EventArgs e)
        {

            httpClient = new HttpClient();
            if (_transaction.ID != Guid.Empty)
            {

                _transaction = await httpClient.GetFromJsonAsync<TransactionViewModel>($"https://localhost:7056/Transaction/{_transaction.ID}");

            }
            else
            {
                _transaction.Date = DateTime.Now;

            }
            textCardNumber.Text = _transaction.Customer.CardNumber;
            textName.Text = _transaction.Customer.Name;
            textSurname.Text = _transaction.Customer.Surname;
            InitComboBoxes();


            dateTimePicker.DataBindings.Add(new Binding("Value", _transaction, nameof(TransactionViewModel.Date), true));
            numericUpDownTotalValue.DataBindings.Add(new Binding("Value", _transaction, nameof(TransactionViewModel.TotalValue), true));
            bsTransactionLines.DataSource = _transaction.TransactionLineViewModels;
            grdTransactionLines.DataSource = bsTransactionLines;
            dateTimePicker.Value = DateTime.Now;
            HideTransactionLineColumns();
        }

        private async void InitComboBoxes()
        {

            var employees = await httpClient.GetFromJsonAsync<List<EmployeeViewModel>>("https://localhost:7056/Employee/GetManagersCashiers");
            comboBoxEmployee.DisplayMember = "Text";
            comboBoxEmployee.ValueMember = "Value";
            List<object> employeeList = new();
            foreach (var employee in employees)
            {
                employeeList.Add(new { Text = string.Join(" ", employee.Surname, employee.Name), Value = employee.ID });
            }
            comboBoxEmployee.DataSource = employeeList;
            comboBoxPaymentMethod.DataSource = Enum.GetValues(typeof(PaymentMethod));
            comboBoxEmployee.DataBindings.Add(new Binding("SelectedValue", _transaction, nameof(TransactionViewModel.EmployeeID), true));
            comboBoxPaymentMethod.DataBindings.Add(new Binding("SelectedValue", _transaction, nameof(TransactionViewModel.PaymentMethod), true));
            comboBoxPaymentMethod.SelectedItem = _transaction.PaymentMethod;
            var selectedEmployee = employees.FirstOrDefault(x => x.ID == _transaction.EmployeeID);
            if(selectedEmployee != null)
            {
                comboBoxEmployee.SelectedItem = new { Text = string.Join(" ", selectedEmployee.Surname, selectedEmployee.Name), Value = selectedEmployee.ID };
            }           
            if(_transaction.TotalValue > 50)
            {
                comboBoxPaymentMethod.Enabled = false;
            }
        }
        public void DoCalc()
        {
            var calc = new TotalValueCalculation();
            calc.CalculateTotalValue(_transaction);
            if (_transaction.TotalValue > 50)
            {
                //_transaction.PaymentMethod = PaymentMethod.Cash;
                comboBoxPaymentMethod.SelectedItem = PaymentMethod.Cash;
                comboBoxPaymentMethod.Enabled = false;
            }
            else
            {
                comboBoxPaymentMethod.Enabled = true;
            }
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            errorEmployeeLabel.Text = string.Empty;
            errorPaymentMethodLabel.Text = string.Empty;
            errorTransactionLineLabel.Text = string.Empty;
            HttpResponseMessage res;
            if (HasValidData())
            {
                if (_transaction.ID == Guid.Empty)
                {
                    var httpClient = new HttpClient();
                    res = await httpClient.PostAsJsonAsync("https://localhost:7056/Transaction", _transaction);
                }
                else
                {
                    var httpClient = new HttpClient();
                    res = await httpClient.PutAsJsonAsync("https://localhost:7056/Transaction", _transaction);

                }
                if (res.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    errorTransactionLineLabel.Text = await res.Content.ReadAsStringAsync();
                }
                else
                {
                    await _transactionsForm.LoadData();
                    this.Close();
                }

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HideTransactionLineColumns()
        {
            grdTransactionLines.Columns[0].Visible = false;
            grdTransactionLines.Columns[1].Visible = false;
            grdTransactionLines.Columns[2].Visible = false;
        }
        public void ReloadGrid()
        {
            bsTransactionLines.DataSource = null;
            bsTransactionLines.DataSource = _transaction.TransactionLineViewModels;
            HideTransactionLineColumns();
        }

        private bool HasValidData()
        {
            bool isValid = true;
            if (comboBoxEmployee.SelectedValue is null)
            {
                errorEmployeeLabel.Text = "Employee is required";
                isValid = false;
            }
            if (comboBoxPaymentMethod.SelectedValue is null)
            {
                errorPaymentMethodLabel.Text = "PaymentMEthod is Required";
                isValid = false;
            }
            //if (_transaction.TransactionLineViewModels.Count == 0)
            //{
            //    errorTransactionLineLabel.Text = "Add at least one Transaction Line";
            //    isValid = false;
            //}
            return isValid;
        }

        public void ShowTotalValue()
        {
            _calc.CalculateTotalValue(_transaction);
        }

        private void btnNewTransactionLine_Click(object sender, EventArgs e)
        {
            TransactionLineViewModel transactionLine = new TransactionLineViewModel();
            var form = new TransactionLineEdit(_transaction, true, transactionLine, this);
            form.ShowDialog();
        }

        private void btnEditTransactionLine_Click(object sender, EventArgs e)
        {
            var line = grdTransactionLines.SelectedRows[0].DataBoundItem as TransactionLineViewModel;
            var form = new TransactionLineEdit(_transaction, false, line, this);
            form.ShowDialog();
        }

        private void btnDeleteTransactionLine_Click(object sender, EventArgs e)
        {
            var line = grdTransactionLines.SelectedRows[0].DataBoundItem as TransactionLineViewModel;
            bsTransactionLines.Remove(line);
            ReloadGrid();

        }
    }
}
