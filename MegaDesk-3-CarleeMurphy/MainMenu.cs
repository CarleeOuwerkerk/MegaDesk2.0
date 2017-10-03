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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddNewQuote_Click(object sender, EventArgs e)
        {
            GetQuote addQuoteForm = new GetQuote();
            addQuoteForm.Show();
            this.Hide();
        }

        private void ViewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewQuotesForm = new ViewAllQuotes();
            viewQuotesForm.Show();
            this.Hide();
        }

        private void SearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotesForm = new SearchQuotes();
            searchQuotesForm.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}