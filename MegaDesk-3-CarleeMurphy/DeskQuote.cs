using Newtonsoft.Json;
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

        public static string SaveFilePath { get; private set; }

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


        private int[,] getRushOrder(string filePath)
        {
            // Immediately error out if the file path does not exist. 
            if (!File.Exists(filePath))
            {
                throw new Exception("ERROR: Rush days file do not exist.");
            }

            // Read all
            string[] prices = File.ReadAllLines(filePath);

            // Initialize a 2D array
            int[,] priceArray = new int[2, 2];
            int pricesCount = 0;
            // Populates array
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    // Add the price to our 2D array
                    priceArray[row, col] = Int32.Parse(prices[pricesCount++]);
                }
            }

            return priceArray;
        }

        /*
        public static void Test()
        {
            string text = File.ReadAllText(@"C:\quotes.txt");

            // Display the file contents to the console. Variable text is a string.
            Console.WriteLine("Contents of WriteText.txt = {0}", text);

            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"C:\quotes.txt");

            // Display the file contents by using a foreach loop.
            Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        } 


        //read from file
        StreamWriter writer;
        writer = new StreamReader("quotes.txt");

        string text = File.ReadAllText("quotes.txt");
        writer.WriteLine("contents.text = {0}", text);

        string[] lines = File.ReadAllText("quotes.txt");

        writer.WriteLine("Contents of WriteLines2.txt = ");
        foreach (string line in lines)
        {
            // Use a tab to indent each line of the file.
            writer.WriteLine("\t" + line);
        }

    // Keep the console window open in debug mode.
        writer.WriteLine("Press any key to exit.");
        StreamReader.ReadAllText();


        // read from file and put into two dimensional array
        StreamReader test;
        reader = new StreamReader("@ C:\ quotes.txt");
        string line = reader.ReadLine();
        reader.WriteLine (line);
            reader.Close();
            */

        //
        public static void Save(DeskQuote quote)
        {
            List<DeskQuote> quotes = new List<DeskQuote>();

            if (File.Exists(SaveFilePath))
            {
                string savedQuotes = File.ReadAllText(SaveFilePath);
                quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(savedQuotes);
            }

            quotes.Add(quote);

            string JSONDesks = JsonConvert.SerializeObject(quotes);

            File.WriteAllText(SaveFilePath, JSONDesks);
        }
    }
}