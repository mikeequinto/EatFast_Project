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
    public partial class AdminHomepage : Form
    {
        private static AdminHomepage instance;
        public AdminHomepage()
        {
            InitializeComponent();
        }

        public static AdminHomepage getInstance()
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new AdminHomepage();
            }
            return instance;
        }

        private void AdminHomepage_Load(object sender, EventArgs e)
        {

        }

        private void LinkLogoutClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login.getInstance().Show();
            this.Close();
        }

        private void BtnEditInfoClicked(object sender, EventArgs e)
        {
            RestaurantInfo.getInstance().Show();
            this.Hide();
        }

        private void BtnEditMenuClicked(object sender, EventArgs e)
        {
            MenuEdit.getInstance().Show();
            this.Hide();
        }

        private void BtnTransactionsClicked(object sender, EventArgs e)
        {
            Transactions.getInstance().Show();
            this.Hide();
        }

        private void BtnEditProductClicked(object sender, EventArgs e)
        {
            ProductEdit productEdit = new ProductEdit();
            productEdit.Show();
        }
    }
}
