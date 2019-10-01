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
    public partial class Cart : Form
    {
        private static Cart instance;

        public static Cart getInstance()
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new Cart();
            }
            return instance;
        }

        private Cart()
        {
            InitializeComponent();
        }

        private void LinkHomeClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Homepage.getInstance().Show();
            this.Close();
        }

        private void LinkMenuClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Products.getInstance().Show();
            this.Close();
        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }
    }
}
