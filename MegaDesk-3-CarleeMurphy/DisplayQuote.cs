using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_CarleeMurphy
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
           
        }

        internal void setValues(Desk desk)
        {

            NameQuote.Text = desk.purchaserName;
            WidthQuote.Text = desk.width.ToString();
            DepthQuote.Text = desk.depth.ToString();
            DrawerQuote.Text = desk.numberOfDrawers.ToString();
            MaterialQuote.Text = desk.surfaceMaterial.ToString();
            ShippingQuote.Text = desk.orderType;
            PriceQuote.Text = desk.price;
            
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
