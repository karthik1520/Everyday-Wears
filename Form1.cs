/* Name: Karthik Mahadevan Ramesh Kumar
 * Student ID: 23101941
 * Subject Code: MS806
 * Assignmnet Description: TO create an EPOS system for retial business to process sales, record it, manage inventory and provide reports
 * The EPOS system developed is the EverydyWears System which is used to manage daily wear clothes.
 */

using System.Windows.Forms.VisualStyles;

namespace EverydayWears
{
    public partial class Form1 : Form
    {

        // Decleration of global variables which are the arrays
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

        public Form1()
        {
            InitializeComponent();

        }


        // Actions to perform on loading the form
        private void Form1_Load(object sender, EventArgs e)
        {
            // Read stock from file on load of form
            ReadInitialStockFromFile("InitialStocks.txt");
            StockPanel.Visible = false;
            // Initialize DisplayPanel visibility
            DisplayPanel.Visible = false;
            BookingGroupBox.Visible = false;
            AddToCartButton.Enabled = false;
            BookButton.Enabled = false;
            SubmitButton.Enabled = false;
            ClearButton.Enabled = true;
            AddToCartListBox.Visible = false;
            CartItemsLabel.Visible = false;
            StockLeftListBox.Visible = false;
            StockLeftLabel.Visible = false;
        }


        // Updating the stock labels to display in the stock panel on selecting the values in the dress name and size listbox
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

        // dynamic update of stock labels
        private void DressListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStockLabels();
        }

        // dynamic update of stock labels
        private void DressSizeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStockLabels();
        }


        // Actions to be performed onclick of the add to cart button. 
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            AddToCartListBox.Visible = true;
            CartItemsLabel.Visible = true;
            BookButton.Enabled = true;
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

        // Reading stocks intitally from the file called initialstock so that on display the values are displayed from the file
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

        // Updating the current stock file with the records initially
        private void UpdateStockFile(string InitialStockFile, string StockLeftFileName)
        {
            try
            {
                List<string> UpdateInitialStocks = new List<string>();
                List<string> UpdateStocksLeft = new List<string>();

                for (int i = 0; i < DressName.Length; i++)
                {
                    string[] ValuesStock = new string[DressSize.Length];

                    for (int j = 0; j < DressSize.Length; j++)
                    {
                        ValuesStock[j] = DressStockAvailable[i, j].ToString();
                    }

                    UpdateInitialStocks.Add(string.Join(",", ValuesStock));
                }

                File.WriteAllLines(InitialStockFile, UpdateInitialStocks);

                int[,] StockLeftNew = new int[DressName.Length, DressSize.Length];
                if (File.Exists(StockLeftFileName))
                {
                    string[] Lines = File.ReadAllLines(StockLeftFileName);
                    for (int i = 0; i < DressName.Length; i++)
                    {
                        string[] ValuesInFile = Lines[i].Split(',');
                        for (int j = 0; j < DressSize.Length; j++)
                        {
                            if (int.TryParse(ValuesInFile[j], out int StocksLeftUpdate))
                            {
                                StockLeftNew[i, j] = StocksLeftUpdate;
                            }
                        }
                    }
                }
                for (int i = 0; i < DressName.Length; i++)
                {
                    for (int j = 0; j < DressSize.Length; j++)
                    {
                        StockLeftNew[i, j] -= DressStockAvailable[i, j];
                    }
                }
                for (int i = 0; i < DressName.Length; i++)
                {
                    string[] FileValues = new string[DressSize.Length];
                    for (int j = 0; j < DressSize.Length; j++)
                    {
                        FileValues[j] = StockLeftNew[i, j].ToString();
                    }
                    UpdateStocksLeft.Add(string.Join(",", FileValues));
                }
                File.WriteAllLines(StockLeftFileName, UpdateStocksLeft);

                MessageBox.Show("Stock updated successfully in the file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show($"Error updating stock file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Updating the stocks after every transaction in the stockleft file.
        private void UpdateNewStockRecords(string InitialStockFile, string StockLeftFileName)
        {
            try
            {
                string StockLeft = "StockLeft.txt";
                int[,] StockLeftNew = new int[DressName.Length, DressSize.Length];
                if (File.Exists(StockLeft))
                {
                    string[] Lines = File.ReadAllLines(StockLeft);
                    for (int i = 0; i < DressName.Length; i++)
                    {
                        string[] ValuesInFile = Lines[i].Split(',');
                        for (int j = 0; j < DressSize.Length; j++)
                        {
                            if (int.TryParse(ValuesInFile[j], out int StocksLeftUpdate))
                            {
                                StockLeftNew[i, j] = StocksLeftUpdate;
                            }
                        }
                    }
                }
                for (int i = 0; i < DressName.Length; i++)
                {
                    for (int j = 0; j < DressSize.Length; j++)
                    {
                        StockLeftNew[i, j] -= DressStockAvailable[i, j];
                    }
                }
                List<string> Update = new List<string>();
                for (int i = 0; i < DressName.Length; i++)
                {
                    string[] FileValues = new string[DressSize.Length];
                    for (int j = 0; j < DressSize.Length; j++)
                    {
                        FileValues[j] = StockLeftNew[i, j].ToString();
                    }
                    Update.Add(string.Join(",", FileValues));
                }
                File.WriteAllLines(StockLeft, Update);
                UpdateStockFile(InitialStockFile, StockLeftFileName);
            }
            catch
            {
                MessageBox.Show("Error updating File to store stock left", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Numberic counter to change the stocks left based on increase or decrease of the counter
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
        
        // Actions performed on click of display button to display the values based on the cart details
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            AddToCartButton.Enabled = true;
            ClearButton.Enabled = true;
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
                AddToCartButton.Enabled = false;
                ClearButton.Enabled = false;
                MessageBox.Show("Kindly select a Dress and Size appropriately", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Actions performed onclick of submit button.
        // the customer name and the phone number are validated and errors are thrown for user to identify where the error has occured
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string CustomerName = CustomerNameTextBox.Text.Trim();
            if(!ValidCustomerName(CustomerName))
            {
                MessageBox.Show("Invalid Customer Name. Please check your Name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string CustomerPhoneNumber = PhoneNumberTextBox.Text.Trim();
            if(!ValidCustomerPhoneNumber(CustomerPhoneNumber))
            {
                MessageBox.Show("Invalid Phone Number. Please Check Again","Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Do you want to submit the order?", "Confirmation", MessageBoxButtons.YesNo);

            // Actions performed onclick of yes in the submit button. Writes the transaction records to the transaction.txt file
            if (result == DialogResult.Yes)
            {   
                AddToCartButton.Enabled = false;
                BookButton.Enabled = false;
                BookingGroupBox.Visible = false;
                AddToCartListBox.Visible = false;
                UpdateNewStockRecords("InitialStocks.txt","Stockleft.txt");
                string TransactionFile = "Transaction.txt";
                try
                {
                    using (StreamWriter Transaction = new StreamWriter(TransactionFile, true))
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

                            Transaction.WriteLine($"{Dress}");
                            Transaction.WriteLine($"{Size}");
                            Transaction.WriteLine($"{CostOfOverallDress}");
                        }
                        Transaction.WriteLine($"{OverallCost}");
                    }
                    AddToCartListBox.Items.Clear();
                    UpdateStockLabels();
                    DisplayPanel.Visible = false;
                    MessageBox.Show("Your Order has been submitted successfully, Transaction Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearButton_Click(sender, e);
                }
                catch
                {
                    MessageBox.Show("Error in submitting the Order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Customer Name Validation
        private bool ValidCustomerName(string CustomerName)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(CustomerName, @"^[a-zA-Z,.\s]+$");
        }

        // Customer Phone Number Validation
        private bool ValidCustomerPhoneNumber(string CustomerPhoneNumber)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(CustomerPhoneNumber, @"^\+?\d{1,11}$"); 
        }


        // Actions Performed on click of Book Button.retrieves items from the cart and displays in the groupbox
        private void BookButton_Click(object sender, EventArgs e)
        {
            SubmitButton.Enabled = true;
            BookingGroupBox.Visible = true;
            DateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");

            int TransactionNumber = new Random().Next(1,9999999);
            TransactionNumberLabel.Text = TransactionNumber.ToString();

            int CountOfItem = 0;
            decimal CostOfItemsOverall = 0;

            foreach (string ItemsInCart in AddToCartListBox.Items)
            {
                string[] DetailsOfCart = ItemsInCart.Split('-');
                int Count = int.Parse(DetailsOfCart[2].Trim());
                decimal DressCost = DressRate[DressName.ToList().IndexOf(DetailsOfCart[0].Trim()), DressSize.ToList().IndexOf
                    (DetailsOfCart[1].Trim())];
                CostOfItemsOverall += DressCost * Count;
                CountOfItem += Count;
            }
            ItemCountLabel.Text = CountOfItem.ToString();
            OverallCostLabel.Text = CostOfItemsOverall.ToString();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Opening a new form by initializing it and showing actions for summary, search.
        private void ReportsButton_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            DialogResult result = reports.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                reports.FormReset();
            }
        }


        // Clear the form completely on click of clear button. Reset the state of the form
        private void ClearButton_Click(object sender, EventArgs e)
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
            CartItemsLabel.Visible = false;
            AddToCartListBox.Visible = false;
            StockLeftListBox.Visible = false;
            StockLeftLabel.Visible = false;

        }

        // Displaying stocks left by retrieving the record from stockleft file.
        private void StockLeft(string StockLeftFileName)
        {
            try
            {
                StockLeftListBox.Items.Clear();
                if (File.Exists(StockLeftFileName))
                {
                    string[] FileValues = File.ReadAllLines(StockLeftFileName);
                    for (int i = 0; i < DressName.Length; i++)
                    {
                        string[] Contents = FileValues[i].Split(',');
                        for (int j = 0; j < DressSize.Length; j++)
                        {
                            int StocksRemainingToBeSold;
                            if (int.TryParse(Contents[j], out StocksRemainingToBeSold))
                            {
                                string OutputDisplay = $"Dress Name: {DressName[i]} - Dress Size: {DressSize[i]} - Stock Left: {StocksRemainingToBeSold}";
                                StockLeftListBox.Items.Add(OutputDisplay);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("File Not Found", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Stocks in File cannot be fetched", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Actions performed onclick of stockleftbutton. Calls the stockleft method
        private void StocksLeftButton_Click(object sender, EventArgs e)
        {
            StockLeftListBox.Visible = true;
            StockLeftLabel.Visible = true;
            StockLeft("StockLeft.txt");
        }
    }
}
