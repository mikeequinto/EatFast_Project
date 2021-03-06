﻿using System;
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

        AdminHomepage adminHomepage = AdminHomepage.getInstance();

        private void btnAddProductClicked(object sender, EventArgs e)
        {
            //Initialisation du dateset des produits
            DataSetProducts dataSetProducts = new DataSetProducts();

            DataSetProductsTableAdapters.EATFAST_PRODUCTTableAdapter productTableAdapter =
                new DataSetProductsTableAdapters.EATFAST_PRODUCTTableAdapter();

            productTableAdapter.Fill(dataSetProducts.EATFAST_PRODUCT);

            try
            {
                //Insertion dans la bdd
                productTableAdapter.AddProduct(textBoxName.Text, textBoxDescription.Text, "null", 
                    (decimal)float.Parse(textBoxPrice.Text),
                    comboBoxCategory.GetItemText(comboBoxCategory.SelectedItem));

                MessageBox.Show("New product added!");

                //Mise à jour du dataGridView dans le form 
                adminHomepage.UpdateProductsDataGridView();

                ResetProductInfo();

            } catch(Exception o)
            {
                MessageBox.Show("Something went wrong, please try again");
                Console.Write("Exception thrown : ");
                Console.Write("{0}", o.GetType(), o.Message);
            }

            
        }

        private void ResetProductInfo()
        {
            //Réinitialisation des champs
            comboBoxCategory.SelectedIndex = 0;
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxDescription.Text = "";
            labelFilename.Text = "File name";
            picBoxProduct.ImageLocation = "";

            btnAddProduct.Enabled = false;
        }

        private void CheckProductInfo(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedIndex != 0 && textBoxName.Text != ""
                && IsDouble(textBoxPrice.Text) && textBoxDescription.Text != ""
                && labelFilename.Text != "File name")
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

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                //...
                labelFilename.Text = selectedFileName;
                picBoxProduct.ImageLocation = selectedFileName;
            }
        }

        private void BtnClearClicked(object sender, EventArgs e)
        {
            ResetProductInfo();
        }

        private void BtnCloseClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
