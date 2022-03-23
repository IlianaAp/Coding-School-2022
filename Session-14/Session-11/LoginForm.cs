using DevExpress.XtraEditors;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AuthenticationService authenticationService = new AuthenticationService(this);
            var isAuthenticated = authenticationService.ValidateUser(textEditUsername.Text, textEditPassword.Text);
            if (isAuthenticated)
            {
                OpenForm openForm = new OpenForm();
                var carServiceForm = openForm.GetForm<CarServiceCenterForm>(authenticationService);
                this.Hide();
                carServiceForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials","Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}