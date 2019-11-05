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
    public partial class AdminHomepage : Form
    {
        private static AdminHomepage instance;
        public AdminHomepage()
        {
            InitializeComponent();
        }

        public static AdminHomepage getInstance()
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new AdminHomepage();
            }
            return instance;
        }

        private void AdminHomepage_Load(object sender, EventArgs e)
        {

        }

        private void LinkLogoutClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login.getInstance().Show();
            this.Close();
            MessageBox.Show("You have been logged out", "Information");
        }

        private void BtnEditProductClicked(object sender, EventArgs e)
        {
            ProductEdit productEdit = new ProductEdit();
            productEdit.ShowDialog();
        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Label33_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddAccountClicked(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Equals(textBoxPasswordConfirm.Text))
            {
                if(textBoxPassword.Text.Length < 8)
                {
                    MessageBox.Show("Your password needs to be at least 8 characters long", "Information");
                }
                else
                {
                    MessageBox.Show("New account added!", "Information");

                    //Réinitialisation des champs
                    comboBoxType.SelectedIndex = 0;
                    textBoxName.Text = "";
                    textBoxEmail.Text = "";
                    textBoxPassword.Text = "";
                    textBoxPasswordConfirm.Text = "";
                }

                
            }
            else
            {
                MessageBox.Show("The passwords do not match", "Information");
            }
            
        }

        private void BtnRemoveClicked(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete product", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
                
            }
        }

        private void CheckRestaurantInfo(object sender, EventArgs e)
        {
            if(textBoxRestaurantName.Text != "" || textBoxRestaurantDescription.Text != "")
            {
                btnSaveRestaurantInfo.Enabled = true;
            }
            else
            {
                btnSaveRestaurantInfo.Enabled = false;
            }
        }

        private void btnSaveRestaurantInfoClicked(object sender, EventArgs e)
        {
            if(textBoxRestaurantName.Text != "")
            {
                //Mise à jour des informations
            }

            if (textBoxRestaurantDescription.Text != "")
            {
                //Mise à jour des informations
            }

            if (lblFileName.Text != "File name")
            {
                //Mise à jour des informations 
            }

            ResetRestaurantInfo();

            MessageBox.Show("Restaurant information updated!", "Information");
        }

        private void ResetRestaurantInfo()
        {
            textBoxRestaurantName.Text = "";
            textBoxRestaurantDescription.Text = "";
            lblFileName.Text = "File name";
            picBoxRestoBackground.ImageLocation = "";
            btnSaveRestaurantInfo.Enabled = false;
        }

        private void CheckAccountInfo(object sender, EventArgs e)
        {
            if(comboBoxType.SelectedIndex != 0 && textBoxName.Text != "" 
                && textBoxEmail.Text != "" && textBoxPassword.Text != "" 
                && textBoxPasswordConfirm.Text != "")
            {
                btnAddAccount.Enabled = true;
            }
            else
            {
                btnAddAccount.Enabled = false;
            } 
        }

        private void btnRestaurantBackground_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            //openFileDialog1.FilterIndex = 0;
            //openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                //...
                lblFileName.Text = selectedFileName;
                picBoxRestoBackground.ImageLocation = selectedFileName;
                btnSaveRestaurantInfo.Enabled = true;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddProductClicked(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
        }

        private void tabInformation_Click(object sender, EventArgs e)
        {

        }

        private void BtnClearRestauInfoClicked(object sender, EventArgs e)
        {
            ResetRestaurantInfo();
        }

        private void linkLabelLogout_Click(object sender, EventArgs e)
        {

        }

        private void CheckUserAccountInfo(object sender, EventArgs e)
        {
            if (textBoxAccountName.Text != "" || textBoxAccountEmail.Text != "")
            {
                btnSaveAccount.Enabled = true;
            }
            else
            {
                btnSaveAccount.Enabled = false;
            }
        }

        private void BtnChangePasswordClicked(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
        }

        private void BtnSaveClicked(object sender, EventArgs e)
        {

            if(textBoxAccountName.Text != "")
            {
                //Update changes
            }

            if (textBoxAccountEmail.Text != "")
            {
                //Update changes
            }

            textBoxAccountName.Text = "";
            textBoxAccountEmail.Text = "";

            MessageBox.Show("Your account information has been saved!", "Information");
        }

        private void AdminHomepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show(this, "Are you sure you want to log out?", "Logging out", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //Stay on this form
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    Login.getInstance().Show();
                    MessageBox.Show("You have been logged out", "Information");
                    break;
            }
        }
    }
}
