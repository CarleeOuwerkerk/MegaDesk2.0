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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            loadGrid();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void loadGrid()
        {
            string path = @"quotes.txt";
            string[] deskQuotes = File.ReadAllLines(path);

            foreach (string deskQuote in deskQuotes)
            {
                string[] row = deskQuote.Split(new char[] { ',' });

                dataGridView.Rows.Add(row);
            }
        }

        private void MaterialBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string material = MaterialBox.Text;
            string path = @"quotes.txt";
            string[] deskQuotes = File.ReadAllLines(path);

            dataGridView.Rows.Clear();

            foreach (string deskQuote in deskQuotes)
            {
                string[] row = deskQuote.Split(new char[] { ',' });

                if ( row.Contains(material))
                {
                    dataGridView.Rows.Add(row);
                }
                
            }

        }
    }
}
