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
    public partial class NewUser : Form
    {
        decimal id;

        public NewUser(decimal id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void UpdateUserAddress()
        {
            //Accès à la table eatfast_person dans la bdd
            DataSetEatFast personDataSet = new DataSetEatFast();
            DataSetEatFastTableAdapters.EATFAST_PERSONTableAdapter listePerson = new DataSetEatFastTableAdapters.EATFAST_PERSONTableAdapter();

            try
            {
                //Mise à jour de l'adresse de livraison
                listePerson.UpdateAddress(textBoxAddress.Text, id);
                Homepage.getInstance().UpdateAddress(textBoxAddress.Text);
                this.Close();
            }
            catch (Exception o)
            {
                MessageBox.Show("Something went wrong");
                Console.Write(o);
            }
        }

        private void BtnSubmitClicked(object sender, EventArgs e)
        {
            UpdateUserAddress();
        }

        private void CheckAddress(object sender, EventArgs e)
        {
            if(textBoxAddress.Text != "")
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }
    }
}
