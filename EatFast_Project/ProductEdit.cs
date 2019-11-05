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
    public partial class ProductEdit : Form
    {
        public ProductEdit()
        {
            InitializeComponent();
        }

        private void BtnCloseClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSaveClicked(object sender, EventArgs e)
        {
            //Modification d'un produit
            if(comboBoxCategory.SelectedIndex != 0)
            {
                //Mise à jour du produit
            }

            if (textBoxName.Text != "")
            {
                //Mise à jour du produit
            }

            if (textBoxDescription.Text != "")
            {
                //Mise à jour du produit
            }

            if (IsDouble(textBoxPrice.Text))
            {
                //Mise à jour du produit
            }

            if (lblFilename.Text != "File name")
            {
                //Mise à jour du produit
            }

            ResetProductInfo();

            MessageBox.Show("Product information updated!", "Information");

        }

        private void ResetProductInfo()
        {
            comboBoxCategory.SelectedIndex = 0;
            textBoxName.Text = "";
            textBoxDescription.Text = "";
            textBoxPrice.Text = "";
            lblFilename.Text = "";
            picBoxProductImage.ImageLocation = "";
            btnSave.Enabled = false;
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

        private void CheckProductInfo(object sender, EventArgs e)
        {
            if(comboBoxCategory.SelectedIndex != 0 || textBoxName.Text != "" 
                || textBoxDescription.Text != "" || IsDouble(textBoxPrice.Text)
                || lblFilename.Text != "File name")
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void BtnClearClicked(object sender, EventArgs e)
        {
            ResetProductInfo();
        }

        private void BtnChooseFileClicked(object sender, EventArgs e)
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
                lblFilename.Text = selectedFileName;
                picBoxProductImage.ImageLocation = selectedFileName;
                btnSave.Enabled = true;
            }
        }

        private void ProductEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
