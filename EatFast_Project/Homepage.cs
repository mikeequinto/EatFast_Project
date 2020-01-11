using System;
using System.Collections;
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
    
    internal partial class Homepage : Form
    {
        private static Homepage instance;
        private DataSetEatFast.EATFAST_PERSONRow personRow;
        private SortedList<int,CartProduct> cart = new SortedList<int,CartProduct>();

        public Homepage()
        {
            InitializeComponent();
        }

        public static Homepage getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Homepage();
            }
            return instance;
        }

        public DataSetEatFast.EATFAST_PERSONRow GetUser()
        {
            return this.personRow;
        }

        public void UpdateAddress(string address)
        {
            this.personRow.SetField(4,address);
        }

        public SortedList<int,CartProduct> GetCart()
        {
            return this.cart;
        }

        public void ClearCart()
        {
            this.cart.Clear();
            UpdateCart();
        }

        public void UpdateOrders()
        {
            eATFAST_ORDERTableAdapter.FillByClient(this.dataSetOrders.EATFAST_ORDER, personRow.PER_ID);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LinkLogoutClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {    
            // TODO: This line of code loads data into the 'dataSetProducts.EATFAST_PRODUCT' table. You can move, or remove it, as needed.
            this.eATFAST_PRODUCTTableAdapter.Fill(this.dataSetProducts.EATFAST_PRODUCT);

            //Get restaurant information
            GetRestaurantInfo();

        }

        private void GetRestaurantInfo()
        {
            // On initialise notre dataset

            DataSetRestaurant restaurantDataSet = new DataSetRestaurant();

            DataSetRestaurantTableAdapters.EATFAST_RESTAURANTTableAdapter restaurantTableAdapter =
                new DataSetRestaurantTableAdapters.EATFAST_RESTAURANTTableAdapter();

            restaurantTableAdapter.Fill(restaurantDataSet.EATFAST_RESTAURANT);

            DataSetRestaurant.EATFAST_RESTAURANTRow restaurantRow =
                restaurantDataSet.EATFAST_RESTAURANT.FindByRES_ID(1);

            // On met à jour les informations du restaurant

            labelRestaurantName.Text = restaurantRow.RES_NAME;
            labelRestaurantInfo.Text = restaurantRow.RES_DESCRIPTION;

        }

        private void Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show(this, "Are you sure you want to log out?", "Logging out", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //Stay on this form
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    Login.getInstance().Show();
                    MessageBox.Show("You have been logged out", "Information");
                    break;
            }
        }

        private void BtnInfoClicked(object sender, EventArgs e)
        {
            ProductInfo productInfo = new ProductInfo();
            productInfo.Show();
        }

        private void BtnCheckoutClicked(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();
            checkout.ShowDialog();
        }

        private void BtnAddCartClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Product added!", "Information");
        }

        private void CheckAccountInfo(object sender, EventArgs e)
        {
            if(textBoxName.Text != "" || textBoxAddress.Text != "")
            {
                btnSaveAccount.Enabled = true;
            }
            else
            {
                btnSaveAccount.Enabled = false;
            }
        }

        private void BtnChangePasswordClicked(object sender, EventArgs e)
        {
            ChangePassword clientPassword = new ChangePassword(personRow.PER_ID);
            clientPassword.ShowDialog();
        }

        public void InitializeNewUser(string email)
        {
            //Accès à la table eatfast_person dans la bdd
            DataSetEatFast personDataSet = new DataSetEatFast();
            DataSetEatFastTableAdapters.EATFAST_PERSONTableAdapter listePerson = new DataSetEatFastTableAdapters.EATFAST_PERSONTableAdapter();
            listePerson.Fill(personDataSet.EATFAST_PERSON);

            try
            {
                //Récupération du nouvel utilisateur 
                int id = (int)listePerson.FillByEmail(email);
                DataSetEatFast.EATFAST_PERSONRow personRow = personDataSet.EATFAST_PERSON.FindByPER_ID(id);
                this.personRow = personRow;
                NewUser newUser = new NewUser(id);
                newUser.ShowDialog();
            }
            catch (Exception o)
            {
                MessageBox.Show("Something went wrong");
                Console.Write(o);
            }
        }

        public void initializeUser(DataSetEatFast.EATFAST_PERSONRow personRow)
        {
            this.personRow = personRow;
            //On demande d'insérer une adresse de livraison si non connue
            if (personRow.IsPER_ADDRESSNull())
            {
                NewUser newUser = new NewUser(personRow.PER_ID);
                newUser.ShowDialog();
            }

            // TODO: This line of code loads data into the 'dataSetOrders.EATFAST_ORDER' table. You can move, or remove it, as needed.
            this.eATFAST_ORDERTableAdapter.FillByClient(this.dataSetOrders.EATFAST_ORDER, personRow.PER_ID);

        }

        private void BtnSaveAccountClicked(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string address = textBoxAddress.Text;

            //Accès à la table eatfast_person dans la bdd
            DataSetEatFast personDataSet = new DataSetEatFast();
            DataSetEatFastTableAdapters.EATFAST_PERSONTableAdapter personTableAdapter = new DataSetEatFastTableAdapters.EATFAST_PERSONTableAdapter();

            if (name != "")
            {
                //Update name
                personTableAdapter.UpdateName(name, personRow.PER_ID);

            }

            if(address != "")
            {
                //Update address
                personTableAdapter.UpdateAddress(address, personRow.PER_ID);
            }

            textBoxName.Text = "";
            textBoxAddress.Text = "";

            MessageBox.Show("Your account information has been saved!", "Information");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void eATFAST_PRODUCTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eATFAST_PRODUCTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetProducts);

        }

        private void eATFAST_PRODUCTDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)productsDataGridView.Rows[e.RowIndex].Cells[0].Value;
            string name = Convert.ToString(productsDataGridView.Rows[e.RowIndex].Cells[1].Value);
            decimal price = Convert.ToDecimal(productsDataGridView.Rows[e.RowIndex].Cells[3].Value);

            if (e.ColumnIndex == 5)
            {
                AddProductToCart(id, name, price);
                MessageBox.Show("Product added to cart!");
            } 
        }

        private void AddProductToCart(int id, string name, decimal price)
        {

            if (cart.ContainsKey(id))
            {
                CartProduct product = cart[id];
                product.add();
                cart[id] = product;
                UpdateCart();
            }
            else
            {
                CartProduct product = new CartProduct(id, name, price);
                cart.Add(id, product);
                UpdateCart();
            }
        }

        private void SubtractFromCart(int id)
        {
            if (cart.ContainsKey(id))
            {
                CartProduct product = cart[id];
                if(product.getQuantity() > 1)
                {
                    product.subtract();
                    cart[id] = product;
                    UpdateCart();
                }
                else
                {
                    //remove from cart
                    RemoveFromCart(id);
                }
                
            }
        }

        private void RemoveFromCart(int id)
        {
            cart.Remove(id);
            UpdateCart();
        }

        private void UpdateCart()
        {
            //Réinitialisation du cart
            cartDataGridView.Rows.Clear();
            cartDataGridView.Refresh();

            //Ajout des produits du panier dans le datagridview
            foreach (KeyValuePair<int,CartProduct> cartProduct in cart)
            {
                CartProduct product = (CartProduct)cartProduct.Value;
                cartDataGridView.Rows.Add(cartProduct.Key,product.getName(),product.getPrice(),product.getQuantity());
            }

            //Mise à jour du nombre de produits dans le panier et le total
            labelCartQuantity.Text = GetCartQuantity().ToString();
            labelCartTotal.Text = CalculateCartTotal().ToString();

        }

        private int GetCartQuantity()
        {
            int quantity = 0;
            foreach (KeyValuePair<int, CartProduct> cartProduct in cart)
            {
                CartProduct product = (CartProduct)cartProduct.Value;
                quantity = quantity + product.getQuantity();
            }
            return quantity;
        }

        public decimal CalculateCartTotal()
        {
            decimal total = 0;
            foreach (KeyValuePair<int, CartProduct> cartProduct in cart)
            {
                CartProduct product = (CartProduct)cartProduct.Value;
                total = total + (product.getPrice() * product.getQuantity());
            }
            return total;
        }

        private void cartDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Produit concerné
            int id = (int)cartDataGridView.Rows[e.RowIndex].Cells[0].Value;
            string name = Convert.ToString(cartDataGridView.Rows[e.RowIndex].Cells[1].Value);
            decimal price = Convert.ToDecimal(cartDataGridView.Rows[e.RowIndex].Cells[2].Value);

            if (e.ColumnIndex == 4)
            {
                //Add product
                AddProductToCart(id, name, price);
            }
            if (e.ColumnIndex == 5)
            {
                //Subtract product
                SubtractFromCart(id);
            }
            if (e.ColumnIndex == 6)
            {
                //Remove product
                RemoveFromCart(id);
            }
        }
    }
}
