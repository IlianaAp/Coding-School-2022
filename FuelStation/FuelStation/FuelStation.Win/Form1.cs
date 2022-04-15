using FuelStation.Shared;

namespace FuelStation.Win
{
    public partial class Form1 : Form
    {
        private LoginForm _loginForm;
        private CurrentUser _user;

        public Form1(LoginForm loginForm, CurrentUser user)
        {
            _loginForm = loginForm;
            _user = user;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelUsername.Text = $"Username : {_user.UserName}";
            if(_user.EmployeeType == EmployeeType.Cashier)
            {
                itemsToolStripMenuItem.Visible = false;
                customersToolStripMenuItem.Visible = true;
                transactionsToolStripMenuItem.Visible = true;
            }
            else if (_user.EmployeeType == EmployeeType.Staff)
            {
                itemsToolStripMenuItem.Visible = true;
                customersToolStripMenuItem.Visible = false;
                transactionsToolStripMenuItem.Visible = false;
            }
            else
            {
                itemsToolStripMenuItem.Visible = true;
                customersToolStripMenuItem.Visible = true;
                transactionsToolStripMenuItem.Visible = true;
            }

        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customersForm = new CustomersForm();
            customersForm.ShowDialog();
        }

        private void viewItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var itemsForm = new ItemsForm();
            itemsForm.ShowDialog();
        }

        private void viewTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var transactionsForm = new TransactionsForm();
            transactionsForm.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            _loginForm.Show();
        }
    }
}