using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EatFast_Project
{
    public partial class ChangePassword : Form
    {

        DataSetEatFast.EATFAST_PERSONRow user;

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void CheckPasswordInfo(object sender, EventArgs e)
        {
            if(textBoxPassword.Text != "" && textBoxPasswordConfirm.Text != "")
            {
                btnSave.Enabled = true;
            }
        }

        private void BtnSaveClicked(object sender, EventArgs e)
        {
            //Accès à la table eatfast_person dans la bdd
            DataSetEatFast personDataSet = new DataSetEatFast();
            DataSetEatFastTableAdapters.EATFAST_PERSONTableAdapter personTableAdapter = new DataSetEatFastTableAdapters.EATFAST_PERSONTableAdapter();

            if (!textBoxPassword.Text.Equals(textBoxPasswordConfirm.Text))
            {
                MessageBox.Show("Passwords do not match", "Information");
            }
            else
            {
                if(textBoxPassword.Text.Length < 8)
                {
                    MessageBox.Show("Your password needs to be at least 8 characters long", "Information");
                }
                else
                {
                    //Update password
                    personTableAdapter.UpdatePassword(HashCode(textBoxPassword.Text) , user.PER_ID);
                    this.Close();
                    MessageBox.Show("Your password has been updated!", "Information");
                }
                
            }
        }

        public static string HashCode(string str)
        {
            System.Text.ASCIIEncoding encoder = new System.Text.ASCIIEncoding();
            byte[] buffer = encoder.GetBytes(str);
            SHA1CryptoServiceProvider cryptoTransformSHA1 =
            new SHA1CryptoServiceProvider();
            string hash = BitConverter.ToString(
                cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");

            return hash;
        }

        private void BtnCancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientPassword_Load(object sender, EventArgs e)
        {
            this.user = Homepage.getInstance().GetUser();
        }
    }
}
