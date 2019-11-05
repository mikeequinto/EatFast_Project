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
        public Checkout()
        {
            InitializeComponent();
        }

        private void BtnSubmitClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Your order is on the way!", "Payment successful");
            this.Close();
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

            if (cardOk)
            {
                btnSubmitPayment.Enabled = true;
            }
            else
            {
                btnSubmitPayment.Enabled = false;
            }
        }
    }
}
