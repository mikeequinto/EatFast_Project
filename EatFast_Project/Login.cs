using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace EatFast_Project
{
    public partial class Login : Form
    {
        private static Login instance;

        private Login()
        {
            InitializeComponent();
        }

        public static Login getInstance()
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new Login();
            }
            return instance;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(textBoxLoginUsername.Text == "client")
            {
                this.Hide();
                Homepage.getInstance().Show();
            }else if (textBoxLoginUsername.Text == "admin")
            {
                this.Hide();
                AdminHomepage.getInstance().Show();
            }
            else
            {
                MessageBox.Show("The username or password is incorrect", "Information");
            }

        }

        private void BtnSignup_Click(object sender, EventArgs e)
        {
            if (!textBoxSignupPassword.Text.Equals(textBoxSignupConfirm.Text))
            {
                MessageBox.Show("The passwords do not match", "Information");
            }
            else
            {
                this.Hide();
                Homepage.getInstance().Show();

                NewUser newUser = new NewUser();
                newUser.ShowDialog();
            
            }
            //this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void CheckNewUserInfo(object sender, EventArgs e)
        {
            if(textBoxSignupName.Text != "" && textBoxSignupEmail.Text != "" 
                && textBoxSignupPassword.Text != "" && textBoxSignupConfirm.Text != "")
            {
                btnSignup.Enabled = true;
            }
        }
    }
}
