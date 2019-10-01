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
    public partial class Products : Form
    {
        private static Products instance;
        public Products()
        {
            InitializeComponent();
        }

        public static Products getInstance()
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new Products();
            }
            return instance;
        }

        private void Products_Load(object sender, EventArgs e)
        {

        }

        private void LinkHomeClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Homepage.getInstance().Show();
            this.Close();
        }

        private void LinkCartClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cart.getInstance().Show();
            this.Close();
        }
    }
}
