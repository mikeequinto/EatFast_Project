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
    public partial class Cart2 : Form
    {
        public Cart2()
        {
            InitializeComponent();
        }

        private void LinkMenuClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Products.getInstance().Show();
            this.Hide();
        }

        private void LinkHomeClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Products.getInstance().Show();
            this.Hide();
        }
    }
}
