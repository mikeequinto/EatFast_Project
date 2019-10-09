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
        }

        private void BtnEditInfoClicked(object sender, EventArgs e)
        {
            RestaurantInfo.getInstance().Show();
            this.Hide();
        }

        private void BtnEditMenuClicked(object sender, EventArgs e)
        {
            MenuEdit.getInstance().Show();
            this.Hide();
        }

        private void BtnTransactionsClicked(object sender, EventArgs e)
        {
            Transactions.getInstance().Show();
            this.Hide();
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
            MessageBox.Show("New account added!");

            //Réinitialisation des champs
        }

        private void btnAddProductClicked(object sender, EventArgs e)
        {
            MessageBox.Show("New product added!");

            //Réinitialisation des champs
            comboBoxCategory.SelectedIndex = 0;
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxDescription.Text = "";
        }

        private void CheckProductInfo(object sender, EventArgs e)
        {
            if(comboBoxCategory.SelectedIndex != 0 && textBoxName.Text != "" && IsDouble(textBoxPrice.Text) && textBoxDescription.Text != "")
            {
                btnAddProduct.Enabled = true;
            }
            else
            {
                btnAddProduct.Enabled = false;
            }
        }

        public bool IsDouble(string text)
        {
            Double num = 0;
            bool isDouble = false;

            // Check for empty string.
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            isDouble = Double.TryParse(text, out num);

            return isDouble;
        }
    }
}
