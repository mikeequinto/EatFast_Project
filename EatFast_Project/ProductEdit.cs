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

            this.Close();
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
            if(comboBoxCategory.SelectedIndex != 0 || textBoxName.Text != "" || textBoxDescription.Text != "" || IsDouble(textBoxPrice.Text))
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }
    }
}
