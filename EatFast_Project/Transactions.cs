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
    public partial class Transactions : Form
    {
        private static Transactions instance;
        public Transactions()
        {
            InitializeComponent();
        }

        public static Transactions getInstance()
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new Transactions();
            }
            return instance;
        }

        private void Transactions_Load(object sender, EventArgs e)
        {

        }

        private void LinkHomeClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminHomepage.getInstance().Show();
            this.Close();
        }
    }
}
