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
    public partial class ClientPassword : Form
    {
        public ClientPassword()
        {
            InitializeComponent();
        }

        private void CheckPasswordInfo(object sender, EventArgs e)
        {
            if(textBoxOldPassword.Text != "" && textBoxPassword.Text != "" && textBoxPasswordConfirm.Text != "")
            {
                btnSave.Enabled = true;
            }
        }

        private void BtnSaveClicked(object sender, EventArgs e)
        {
            if (!textBoxPassword.Text.Equals(textBoxPasswordConfirm.Text))
            {
                MessageBox.Show("Passwords do not match", "Information");
            }
            else
            {
                this.Close();
                MessageBox.Show("Your password has been updated!", "Information");
            }
        }

        private void BtnCancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
