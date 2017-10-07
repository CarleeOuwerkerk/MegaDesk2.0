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
    public partial class GetQuote : Form
    {
        public GetQuote()
        {
            InitializeComponent();
            List<DesktopMaterial> materials = new List<DesktopMaterial>();

            foreach (DesktopMaterial deskMaterial in Enum.GetValues(typeof(DesktopMaterial)))
                materials.Add(deskMaterial);

            MaterialBox.DataSource = materials;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void AddNewQuote_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk();

            switch (MaterialBox.Text)
            {
                case "Oak":
                    desk.surfaceMaterial = DesktopMaterial.Oak;
                    break;
                case "Laminate":
                    desk.surfaceMaterial = DesktopMaterial.Laminate;
                    break;
                case "Pine":
                    desk.surfaceMaterial = DesktopMaterial.Pine;
                    break;
                case "Rosewood":
                    desk.surfaceMaterial = DesktopMaterial.Rosewood;
                    break;
                case "Veneer":
                    desk.surfaceMaterial = DesktopMaterial.Veneer;
                    break;

            }

            desk.width = int.Parse(WidthField.Text);
            desk.depth = int.Parse(DepthField.Text);
            desk.numberOfDrawers = int.Parse(DrawerField.Text);
            desk.purchaserName = NameField.Text;
            desk.orderType = ShippingBox.Text;
            desk.date = DateTime.Now;

            DeskQuote deskQuote = new DeskQuote();

            //check parameters are correct

            // If correct, calculate price.
            int drawerPrice = deskQuote.getDrawerPrice(desk.numberOfDrawers);
            float surfaceArea = deskQuote.getSurfaceArea(desk.width, desk.depth);
            float surfaceAreaPrice = deskQuote.getSurfaceAreaPrice(surfaceArea);
            int surfaceMaterialPrice = deskQuote.getSurfaceMaterialPrice(MaterialBox.Text);
            int orderPrice = deskQuote.getOrderPrice(surfaceArea, desk.orderType);
            desk.price  = deskQuote.getQuotePrice(drawerPrice,
                surfaceAreaPrice,
                surfaceMaterialPrice,
                orderPrice).ToString();

            try
            {
                //call function to write to file
                deskQuote.writeToFile(desk);
            }
            catch (Exception error)
            {
                MessageBox.Show("Cannot write quote to file.  File does not exist.");
            }

            // Display quote
            DisplayQuote displayQuote = new DisplayQuote();
            displayQuote.setValues(desk);
            displayQuote.Show();
            this.Hide();

        }

        private void DepthField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                DepthField.BackColor = Color.Red;
            }
            else if (char.IsDigit(e.KeyChar))
            {
             //   if ()
                DepthField.BackColor = Color.White;
            }

        }

        
        private void WidthField_Validating(object sender, CancelEventArgs e)
        {
            /*
            string errorMsg;
           
            if(!ValidWidthInput(WidthField.Text, out errorMsg))
            {
                e.Cancel = true;
                WidthField.Select(0, WidthField.Text.Length);

             //   this.errorProvider1.SetError(DepthField, errorMsg);
            }*/
        }
        /*
        private bool ValidWidthInput(string width, out string errorMessage)
        {
        
            if (!isInputInteger(width))
            {
                errorMessage = errorMessage = "Please enter a valid width between 24 and 96 square inches.";
                return false;
            }
            else
            {
                int widthInt = int.Parse(width);
                if ((widthInt < 24) || (widthInt > 96))
                {
                    errorMessage = "";
                    return true;
                }
                else
                    errorMessage = "Please enter a valid width between 24 and 96 square inches.";
                     return false;
            }
           
    }
    
        private bool isInputInteger(string width)
        {/*
            try
            {
                int.Parse(width);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        
        }
        */
    }
}
