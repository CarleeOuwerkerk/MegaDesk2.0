using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_CarleeMurphy
{
    public partial class ViewAllQuotes : Form
    {
       // DataGridView dataGridView = new DataGridView();
        DataTable dataTable = new DataTable();

        public ViewAllQuotes() 
        {
            InitializeComponent();
            //      this.dataGrid.DataSource = readCSV();

        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void dataObjectBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            //dataGridView.Size = new Size(200, 200);
            //dataGridView.Location = new Point(102, 102);
            string[] rowText = System.IO.File.ReadAllLines(@"C:\Users\Carlee\source\repos\MegaDesk-3-CarleeMurphy\MegaDesk-3-CarleeMurphy\bin\Debug\quotes.txt");
            string[] dataColumn = null;
            int x = 0;

            foreach (string textLine in rowText)
            {
                //MessageBox.Show(textLine);
                dataColumn = textLine.Split(',');

                if (x == 0)
                {
                    for(int i = 0; i < dataColumn.Length; i++)
                    {
                        dataTable.Columns.Add(dataColumn[i]);
                    }
                    x++;
                }
                else
                {
              //      dataTable.Rows.Add(dataColumn);
                }

            }
            dataGridView.DataSource = dataTable;
            this.Controls.Add(dataGridView);
        }

        /*
        DataTable readFile()
        {
            string path = "quotes.txt";
            StreamReader reader = new StreamReader(path);
            DataTable dt = new DataTable();
            int rowCount = 0;

            string[] columnNames = null;
            string[] values = null;

            while (!reader.EndOfStream)
            {
                string rowData = reader.ReadLine().Trim();
                            
                    values = rowData.Split(',');

                    if (rowCount == 0)
                    {
                        rowCount = 1;
                        //columnNames = values;
                        columnNames = null;

                        foreach (string header in columnNames)
                        {
                            DataColumn dataColumn = new DataColumn(header.ToUpper(), typeof(string));
                            dataColumn.DefaultValue = string.Empty;
                            dt.Columns.Add(dataColumn);
                            
                        }
                    }
                    else
                    {
                        DataRow dataRow = dt.NewRow();

                        for (int i = 0; i < columnNames.Length; i++)
                        {
                            dataRow[columnNames[i]] = values[i] == null ?
                                string.Empty : values[i].ToString();
                        }
                        dt.Rows.Add(dataRow);
                        
                    }
                return dt;

                reader.Close();

                /*
                foreach(DataRow dr in dt.Rows)
                {
                    string rowValues = string.Empty;
                    foreach(string columns in columnNames)
                    {
                        rowValues += columns + "=" dr[columns].ToString() + "    ";
                    }
                    
                }
                
            }

            
            public DataTable readCSV()
            {
                string filePath = "quotes.txt";

                var dataTable = new DataTable();


                File.ReadLines(filePath)
                    .Select(x => x.Split(','))
                    .ToList()
                    .ForEach(line => dataTable.Rows.Add(line));
                return dataTable;
            }
            
        }*/
    }
}
