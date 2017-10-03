using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_CarleeMurphy
{

    class DataObject
    {



        static void readCSV()
        {
            DataTable dataTable = new DataTable();

            string[] rowText = System.IO.File.ReadAllLines(@"C:\Users\Carlee\source\repos\MegaDesk-3-CarleeMurphy\MegaDesk-3-CarleeMurphy\bin\Debug\quotes.txt");
            string[] dataColumn = null;
            int x = 0;

            foreach (string textLine in rowText)
            {
                //MessageBox.Show(textLine);
                dataColumn = textLine.Split(',');

                if (x == 0)
                {
                    for (int i = 0; i < dataColumn.Length; i++)
                    {
                        dataTable.Columns.Add(dataColumn[i]);
                    }
                    x++;
                }
                else
                {
                    dataTable.Rows.Add(dataColumn);
                }
                /*
            string filePath = @"C:\Users\Carlee\source\repos\MegaDesk-3-CarleeMurphy\MegaDesk-3-CarleeMurphy\bin\Debugquotes.txt";

            var dataTable = new DataTable();


            File.ReadLines(filePath)
                .Select(x => x.Split(','))
                .ToList()
                .ForEach(line => dataTable.Rows.Add(line));
            return dataTable;
        */
            }

        }
    }
}
