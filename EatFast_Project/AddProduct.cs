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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnAddProductClicked(object sender, EventArgs e)
        {
            MessageBox.Show("New product added!");

            ResetProductInfo();
        }

        private void ResetProductInfo()
        {
            //Réinitialisation des champs
            comboBoxCategory.SelectedIndex = 0;
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxDescription.Text = "";

            btnAddProduct.Enabled = false;
        }

        private void CheckProductInfo(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedIndex != 0 && textBoxName.Text != ""
                && IsDouble(textBoxPrice.Text) && textBoxDescription.Text != ""
                && labelFilename.Text != "")
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

        private void btnProductImageClicked(object sender, EventArgs e)
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
                labelFilename.Text = selectedFileName;
                picBoxProduct.ImageLocation = selectedFileName;
            }
        }
    }
}
