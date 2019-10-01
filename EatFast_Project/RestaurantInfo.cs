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
    public partial class RestaurantInfo : Form
    {
        private static RestaurantInfo instance;
        public RestaurantInfo()
        {
            InitializeComponent();
        }

        public static RestaurantInfo getInstance()
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new RestaurantInfo();
            }
            return instance;
        }

        private void RestaurantInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
