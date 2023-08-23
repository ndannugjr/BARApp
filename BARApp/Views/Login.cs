using BAR.Core.Classes;
using BAR.Data;
using BAR.Factory;
using BARApp.uc;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BARApp.Views
{
    public partial class Login : Form
    {
        UsersFactory factory;
        public Login()
        {
            InitializeComponent();
            factory = new UsersFactory();

            factory.CreateInitialData();
        }

        private void AuthorizeUser()
        {
            if (txtUserName.Texts == string.Empty)
            {
                errorProvider.SetError(txtUserName, "Required");
                return;
            }
            if (txtPassword.Texts == string.Empty)
            {
                errorProvider.SetError(txtPassword, "Required");
                return;
            }

            txtErrorMessage.Text = "";
            User user = new User()
            {
                UserName = txtUserName.Texts,
                Password = txtPassword.Texts
            };

            if (factory.IsAuthorized(user))
            {
                this.Hide();
                Main m = new Main();
                m.Closed += (s, args) => this.Close();
                m.Show();
            }
            else
            {
                txtErrorMessage.Text = "Invalid username or password";
            }
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            AuthorizeUser();
        }


        private void txt_TextChanged(object sender, EventArgs e)
        {
            var control = ((TextBox)sender).Parent;
            errorProvider.SetError(control, "");
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtPassword, "");
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                AuthorizeUser();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
