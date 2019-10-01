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
    
    public partial class Homepage : Form
    {
        private static Homepage instance;

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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LinkLogoutClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login.getInstance().Show();
            this.Close();
            MessageBox.Show("You have been logged out");
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("You have clicked the x button");
                // Assume that X has been clicked and act accordingly.
                // Confirm user wants to close
                switch (MessageBox.Show(this, "Are you sure?", "Do you still want ... ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //Stay on this form
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }

        }

        private void LinkCartClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cart.getInstance().Show();
            this.Close();
        }

        private void LinkProductsClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Products.getInstance().Show();
            this.Close();
        }

        private void LinkMenuClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Products.getInstance().Show();
            this.Close();
        }
    }
}
