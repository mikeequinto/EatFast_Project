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
            this.Close();
        }

        private void BtnBackClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckCardInformation(object sender, EventArgs e)
        {
            var cardOk = true;

            if(textBoxCardName.Text != "" && textBoxCardNumber.Text != "")
            {
                cardOk = false;
            }

            if((numericUpDownMonth.Value > 0 && numericUpDownMonth.Value <= 12))
            {
                cardOk = false;
            }

            DateTime dt = DateTime.Now;
            Int32 annee = Int32.Parse(dt.ToString("yy"));

            if (numericUpDownYear.Value < annee)
            {
                cardOk = false;
            }

            /*Int32 cvv = Int32.Parse(textBoxCardCVV.Text);

            if(cvv < 0 || cvv > 999)
            {
                cardOk = false;
            }*/

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
