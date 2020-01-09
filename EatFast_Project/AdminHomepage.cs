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
    public partial class AdminHomepage : Form
    {
        //Informations de l'utilisateur connecté
        DataSetEatFast.EATFAST_PERSONRow personRow;

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
            // TODO: This line of code loads data into the 'dataSetCategory.EATFAST_PRODUCT' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.dataSetCategory.EATFAST_PRODUCT);
            // TODO: This line of code loads data into the 'dataSetProducts.EATFAST_PRODUCT' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dataSetProducts.EATFAST_PRODUCT);
            // TODO: This line of code loads data into the 'dataSetClientOrders.EATFAST_PERSON' table. You can move, or remove it, as needed.
            this.clientOrdersTableAdapter.Fill(this.dataSetClientOrders.EATFAST_PERSON);
            // TODO: This line of code loads data into the 'dataSetOrders.EATFAST_ORDER' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.dataSetOrders.EATFAST_ORDER);
            // TODO: This line of code loads data into the 'dataSetEatFast.EATFAST_PERSON' table. You can move, or remove it, as needed.
            this.clientTableAdapter.FillByAccountTypeClient(this.clientDataSetEatFast.EATFAST_PERSON);
            // TODO: This line of code loads data into the 'dataSetEatFast.EATFAST_PERSON' table. You can move, or remove it, as needed.
            this.adminTableAdapter.FillByAccountTypeAdmin(this.adminDataSetEatFast.EATFAST_PERSON);
        }

        //Fonction pour initialiser l'utilisateur connecté
        public void initializeUser(DataSetEatFast.EATFAST_PERSONRow personRow)
        {
            this.personRow = personRow;
        }

        //Fonction permettant de chiffrer le mot de passe
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

        public void UpdateProductsDataGridView()
        {
            this.productsTableAdapter.Fill(this.dataSetProducts.EATFAST_PRODUCT);
        }        

        private void LinkLogoutClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
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
                    //Information du nouveau compte
                    String type = comboBoxType.GetItemText(comboBoxType.SelectedItem);
                    String name = textBoxName.Text;
                    String email = textBoxEmail.Text;
                    String password = HashCode(textBoxPassword.Text);

                    try{
                        //Insertion du nouveau compte
                        if (type == "Client")
                        { //Si le compte est de type client
                            this.clientTableAdapter.AddAccount(name, email, password, "", type);
                            this.clientTableAdapter.FillByAccountTypeClient(this.clientDataSetEatFast.EATFAST_PERSON);
                        }
                        else
                        { //Si le compte est de type administrator
                            this.adminTableAdapter.AddAccount(name, email, password, "", type);
                            this.adminTableAdapter.FillByAccountTypeAdmin(this.adminDataSetEatFast.EATFAST_PERSON);
                        }


                        MessageBox.Show("New account added!", "Information");

                        //Réinitialisation des champs
                        comboBoxType.SelectedIndex = 0;
                        textBoxName.Text = "";
                        textBoxEmail.Text = "";
                        textBoxPassword.Text = "";
                        textBoxPasswordConfirm.Text = "";

                        //Mise à jour du dataGridView concerné
                    }
                    catch (OverflowException o)
                    {
                        MessageBox.Show("Something went wrong, please try again");
                        Console.Write("Exception thrown : ");
                        Console.Write("{0}", o.GetType(), o.Message);
                    }
                    
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


        private void fillByAccountTypeClientToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientTableAdapter.FillByAccountTypeClient(this.clientDataSetEatFast.EATFAST_PERSON);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fillByAccountTypeAdminToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.adminTableAdapter.FillByAccountTypeAdmin(this.clientDataSetEatFast.EATFAST_PERSON);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void updateProduct(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("hi");
            if (e.KeyChar == (Char)Keys.Enter)
            {
                int i = productsDataGridView.CurrentRow.Index;
                MessageBox.Show(i.ToString());
            }
        }

        private void updateProduct(object sender, DataGridViewColumnEventArgs e)
        {
            MessageBox.Show("heyy");
        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //Update button update dataset after insertion,upadtion or deletion
            DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                this.productsTableAdapter.Update(dataSetProducts.EATFAST_PRODUCT);
                productsDataGridView.Refresh();
                MessageBox.Show("Menu updated!");
            }
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
        }

        private void updateAccountsBtn_Click(object sender, EventArgs e)
        {
            //Update button update dataset after insertion,upadtion or deletion
            DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                //Mise à jour de la table des clients
                this.clientTableAdapter.Update(clientDataSetEatFast.EATFAST_PERSON);
                clientDataGridView.Refresh();
                //Mise à jour de la table des administrateurs
                this.adminTableAdapter.Update(adminDataSetEatFast.EATFAST_PERSON);
                adminDataGridView.Refresh();
                MessageBox.Show("Accounts updated!");
            }
        }
    }
}
