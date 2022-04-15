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
    public partial class Login : Form
    {
        private UserViewModel userView = new();
        private CurrentUser CurrentUser = new();
        public Login()
        {
            InitializeComponent();
        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            
            
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {

            if (HasValidData())
            {
                userView.Username = textUsername.Text;
                userView.Password = textPassword.Text;
                var client = new HttpClient();
                var result = await client.PostAsJsonAsync<UserViewModel>("https://localhost:7056/Auth", userView);
                if (result.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    errorAuthLabel.Text = "Wrong Credentials";
                    return;
                }
                CurrentUser.UserName = userView.Username;
                CurrentUser.EmployeeType = (EmployeeType)Convert.ToInt32((await result.Content.ReadAsStringAsync()));
                CurrentUser.IsLogedIn = true;
                var form = new Form1(this, CurrentUser);
                this.Hide();
                textUsername.Text = string.Empty;
                textPassword.Text = string.Empty;
                errorPasswordLabel.Text = string.Empty;
                errorUsernameLabel.Text = string.Empty;
                form.ShowDialog();
            }

        }

        private bool HasValidData()
        {
            bool isValid = true;
            if(string.IsNullOrWhiteSpace( textUsername.Text))
            {
                errorUsernameLabel.Text = "Username is required";
                isValid = false;
            }
            if(string.IsNullOrWhiteSpace(textPassword.Text))
            {
                errorPasswordLabel.Text = "Password is required";
                isValid=false;
            }
            return isValid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
