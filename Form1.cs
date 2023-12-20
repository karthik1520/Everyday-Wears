namespace EverydayWears
{
    public partial class Form1 : Form
    {
        public static String[] DressName = {"Jogger", "Jumper", "Shorts", "Tracks", "Shirts", "T-Shirts", "Hoodie",
            "OverCoat", "Skirt", "Leggings", "Jeans", "Pants", "NightWear", "Sweater", "TrenchCoat"};

        private static String[] DressSize = { "ExtraSmall", "Small", "Medium", "Large", "ExtraLarge" };
        private static Decimal[,] DressRate = { {5.89M, 6.89M, 7.89M, 8.89M, 9.89M },
            {3.49M, 4.49M, 5.49M, 6.49M, 7.49M },{5.20M, 6.20M, 7.20M, 8.20M, 9.20M},
            {3.98M, 4.98M, 5.98M, 6.98M, 7.98M },{2.56M, 3.56M, 4.56M, 5.56M, 6.56M },
            {10.00M, 11.00M, 12.00M, 13.00M, 14.00M },{9.56M, 10.56M, 11.56M, 12.56M, 13.56M },
            {15.25M, 16.25M, 17.25M, 18.25M, 19.25M },{3.74M, 4.74M, 5.74M, 5.74M, 6.74M },
            {8.43M, 9.43M, 10.43M, 11.43M, 12.43M },{12.99M, 13.99M, 14.99M, 15.99M, 16.99M },
            {10.00M, 11.00M, 12.00M, 13.00M, 14.00M },{7.23M, 8.23M, 9.23M, 10.23M, 11.23M },
            {5.99M, 6.99M, 7.99M, 8.99M, 10.99M },{8.55M, 9.55M, 10.55M, 11.55M, 12.55M }};

        private int[,] OverallStockAvailable = new int[DressName.Length, DressSize.Length];
        private int[,] DressStockAvailable = new int[DressName.Length, DressSize.Length];

        private int TransactionNumber = 1;
        public Form1()
        {
            InitializeComponent();

            // Read stock from file on load of form
            ReadInitialStockFromFile("InitialStocks.txt");
            StockPanel.Visible = false; // Initialize DisplayPanel visibility
            DisplayPanel.Visible = false;
            BookingGroupBox.Visible = false;

        }
        private void UpdateStockLabels()
        {
            int SelectedDressIndex = DressListBox.SelectedIndex;
            int SelectedSizeIndex = DressSizeListBox.SelectedIndex;

            if (SelectedDressIndex >= 0 && SelectedSizeIndex >= 0)
            {
                DressCostLabel.Text = $"{DressRate[SelectedDressIndex, SelectedSizeIndex]:C}";
                int StockCount = DressStockAvailable[SelectedDressIndex, SelectedSizeIndex];
                int AvailableStock = StockCount - (int)DressCountNumericUpDown.Value;
                AvailableStockLabel.Text = $"{AvailableStock}";
                StockPanel.Visible = true;
            }
            else
            {
                StockPanel.Visible = false;
            }
        }
        private void DressListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStockLabels();
        }

        private void DressSizeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStockLabels();
        }


        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            int SelectedDressIndex = DressListBox.SelectedIndex;
            int SelectedSizeIndex = DressSizeListBox.SelectedIndex;

            if (SelectedDressIndex >= 0 && SelectedSizeIndex >= 0)
            {
                string SelectedDress = DressName[SelectedDressIndex];
                string SelectedSize = DressSize[SelectedSizeIndex];
                int Count = (int)DressCountNumericUpDown.Value;

                string CartItems = $"{SelectedDress} - {SelectedSize} - {Count}";
                AddToCartListBox.Items.Add(CartItems);
            }
            else
            {
                MessageBox.Show("Please select a dress and size before adding to the cart.");
            }
        }

        private void ReadInitialStockFromFile(string fileName)
        {
            try
            {
                string[] Lines = File.ReadAllLines(fileName);

                if (Lines.Length != DressName.Length)
                {
                    MessageBox.Show("Number of lines in the file does not match the number of dresses.");
                    return;
                }

                for (int i = 0; i < DressName.Length; i++)
                {
                    string[] ValueStock = Lines[i].Split(',');

                    if (ValueStock.Length != DressSize.Length)
                    {
                        MessageBox.Show($"Invalid data in line {i + 1}. Number of values does not match the number of sizes.");
                        return;
                    }

                    for (int j = 0; j < DressSize.Length; j++)
                    {
                        if (int.TryParse(ValueStock[j], out int stock))
                        {
                            DressStockAvailable[i, j] = stock;
                        }
                        else
                        {
                            MessageBox.Show($"Invalid stock value in line {i + 1}, column {j + 1}.");
                            return;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show($"Error reading file");
            }
        }

        private void UpdateStockFile(string fileName)
        {
            try
            {
                List<string> FileUpdate = new List<string>();

                for (int i = 0; i < DressName.Length; i++)
                {
                    string[] ValuesStock = new string[DressSize.Length];

                    for (int j = 0; j < DressSize.Length; j++)
                    {
                        ValuesStock[j] = DressStockAvailable[i, j].ToString();
                    }

                    FileUpdate.Add(string.Join(",", ValuesStock));
                }

                File.WriteAllLines(fileName, FileUpdate);

                MessageBox.Show("Stock updated successfully in the file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show($"Error updating stock file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DressCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int SelectedDressIndex = DressListBox.SelectedIndex;
            int SelectedSizeIndex = DressSizeListBox.SelectedIndex;

            if (SelectedDressIndex >= 0 && SelectedSizeIndex >= 0)
            {
                DressCostLabel.Text = $"{DressRate[SelectedDressIndex, SelectedSizeIndex]:C}";
                int StockCount = DressStockAvailable[SelectedDressIndex, SelectedSizeIndex];
                int AvailableStock = StockCount - (int)DressCountNumericUpDown.Value;
                AvailableStockLabel.Text = $"{AvailableStock}";
                StockPanel.Visible = true;
            }
            else
            {
                StockPanel.Visible = false;
            }
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            int SelectedDressIndex = DressListBox.SelectedIndex;
            int SelectedSizeIndex = DressSizeListBox.SelectedIndex;

            // Check if dress and size are selected
            if (SelectedDressIndex >= 0 && SelectedSizeIndex >= 0)
            {
                DisplayPanel.Visible = true;
                DisplayDressLabel.Text = $"{DressName[SelectedDressIndex]}";
                DisplayDressSizeLabel.Text = $"{DressSize[SelectedSizeIndex]}";
                DressRateDisplayLabel.Text = $"{DressRate[SelectedDressIndex, SelectedSizeIndex]:C}";
                DisplayDressCountLabel.Text = $"{(int)DressCountNumericUpDown.Value}";
            }
            else
            {
                DisplayPanel.Visible = false;
                MessageBox.Show("Kindly select a Dress and Size appropriately", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TransactionNumberCounter()
        {
            TransactionNumberLabel.Text = TransactionNumber.ToString();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to submit the order?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                TransactionNumber++;
                TransactionNumberCounter();
                UpdateStockFile("InitialStocks.txt");
                string TransactionFile = "Transaction.txt";
                string SalesReport = "SalesReport.txt";
                try
                {
                    using (StreamWriter Transaction = new StreamWriter(TransactionFile, true))
                    using (StreamWriter Sales = new StreamWriter(SalesReport, true))
                    {
                        Transaction.WriteLine($"{TransactionNumberLabel.Text}");
                        Transaction.WriteLine($"{CustomerNameTextBox.Text}");
                        Transaction.WriteLine($"{DateLabel.Text}");
                        Transaction.WriteLine($"{PhoneNumberTextBox.Text}");
                        Transaction.WriteLine($"{ItemCountLabel.Text}");

                        decimal OverallCost = 0;
                        foreach (string ItemsInCart in AddToCartListBox.Items)
                        {
                            string[] CartDetails = ItemsInCart.Split('-');
                            string Dress = CartDetails[0].Trim();
                            string Size = CartDetails[1].Trim();
                            int ItemCount = int.Parse(CartDetails[2].Trim());

                            decimal CostOfDress = DressRate[DressName.ToList().IndexOf(Dress), DressSize.ToList().IndexOf(Size)];
                            decimal CostOfOverallDress = CostOfDress * ItemCount;

                            OverallCost += CostOfOverallDress;

                            Transaction.WriteLine($"Item: {Dress} - {Size}, Count: {ItemCount}, Cost: {CostOfOverallDress}");

                            UpdateSalesReport(Sales, Dress, ItemCount, CostOfOverallDress);
                        }
                        Transaction.WriteLine($"{OverallCost}");
                    }
                    AddToCartListBox.Items.Clear();
                    UpdateStockLabels();
                    DisplayPanel.Visible = false;

                    FormReset();
                    MessageBox.Show("Your Order has been submitted successfully, Transaction Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    MessageBox.Show("Error in submitting the Order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormReset()
        {
            DressListBox.SelectedIndex = -1;
            DressSizeListBox.SelectedIndex = -1;
            DressCountNumericUpDown.Value = 0;
            CustomerNameTextBox.Text = string.Empty;
            PhoneNumberTextBox.Text = string.Empty;
            TransactionNumberLabel.Text = string.Empty;
            DateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
            StockPanel.Visible = false;
            DisplayPanel.Visible = false;
        }

        private void UpdateSalesReport(StreamWriter writer, string Dress, int ItemCount, decimal OverallCost)
        {
            try
            {
                string UpdateSalesReport = "SalesReport.txt";
                bool NewFile = !File.Exists(UpdateSalesReport);

                using (StreamWriter SalesReport = new StreamWriter(UpdateSalesReport, true))
                {
                    if (NewFile)
                    {
                        SalesReport.WriteLine("Item Name");
                        SalesReport.WriteLine("Item Count");
                        SalesReport.WriteLine("Item Cost");
                    }

                    SalesReport.WriteLine(Dress.Trim());
                    SalesReport.WriteLine(ItemCount);
                    SalesReport.WriteLine(OverallCost);
                }
            }
            catch
            {
                MessageBox.Show("Error updating sales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            BookingGroupBox.Visible = true;
            DateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
            TransactionNumberCounter();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            DialogResult result = reports.ShowDialog();

            if(result == DialogResult.Cancel)
            {
                reports.FormReset();
            }
        }
    }
}
