using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EverydayWears
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void SearchButton_click(object sender, EventArgs e)
        {
            string ConditionToSearch = SearchCondition();
            string Search = SearchValues(ConditionToSearch);

            List<string> Results = SearchPerform(ConditionToSearch, Search);

            DisplaySearch(Results);
        }

        private string SearchCondition()
        {
            if (TransactionNumberRadioButton.Checked)
                return "TransactionNumber";
            else if (CustomerNameRadioButton.Checked) return "CustomerName";
            else if (DateOfTransactionRadioButton.Checked) return "DateOfTransaction";
            else return string.Empty;
        }

        private string SearchValues(string ConditionToSearch)
        {
            switch (ConditionToSearch)
            {
                case "TransactionNumber": return TransactionNumberSearchTextBox.Text.Trim();
                case "CustomerName": return CustomerNameSearchTextBox.Text.Trim();
                case "DateOfTransaction": return DateOfTransactionSearchTextBox.Text.Trim();
                default:
                    return string.Empty;
            }
        }

        private List<string> SearchPerform(string ConditionToSearch, string Search)
        {
            List<string> Result = new List<string>();
            string TransactionSearchFile = "Transaction.txt";
            try
            {
                string[] ListOfTransactions = File.ReadAllLines(TransactionSearchFile);
                foreach (string Transaction in ListOfTransactions)
                {
                    string[] DetailsOfTransaction = Transaction.Split(':');
                    if (DetailsOfTransaction.Length == 2 && DetailsOfTransaction[0].Trim() == ConditionToSearch
                        && DetailsOfTransaction[1].Trim() == Search)
                    {
                        Result.Add(Transaction);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error Reading the file to Search for Transaction", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Result;
        }

        private void DisplaySearch(List<string> Results)
        {
            SearchAndSummaryResultListBox.Items.Clear();
            foreach (string Result in Results)
            {
                SearchAndSummaryResultListBox.Items.Add(Result);
            }
        }

        public void FormReset()
        {
            TransactionNumberSearchTextBox.Text = "";
            CustomerNameSearchTextBox.Text = "";
            DateOfTransactionSearchTextBox.Text = "";
            SearchAndSummaryResultListBox.Items.Clear();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
