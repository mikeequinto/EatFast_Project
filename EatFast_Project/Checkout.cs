using Oracle.ManagedDataAccess.Client;
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
            AddOrder();
        }

        private void AddOrder()
        {
            //Insertion dans la base de données
            OracleConnection con = new OracleConnection("DATA SOURCE=127.0.0.1:1521/HEGLOCAL;PASSWORD=manager;USER ID=SYSTEM");

            // Open a database connection
            con.Open();

            OracleCommand cmd = new OracleCommand();

            // INSERT statement with RETURNING clause to get the generated ID 
            cmd.CommandText = "INSERT INTO eatfast_data.eatfast_order (per_id,ord_date,ord_status,ord_deliveryaddress,ord_total,ord_paymentstatus)" +
                " VALUES (:per_id, :ord_date, 'Delivered', :ord_deliveryaddress, :ord_total, 'Paid') RETURNING ord_id INTO :orderId";
            cmd.Connection = con;

            cmd.Parameters.Add(new OracleParameter("per_id", user.PER_ID));
            cmd.Parameters.Add(new OracleParameter("ord_date", DateTime.Now));
            cmd.Parameters.Add(new OracleParameter("ord_deliveryaddress", user.PER_ADDRESS));
            cmd.Parameters.Add(new OracleParameter("ord_total", total));

            cmd.Parameters.Add(new OracleParameter
            {
                ParameterName = ":orderId",
                OracleDbType = OracleDbType.Int32,
                Direction = ParameterDirection.Output
            });

            // Execute INSERT statement
            cmd.ExecuteNonQuery();

            //Ajout des produits dans la commande
            Int32 newId = Convert.ToInt32(cmd.Parameters[":orderId"].Value.ToString());
            ConfirmOrder(newId);

            //Ajout de la commande dans le datagridview des commandes
            Homepage.getInstance().UpdateOrders();

            //Réinitialisation du panier
            Homepage.getInstance().ClearCart();

            MessageBox.Show("Your order is on the way!");

            this.Close();
        }

        private void ConfirmOrder(Int32 id)
        {
            // On initialise notre dataset
            DataSetContains containsDataSet = new DataSetContains();

            DataSetContainsTableAdapters.EATFAST_CONTAINSTableAdapter containsTableAdapter =
                new DataSetContainsTableAdapters.EATFAST_CONTAINSTableAdapter();

            //Récupération du panier
            SortedList<int, CartProduct> cart = Homepage.getInstance().GetCart();

            foreach (KeyValuePair<int, CartProduct> cartProduct in cart)
            {
                CartProduct product = (CartProduct)cartProduct.Value;

                //Ajout de chaque produit dans la commande
                containsTableAdapter.AddToOrder(id, product.getId(), product.getPrice(), product.getQuantity());             
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

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
