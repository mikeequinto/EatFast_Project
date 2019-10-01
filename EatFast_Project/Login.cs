using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EatFast_Project
{
    public partial class Login : Form
    {
        private AdminHomepage adminHomepage;   
        private Homepage clientHomepage;
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
            this.Hide();
            Homepage.getInstance().Show();
            //this.Close();
        }

        private void BtnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomepage.getInstance().Show();
            //this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
