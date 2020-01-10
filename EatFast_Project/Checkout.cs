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
    public partial class Checkout : Form
    {
        DataSetEatFast.EATFAST_PERSONRow user;
        decimal total;

        public Checkout()
        {
            InitializeComponent();
        }

        private void BtnSubmitClicked(object sender, EventArgs e)
        {
            // On initialise notre dataset
            DataSetCart cartDataSet = new DataSetCart();

            DataSetCartTableAdapters.EATFAST_ORDERTableAdapter cartTableAdapter =
                new DataSetCartTableAdapters.EATFAST_ORDERTableAdapter();
            //Création d'une nouvelle commande
            //string date = DateTime.Now.ToString("yyyy-MM-dd");
            //MessageBox.Show(user.PER_ID + " " + user.PER_ADDRESS + " " + this.total);
            int id = user.PER_ID;
            string address = user.PER_ADDRESS;
            string status = "Delivered";
            string paymentStatus = "Paid";

            //cartTableAdapter.AddOrder(id, DateTime.Now,status,address,this.total,paymentStatus);
            cartTableAdapter.AddOrder2(status);
            //Ajout de la commande dans la bdd
            ConfirmOrder();

            MessageBox.Show("Your order is on the way!", "Payment successful");
            this.Close();
        }

        private void ConfirmOrder()
        {
            

            //Récupération du panier
            SortedList<int, CartProduct> cart = Homepage.getInstance().GetCart();

            foreach (KeyValuePair<int, CartProduct> cartProduct in cart)
            {
                CartProduct product = (CartProduct)cartProduct.Value;
                
                //Ajout de chaque produit dans la commande

                
            }
        }

        private void BtnBackClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckCardInformation(object sender, EventArgs e)
        {
            var cardOk = true;
            
            if(textBoxCardName.Text == "")
            {
                cardOk = false;
            }

            if (!long.TryParse(textBoxCardNumber.Text, out long cardNo))
            {
                cardOk = false;
            }

            if((numericUpDownMonth.Value < 0 || numericUpDownMonth.Value > 12))
            {
                cardOk = false;
            }

            DateTime dt = DateTime.Now;
            Int32 mois = Int32.Parse(dt.ToString("MM"));
            Int32 annee = Int32.Parse(dt.ToString("yy"));

            if (numericUpDownYear.Value < annee)
            {
                cardOk = false;
            } else if(numericUpDownYear.Value == annee)
            {
                if (numericUpDownMonth.Value < mois)
                {
                    cardOk = false;
                }
            }

            if(textBoxCardCVV.Text != "")
            {
                if (!Int32.TryParse(textBoxCardCVV.Text, out int cvv))
                {
                    cardOk = false;
                }
                else
                {
                    if (cvv < 100 || cvv > 999)
                    {
                        cardOk = false;
                    }
                    else
                    {
                        Console.WriteLine("String could not be parsed.");
                    }
                }
              
            }
            else
            {
                cardOk = false;
            }

            if(Homepage.getInstance().CalculateCartTotal() == 0)
            {
                cardOk = false;
            }

            if (cardOk)
            {
                btnSubmitPayment.Enabled = true;
            }
            else
            {
                btnSubmitPayment.Enabled = false;
            }
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            this.total = Homepage.getInstance().CalculateCartTotal();
            labelCartTotal.Text = "Total (CHF) : " + this.total;
            this.user = Homepage.getInstance().GetUser();
        }
    }
}
