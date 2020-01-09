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
    
    public partial class Homepage : Form
    {
        private static Homepage instance;
        private DataSetEatFast.EATFAST_PERSONRow personRow;

        public Homepage()
        {
            InitializeComponent();
        }

        public static Homepage getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Homepage();
            }
            return instance;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LinkLogoutClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        public void setNewUser(String email)
        {
            //Accès à la table eatfast_person dans la bdd
            DataSetEatFast personDataSet = new DataSetEatFast();
            DataSetEatFastTableAdapters.EATFAST_PERSONTableAdapter listePerson = new DataSetEatFastTableAdapters.EATFAST_PERSONTableAdapter();

            try
            {
                //Récupération du nouvel utilisateur inséré dans la bdd
                int id = (int)listePerson.FillByEmail(email);
                DataSetEatFast.EATFAST_PERSONRow personRow = personDataSet.EATFAST_PERSON.FindByPER_ID(id);
                initializeUser(personRow);
            }
            catch (Exception e){
                MessageBox.Show("Something went wrong");
            }
            
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            
        }

        private void Homepage_FormClosing(object sender, FormClosingEventArgs e)
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

        private void BtnInfoClicked(object sender, EventArgs e)
        {
            ProductInfo productInfo = new ProductInfo();
            productInfo.Show();
        }

        private void BtnCheckoutClicked(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();
            checkout.ShowDialog();
        }

        private void BtnAddCartClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Product added!", "Information");
        }

        private void CheckAccountInfo(object sender, EventArgs e)
        {
            if(textBoxName.Text != "" || textBoxEmail.Text != "" || textBoxAddress.Text != "")
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
            ChangePassword clientPassword = new ChangePassword();
            clientPassword.ShowDialog();
        }

        internal void initializeUser(DataSetEatFast.EATFAST_PERSONRow personRow)
        {
            this.personRow = personRow;
            //On demande d'insérer une adresse de livraison si non connue
            if (personRow.PER_ADDRESS == "")
            {
                NewUser newUser = new NewUser();
                newUser.ShowDialog();
            }

        }

        private void BtnSaveAccountClicked(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxEmail.Text = "";
            textBoxAddress.Text = "";

            MessageBox.Show("Your account information has been saved!", "Information");
        }
    }
}
