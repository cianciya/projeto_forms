using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbLogin.Text;
            string userPassword = txtPassword.Text;

            if (userName == "admin" && userPassword =="admin")
            {
                MessageBox.Show("Login bem-sucedido!");
                this.Visible = false;
                Home home = new Home(); 
                home.ShowDialog();
            }
            else
            {
                MessageBox.Show("Credenciais invalida. Tente novamente!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
