using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace EverydayWears
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        // Form Reset on click of clear
        public void FormReset()
        {
            TransactionNumberSearchTextBox.Text = "";
            CustomerNameSearchTextBox.Text = "";
            DateOfTransactionSearchTextBox.Text = "";
            SearchAndSummaryResultListBox.Items.Clear();
        }

        // Close button actions
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // method to be called to retrieve data for displaying summary
        private List<string> GenerateSummary(string DressType, string DressSize)
        {
            List<string> ResultsOfSummary = new List<string>();
            string TransactionSearchFile = "Transaction.txt";
            try
            {
                string[] ListOfTransactions = File.ReadAllLines(TransactionSearchFile);
                for (int i = 0; i < ListOfTransactions.Length; i += 9)
                {
                    if (i + 8 < ListOfTransactions.Length)
                    {
                        string[] DetailsOfTransaction = ListOfTransactions.Skip(i).Take(9).ToArray();
                        string DressTypeInTransaction = DetailsOfTransaction[5].Trim();
                        string DressSizeInTransaction = DetailsOfTransaction[6].Trim();
                        if (DressTypeInTransaction == DressType && DressSizeInTransaction == DressSize)
                        {
                            string SummaryDetails = $"{DetailsOfTransaction[0]},{DetailsOfTransaction[1]},{DetailsOfTransaction[2]}, {DetailsOfTransaction[8]}";
                            ResultsOfSummary.Add(SummaryDetails);

                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error reading the file to generate the summary", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ResultsOfSummary;
        }


        // Method to display summary.
        // Adds the retrieved record in the SearchAndSummaryResultListBox
        private void DisplaySummary(List<string> Results)
        {
            SearchAndSummaryResultListBox.Items.Clear();
            foreach (string Result in Results)
            {
                SearchAndSummaryResultListBox.Items.Add(Result);
            }
        }

        // Method called to calculate the Dress Cost which is displayed in the IncomeOutputLabel.Text
        private void DressCost(object sender, EventArgs e)
        {
            string DressType = DressTypeComboBox.SelectedItem?.ToString();
            string DressSize = DressSizeComboBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(DressType) && !string.IsNullOrEmpty(DressSize))
            {
                List<string> Results = GenerateSummary(DressType, DressSize);
                DisplaySummary(Results);
                CalculateIncomeForDress(DressType, DressSize);
            }
            else
            {
                MessageBox.Show("Please select Dress Type and Dress Size for the summary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Calculation of the Income for the Summary Button Click
        // This method calculates the cost of the selected dress type and size respectively and displays in the Incomeputputlabel
        private void CalculateIncomeForDress(string DressType, string DressSize)
        {
            decimal Cost = 0;
            try
            {
                string[] ListOfTransactions = File.ReadAllLines("Transaction.txt");
                for (int i = 0; i < ListOfTransactions.Length; i++)
                {
                    if(i + 8 < ListOfTransactions.Length)
                    {
                        string CalculateDressType = ListOfTransactions[i + 5].Trim();
                        string CalculateDressSize = ListOfTransactions[i + 6].Trim();
                        if(CalculateDressType.Equals(DressType, StringComparison.OrdinalIgnoreCase) &&
                            CalculateDressSize.Equals(DressSize, StringComparison.OrdinalIgnoreCase))
                        {
                            Decimal OverallCost = decimal.Parse(ListOfTransactions[i + 8].Trim());
                            Cost += OverallCost;
                        }
                    }
                }
                IncomeOutputLabel.Text = Cost.ToString("0.00");
            }
            catch
            {
                MessageBox.Show("Error Calculating the Overall Income", "Calculation Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        // SummaryButton_Click
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            DressCost(sender, e);
        }


        // Actions performed onclick of the search button. This method opens and reads the Transaction file line by line 
        // And it checks if value in search textboxes match the record in the file. If it matches, it returns by calling the SearchDisplay method
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string TransactionSearch = TransactionNumberSearchTextBox.Text;
            string NameSearch = CustomerNameSearchTextBox.Text;
            string DateSearch = DateOfTransactionSearchTextBox.Text;

            bool RecordsFound = false;
            if (TransactionSearch != "" || NameSearch != "" || DateSearch != "")
            {
                SearchAndSummaryResultListBox.Items.Clear();
                StreamReader SearchFile;
                SearchFile = File.OpenText("Transaction.txt");

                while (!SearchFile.EndOfStream)
                {
                    string SearchByTransactionID = SearchFile.ReadLine();
                    string SearchByName = SearchFile.ReadLine();
                    string SearchByDate = SearchFile.ReadLine();
                    string SearchByTelephoneNumber = SearchFile.ReadLine();
                    string SearchByItemCount = SearchFile.ReadLine();
                    string SearchByDress = SearchFile.ReadLine();
                    string SearchBySize = SearchFile.ReadLine();
                    string SearchByCostOfDress = SearchFile.ReadLine();
                    string SearchByOverallCostOfDress = SearchFile.ReadLine();

                    if (TransactionSearch != "")
                    {
                        if (SearchByTransactionID.Equals(TransactionSearch, StringComparison.OrdinalIgnoreCase))
                        {
                            SearchAndSummaryResultListBox.Items.Add(SearchDisplay(SearchByTransactionID, SearchByName, SearchByDate,
                            SearchByTelephoneNumber, SearchByItemCount, SearchByDress, SearchBySize, SearchByCostOfDress,
                            SearchByOverallCostOfDress));
                            RecordsFound = true;
                        }
                    }

                    else if (NameSearch != "")
                    {
                        if (SearchByName.Equals(NameSearch, StringComparison.OrdinalIgnoreCase))
                        {
                            SearchAndSummaryResultListBox.Items.Add(SearchDisplay(SearchByTransactionID, SearchByName, SearchByDate,
                            SearchByTelephoneNumber, SearchByItemCount, SearchByDress, SearchBySize, SearchByCostOfDress,
                            SearchByOverallCostOfDress));
                            RecordsFound = true;
                        }
                    }

                    else if (DateSearch != "")
                    {
                        if (SearchByDate.Equals(DateSearch, StringComparison.OrdinalIgnoreCase))
                        {
                            SearchAndSummaryResultListBox.Items.Add(SearchDisplay(SearchByTransactionID, SearchByName, SearchByDate,
                            SearchByTelephoneNumber, SearchByItemCount, SearchByDress, SearchBySize, SearchByCostOfDress,
                            SearchByOverallCostOfDress));
                            RecordsFound = true;
                        }
                    }
                }
                SearchFile.Close();
                if (!RecordsFound)
                {
                    MessageBox.Show("Transactions for the entered data doesnt exist, " + "\n" +
                               "Kindly Check the details provided", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SearchAndSummaryResultListBox.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("An error occurred while searching, Kindly select atleast one search option",
                    "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method which is responsible for returning the searchvalues in the SearchAndSummaryResultListBox
        private string SearchDisplay(string SearchByTransactionID, string SearchByName, string SearchByDate,
            string SearchByTelephoneNumber, string SearchByItemCount, string SearchByDress,
            string SearchBySize, string SearchByCostOfDress, string SearchByOverallCostOfDress)
        {
            return
                "Transaction ID: " + SearchByTransactionID + " " +
                "Customer Name: " + SearchByName + " " +
                "Transaction Date: " + SearchByDate + " " +
                "Customer Telephone Number: " + SearchByTelephoneNumber + " " +
                "Item Count " + SearchByItemCount + " " +
                "Dress Type: " + SearchByDress + " " +
                "Dress Size: " + SearchBySize + " " +
                "Cost Of Dress: " + SearchByCostOfDress +
                "Overall Cost of Dress: " + SearchByOverallCostOfDress + "\n";
        }


        // Calculation of the overal summary of all the dress sold and teh profit earned.
        // TotalCost and the TotalCount are retrieved
        private void OverallSummaryReport()
        {
            decimal TotalCost = 0;
            int TotalCount = 0;

            try
            {
                string[] Transactions = File.ReadAllLines("Transaction.txt");
                for (int i = 0; i < Transactions.Length; i += 9)
                {
                    if (i + 8 < Transactions.Length)
                    {
                        int CountOfItems = int.Parse(Transactions[i + 4].Trim());
                        decimal TotalCostOfItems = decimal.Parse(Transactions[i + 8].Trim());

                        TotalCost += TotalCostOfItems;
                        TotalCount += CountOfItems;
                    }
                }
                DisplayTotalSummary(TotalCost, TotalCount);
            }
            catch
            {
                MessageBox.Show("Error in Calculating the Total Summary", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to display the total or the overall summary
        private void DisplayTotalSummary(decimal TotalCost, int TotalCount)
        {
            OverallSummaryReportLabel.Text = $"Total Cost of Items: {TotalCost}, Total Count of Items: {TotalCount}";
        }

        // OverallSummaryReportButton_click Handler
        private void OverallSummaryReportButton_Click(object sender, EventArgs e)
        {
            OverallSummaryReport();
        }
    }
}
