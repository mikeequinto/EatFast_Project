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
    public partial class MenuEdit : Form
    {
        private static MenuEdit instance;
        public MenuEdit()
        {
            InitializeComponent();
        }

        public static MenuEdit getInstance()
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new MenuEdit();
            }
            return instance;
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuEdit_Load(object sender, EventArgs e)
        {

        }

        private void LinkHomeClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminHomepage.getInstance().Show();
            this.Close();
        }
    }
}
