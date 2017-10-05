using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_CarleeMurphy
{
    class DeskQuote
    {
        static int basePrice = 200;
        static int costPerDrawer = 50;

        public DeskQuote()
        {
        }
        
        // Calculate cost of drawers
        public int getDrawerPrice(int numberOfDrawers)
        {
            int cost = (costPerDrawer * numberOfDrawers);
            return cost;
        }

        // Get surface area.
        public float getSurfaceArea(int width, int depth)
        {
            float area = (width * depth);
            return area;
        }

        // Calculate cost of surface area.
        public float getSurfaceAreaPrice(float surfaceArea)
        {
            float price;
            if (surfaceArea <= 1000)
            {
                price = 0;
            }
            else
            {
                price = (surfaceArea - 1000);
            }
            return price;
        }

        // Calculates cost of material.
        public int getSurfaceMaterialPrice(string material)
        {
            int cost;
            switch (material)
            {
                case "Oak":
                    cost = 200;
                    return cost;
                case "Laminate":
                    cost = 100;
                    return cost;
                case "Pine":
                    cost = 50;
                    return cost; 
                case "Rosewood":
                    cost = 300;
                    return cost;
                case "Veneer":
                    cost = 125;
                    return cost;
                default:
                    cost = 0;
                    return cost;
            }

        }

        // Calculate order type cost
        public int getOrderPrice(float surfaceArea, string orderType)
        {
            int cost;

            switch (orderType)
            {
                case "3 Day":
                    if (surfaceArea < 1000)
                    {
                        cost = 60;
                        return cost;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        cost = 70;
                        return cost;
                    }
                    else
                    {
                        cost = 80;
                        return cost;
                    }
                case "5 Day":
                    if (surfaceArea < 1000)
                    {
                        cost = 40;
                        return cost;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        cost = 50;
                        return cost;
                    }
                    else
                    {
                        cost = 60;
                        return cost;
                    }
                case "7 Day":
                    if (surfaceArea < 1000)
                    {
                        cost = 30;
                        return cost;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        cost = 35;
                        return cost;
                    }
                    else
                    {
                        cost = 40;
                        return cost;
                    }
                default:
                    cost = 0;
                    return cost;
            }            

        }

        public float getQuotePrice(int drawerPrice,
                float surfaceAreaPrice,
                int surfaceMaterialPrice,
                int orderPrice)
        {
            float quotePrice = (drawerPrice
                + surfaceAreaPrice
                + surfaceMaterialPrice
                + orderPrice
                + basePrice);
            return quotePrice;
        }

        public void writeToFile(Desk desk)
        {
            DateTime date = new DateTime();
            date = DateTime.Now;

            StreamWriter writer;
            writer = new StreamWriter("quotes.txt", append: true);
            writer.WriteLine("{0},{1},{2},{3},{4},{5},{6},${7}",
                desk.purchaserName,
                date,
                desk.width.ToString(),
                desk.depth.ToString(),
                desk.numberOfDrawers.ToString(),
                desk.surfaceMaterial,
                desk.orderType,
                desk.price
                );
            writer.Close();

        }
    }
}