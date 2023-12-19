namespace EverydayWears
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DressListBox = new ListBox();
            DressNameLabel = new Label();
            DressSizeLabel = new Label();
            DressSizeListBox = new ListBox();
            StockAvailableLabel = new Label();
            AvailableStockLabel = new Label();
            CostLabel = new Label();
            DressCostLabel = new Label();
            DisplayButton = new Button();
            SubmitButton = new Button();
            AddToCartButton = new Button();
            BookButton = new Button();
            AddToCartListBox = new ListBox();
            DisplayPanel = new Panel();
            DressRateDisplayLabel = new Label();
            DisplayDressRateLabel = new Label();
            DisplayDressCountLabel = new Label();
            DisplayDressSizeLabel = new Label();
            DisplayDressLabel = new Label();
            DressSizeDisplayLabel = new Label();
            CountDisplayLabel = new Label();
            DressNameDisplayLabel = new Label();
            DateDisplayLabel = new Label();
            CustomerNameDisplayLabel = new Label();
            PhoneNumberDisplayLabel = new Label();
            DisplayPurchaseDateLabel = new Label();
            DressCountLabel = new Label();
            DressCountNumericUpDown = new NumericUpDown();
            TotalDressPurchasedLabel = new Label();
            BookingTotalDressPurchased = new Label();
            BookingTotalCostLabel = new Label();
            StockPanel = new Panel();
            BookingGroupBox = new GroupBox();
            OverallCostLabel = new Label();
            ItemCountLabel = new Label();
            PhoneNumberTextBox = new TextBox();
            CustomerNameTextBox = new TextBox();
            DateLabel = new Label();
            TransactionNumberLabel = new Label();
            TotalCostLabel = new Label();
            TotalItemsLabel = new Label();
            PhoneNumberLabel = new Label();
            DateOfTranscationLabel = new Label();
            CustomerNameLabel = new Label();
            BookingTransactionLabel = new Label();
            SummaryButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            SearchButton = new Button();
            panel1 = new Panel();
            DisplayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DressCountNumericUpDown).BeginInit();
            StockPanel.SuspendLayout();
            BookingGroupBox.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DressListBox
            // 
            DressListBox.FormattingEnabled = true;
            DressListBox.ItemHeight = 20;
            DressListBox.Items.AddRange(new object[] { "Jogger", "Jumper", "Shorts", "Tracks", "Shirts", "T-Shirts", "Hoodie", "OverCoat", "Skirt", "Leggings", "Jeans", "Pants", "NightWear", "Sweater", "TrenchCoat" });
            DressListBox.Location = new Point(37, 45);
            DressListBox.Name = "DressListBox";
            DressListBox.Size = new Size(171, 324);
            DressListBox.TabIndex = 0;
            // 
            // DressNameLabel
            // 
            DressNameLabel.AutoSize = true;
            DressNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DressNameLabel.Location = new Point(48, 22);
            DressNameLabel.Name = "DressNameLabel";
            DressNameLabel.Size = new Size(94, 20);
            DressNameLabel.TabIndex = 1;
            DressNameLabel.Text = "Dress Name";
            // 
            // DressSizeLabel
            // 
            DressSizeLabel.AutoSize = true;
            DressSizeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DressSizeLabel.Location = new Point(227, 22);
            DressSizeLabel.Name = "DressSizeLabel";
            DressSizeLabel.Size = new Size(79, 20);
            DressSizeLabel.TabIndex = 2;
            DressSizeLabel.Text = "Dress Size";
            // 
            // DressSizeListBox
            // 
            DressSizeListBox.FormattingEnabled = true;
            DressSizeListBox.ItemHeight = 20;
            DressSizeListBox.Items.AddRange(new object[] { "Extra Small", "Small", "Medium", "Large", "Extra Large" });
            DressSizeListBox.Location = new Point(218, 45);
            DressSizeListBox.Name = "DressSizeListBox";
            DressSizeListBox.Size = new Size(97, 104);
            DressSizeListBox.TabIndex = 3;
            DressSizeListBox.SelectedIndexChanged += DressSizeListBox_SelectedIndexChanged;
            // 
            // StockAvailableLabel
            // 
            StockAvailableLabel.AutoSize = true;
            StockAvailableLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            StockAvailableLabel.Location = new Point(17, 9);
            StockAvailableLabel.Name = "StockAvailableLabel";
            StockAvailableLabel.Size = new Size(123, 20);
            StockAvailableLabel.TabIndex = 4;
            StockAvailableLabel.Text = "Stock Available :";
            // 
            // AvailableStockLabel
            // 
            AvailableStockLabel.AutoSize = true;
            AvailableStockLabel.Location = new Point(158, 9);
            AvailableStockLabel.Name = "AvailableStockLabel";
            AvailableStockLabel.Size = new Size(17, 20);
            AvailableStockLabel.TabIndex = 5;
            AvailableStockLabel.Text = "0";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CostLabel.Location = new Point(92, 42);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(48, 20);
            CostLabel.TabIndex = 6;
            CostLabel.Text = "Cost :";
            // 
            // DressCostLabel
            // 
            DressCostLabel.AutoSize = true;
            DressCostLabel.Location = new Point(158, 42);
            DressCostLabel.Name = "DressCostLabel";
            DressCostLabel.Size = new Size(17, 20);
            DressCostLabel.TabIndex = 7;
            DressCostLabel.Text = "0";
            // 
            // DisplayButton
            // 
            DisplayButton.Location = new Point(18, 12);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(94, 29);
            DisplayButton.TabIndex = 8;
            DisplayButton.Text = "Display";
            DisplayButton.UseVisualStyleBackColor = true;
            DisplayButton.Click += DisplayButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(18, 115);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(94, 29);
            SubmitButton.TabIndex = 9;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Location = new Point(152, 12);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(94, 29);
            AddToCartButton.TabIndex = 10;
            AddToCartButton.Text = "Add to Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // BookButton
            // 
            BookButton.Location = new Point(18, 58);
            BookButton.Name = "BookButton";
            BookButton.Size = new Size(94, 29);
            BookButton.TabIndex = 11;
            BookButton.Text = "Book";
            BookButton.UseVisualStyleBackColor = true;
            BookButton.Click += BookButton_Click;
            // 
            // AddToCartListBox
            // 
            AddToCartListBox.FormattingEnabled = true;
            AddToCartListBox.ItemHeight = 20;
            AddToCartListBox.Location = new Point(614, 50);
            AddToCartListBox.Name = "AddToCartListBox";
            AddToCartListBox.Size = new Size(255, 284);
            AddToCartListBox.TabIndex = 12;
            // 
            // DisplayPanel
            // 
            DisplayPanel.Controls.Add(DressRateDisplayLabel);
            DisplayPanel.Controls.Add(DisplayDressRateLabel);
            DisplayPanel.Controls.Add(DisplayDressCountLabel);
            DisplayPanel.Controls.Add(DisplayDressSizeLabel);
            DisplayPanel.Controls.Add(DisplayDressLabel);
            DisplayPanel.Controls.Add(DressSizeDisplayLabel);
            DisplayPanel.Controls.Add(CountDisplayLabel);
            DisplayPanel.Controls.Add(DressNameDisplayLabel);
            DisplayPanel.Location = new Point(218, 187);
            DisplayPanel.Name = "DisplayPanel";
            DisplayPanel.Size = new Size(350, 147);
            DisplayPanel.TabIndex = 13;
            // 
            // DressRateDisplayLabel
            // 
            DressRateDisplayLabel.AutoSize = true;
            DressRateDisplayLabel.Location = new Point(145, 84);
            DressRateDisplayLabel.Name = "DressRateDisplayLabel";
            DressRateDisplayLabel.Size = new Size(79, 20);
            DressRateDisplayLabel.TabIndex = 20;
            DressRateDisplayLabel.Text = "Dress Rate";
            // 
            // DisplayDressRateLabel
            // 
            DisplayDressRateLabel.AutoSize = true;
            DisplayDressRateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DisplayDressRateLabel.Location = new Point(47, 84);
            DisplayDressRateLabel.Name = "DisplayDressRateLabel";
            DisplayDressRateLabel.Size = new Size(92, 20);
            DisplayDressRateLabel.TabIndex = 19;
            DisplayDressRateLabel.Text = "Dress Rate :";
            // 
            // DisplayDressCountLabel
            // 
            DisplayDressCountLabel.AutoSize = true;
            DisplayDressCountLabel.Location = new Point(145, 114);
            DisplayDressCountLabel.Name = "DisplayDressCountLabel";
            DisplayDressCountLabel.Size = new Size(88, 20);
            DisplayDressCountLabel.TabIndex = 18;
            DisplayDressCountLabel.Text = "Dress Count";
            // 
            // DisplayDressSizeLabel
            // 
            DisplayDressSizeLabel.AutoSize = true;
            DisplayDressSizeLabel.Location = new Point(145, 47);
            DisplayDressSizeLabel.Name = "DisplayDressSizeLabel";
            DisplayDressSizeLabel.Size = new Size(76, 20);
            DisplayDressSizeLabel.TabIndex = 17;
            DisplayDressSizeLabel.Text = "Dress Size";
            // 
            // DisplayDressLabel
            // 
            DisplayDressLabel.AutoSize = true;
            DisplayDressLabel.Location = new Point(145, 13);
            DisplayDressLabel.Name = "DisplayDressLabel";
            DisplayDressLabel.Size = new Size(89, 20);
            DisplayDressLabel.TabIndex = 16;
            DisplayDressLabel.Text = "Dress Name";
            // 
            // DressSizeDisplayLabel
            // 
            DressSizeDisplayLabel.AutoSize = true;
            DressSizeDisplayLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DressSizeDisplayLabel.Location = new Point(95, 47);
            DressSizeDisplayLabel.Name = "DressSizeDisplayLabel";
            DressSizeDisplayLabel.Size = new Size(44, 20);
            DressSizeDisplayLabel.TabIndex = 1;
            DressSizeDisplayLabel.Text = "Size :";
            // 
            // CountDisplayLabel
            // 
            CountDisplayLabel.AutoSize = true;
            CountDisplayLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CountDisplayLabel.Location = new Point(37, 114);
            CountDisplayLabel.Name = "CountDisplayLabel";
            CountDisplayLabel.Size = new Size(102, 20);
            CountDisplayLabel.TabIndex = 15;
            CountDisplayLabel.Text = "Dress Count :";
            // 
            // DressNameDisplayLabel
            // 
            DressNameDisplayLabel.AutoSize = true;
            DressNameDisplayLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DressNameDisplayLabel.Location = new Point(83, 13);
            DressNameDisplayLabel.Name = "DressNameDisplayLabel";
            DressNameDisplayLabel.Size = new Size(56, 20);
            DressNameDisplayLabel.TabIndex = 0;
            DressNameDisplayLabel.Text = "Dress :";
            // 
            // DateDisplayLabel
            // 
            DateDisplayLabel.AutoSize = true;
            DateDisplayLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DateDisplayLabel.Location = new Point(134, 112);
            DateDisplayLabel.Name = "DateDisplayLabel";
            DateDisplayLabel.Size = new Size(50, 20);
            DateDisplayLabel.TabIndex = 2;
            DateDisplayLabel.Text = "Date :";
            // 
            // CustomerNameDisplayLabel
            // 
            CustomerNameDisplayLabel.AutoSize = true;
            CustomerNameDisplayLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerNameDisplayLabel.Location = new Point(125, 73);
            CustomerNameDisplayLabel.Name = "CustomerNameDisplayLabel";
            CustomerNameDisplayLabel.Size = new Size(59, 20);
            CustomerNameDisplayLabel.TabIndex = 3;
            CustomerNameDisplayLabel.Text = "Name :";
            // 
            // PhoneNumberDisplayLabel
            // 
            PhoneNumberDisplayLabel.AutoSize = true;
            PhoneNumberDisplayLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneNumberDisplayLabel.Location = new Point(61, 147);
            PhoneNumberDisplayLabel.Name = "PhoneNumberDisplayLabel";
            PhoneNumberDisplayLabel.Size = new Size(123, 20);
            PhoneNumberDisplayLabel.TabIndex = 14;
            PhoneNumberDisplayLabel.Text = "Phone Number :";
            // 
            // DisplayPurchaseDateLabel
            // 
            DisplayPurchaseDateLabel.AutoSize = true;
            DisplayPurchaseDateLabel.Location = new Point(199, 112);
            DisplayPurchaseDateLabel.Name = "DisplayPurchaseDateLabel";
            DisplayPurchaseDateLabel.Size = new Size(115, 20);
            DisplayPurchaseDateLabel.TabIndex = 19;
            DisplayPurchaseDateLabel.Text = "DateOfPurchase";
            // 
            // DressCountLabel
            // 
            DressCountLabel.AutoSize = true;
            DressCountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DressCountLabel.Location = new Point(81, 82);
            DressCountLabel.Name = "DressCountLabel";
            DressCountLabel.Size = new Size(59, 20);
            DressCountLabel.TabIndex = 14;
            DressCountLabel.Text = "Count :";
            // 
            // DressCountNumericUpDown
            // 
            DressCountNumericUpDown.Location = new Point(158, 80);
            DressCountNumericUpDown.Name = "DressCountNumericUpDown";
            DressCountNumericUpDown.Size = new Size(56, 27);
            DressCountNumericUpDown.TabIndex = 16;
            DressCountNumericUpDown.ValueChanged += DressCountNumericUpDown_ValueChanged;
            // 
            // TotalDressPurchasedLabel
            // 
            TotalDressPurchasedLabel.AutoSize = true;
            TotalDressPurchasedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TotalDressPurchasedLabel.Location = new Point(13, 183);
            TotalDressPurchasedLabel.Name = "TotalDressPurchasedLabel";
            TotalDressPurchasedLabel.Size = new Size(171, 20);
            TotalDressPurchasedLabel.TabIndex = 26;
            TotalDressPurchasedLabel.Text = "Total Dress Purchased :";
            // 
            // BookingTotalDressPurchased
            // 
            BookingTotalDressPurchased.AutoSize = true;
            BookingTotalDressPurchased.Location = new Point(199, 183);
            BookingTotalDressPurchased.Name = "BookingTotalDressPurchased";
            BookingTotalDressPurchased.Size = new Size(153, 20);
            BookingTotalDressPurchased.TabIndex = 27;
            BookingTotalDressPurchased.Text = "Total Dress Purchased";
            // 
            // BookingTotalCostLabel
            // 
            BookingTotalCostLabel.AutoSize = true;
            BookingTotalCostLabel.Location = new Point(199, 221);
            BookingTotalCostLabel.Name = "BookingTotalCostLabel";
            BookingTotalCostLabel.Size = new Size(108, 20);
            BookingTotalCostLabel.TabIndex = 29;
            BookingTotalCostLabel.Text = "Billing Amount";
            // 
            // StockPanel
            // 
            StockPanel.Controls.Add(DressCountNumericUpDown);
            StockPanel.Controls.Add(DressCountLabel);
            StockPanel.Controls.Add(DressCostLabel);
            StockPanel.Controls.Add(CostLabel);
            StockPanel.Controls.Add(AvailableStockLabel);
            StockPanel.Controls.Add(StockAvailableLabel);
            StockPanel.Location = new Point(331, 42);
            StockPanel.Name = "StockPanel";
            StockPanel.Size = new Size(237, 119);
            StockPanel.TabIndex = 17;
            // 
            // BookingGroupBox
            // 
            BookingGroupBox.Controls.Add(OverallCostLabel);
            BookingGroupBox.Controls.Add(ItemCountLabel);
            BookingGroupBox.Controls.Add(PhoneNumberTextBox);
            BookingGroupBox.Controls.Add(CustomerNameTextBox);
            BookingGroupBox.Controls.Add(DateLabel);
            BookingGroupBox.Controls.Add(TransactionNumberLabel);
            BookingGroupBox.Controls.Add(TotalCostLabel);
            BookingGroupBox.Controls.Add(TotalItemsLabel);
            BookingGroupBox.Controls.Add(PhoneNumberLabel);
            BookingGroupBox.Controls.Add(DateOfTranscationLabel);
            BookingGroupBox.Controls.Add(CustomerNameLabel);
            BookingGroupBox.Controls.Add(BookingTransactionLabel);
            BookingGroupBox.Location = new Point(220, 350);
            BookingGroupBox.Name = "BookingGroupBox";
            BookingGroupBox.Size = new Size(492, 305);
            BookingGroupBox.TabIndex = 18;
            BookingGroupBox.TabStop = false;
            BookingGroupBox.Text = "Booking Group Box";
            // 
            // OverallCostLabel
            // 
            OverallCostLabel.AutoSize = true;
            OverallCostLabel.Location = new Point(192, 246);
            OverallCostLabel.Name = "OverallCostLabel";
            OverallCostLabel.Size = new Size(89, 20);
            OverallCostLabel.TabIndex = 11;
            OverallCostLabel.Text = "Overall Cost";
            // 
            // ItemCountLabel
            // 
            ItemCountLabel.AutoSize = true;
            ItemCountLabel.Location = new Point(192, 201);
            ItemCountLabel.Name = "ItemCountLabel";
            ItemCountLabel.Size = new Size(82, 20);
            ItemCountLabel.TabIndex = 10;
            ItemCountLabel.Text = "Item Count";
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(192, 160);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(125, 27);
            PhoneNumberTextBox.TabIndex = 9;
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Location = new Point(192, 79);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(125, 27);
            CustomerNameTextBox.TabIndex = 8;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(192, 119);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(41, 20);
            DateLabel.TabIndex = 7;
            DateLabel.Text = "Date";
            // 
            // TransactionNumberLabel
            // 
            TransactionNumberLabel.AutoSize = true;
            TransactionNumberLabel.Location = new Point(192, 36);
            TransactionNumberLabel.Name = "TransactionNumberLabel";
            TransactionNumberLabel.Size = new Size(88, 20);
            TransactionNumberLabel.TabIndex = 6;
            TransactionNumberLabel.Text = "Transaction ";
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TotalCostLabel.Location = new Point(91, 246);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(87, 20);
            TotalCostLabel.TabIndex = 5;
            TotalCostLabel.Text = "Total Cost :";
            // 
            // TotalItemsLabel
            // 
            TotalItemsLabel.AutoSize = true;
            TotalItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TotalItemsLabel.Location = new Point(82, 201);
            TotalItemsLabel.Name = "TotalItemsLabel";
            TotalItemsLabel.Size = new Size(96, 20);
            TotalItemsLabel.TabIndex = 4;
            TotalItemsLabel.Text = "Total Items :";
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneNumberLabel.Location = new Point(55, 160);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(123, 20);
            PhoneNumberLabel.TabIndex = 3;
            PhoneNumberLabel.Text = "Phone Number :";
            // 
            // DateOfTranscationLabel
            // 
            DateOfTranscationLabel.AutoSize = true;
            DateOfTranscationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DateOfTranscationLabel.Location = new Point(24, 119);
            DateOfTranscationLabel.Name = "DateOfTranscationLabel";
            DateOfTranscationLabel.Size = new Size(154, 20);
            DateOfTranscationLabel.TabIndex = 2;
            DateOfTranscationLabel.Text = "Date of Transaction :";
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerNameLabel.Location = new Point(47, 79);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(131, 20);
            CustomerNameLabel.TabIndex = 1;
            CustomerNameLabel.Text = "Customer Name :";
            // 
            // BookingTransactionLabel
            // 
            BookingTransactionLabel.AutoSize = true;
            BookingTransactionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BookingTransactionLabel.Location = new Point(18, 36);
            BookingTransactionLabel.Name = "BookingTransactionLabel";
            BookingTransactionLabel.Size = new Size(160, 20);
            BookingTransactionLabel.TabIndex = 0;
            BookingTransactionLabel.Text = "Transaction Number :";
            // 
            // SummaryButton
            // 
            SummaryButton.Location = new Point(152, 115);
            SummaryButton.Name = "SummaryButton";
            SummaryButton.Size = new Size(94, 29);
            SummaryButton.TabIndex = 19;
            SummaryButton.Text = "Summary";
            SummaryButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(152, 58);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 29);
            ClearButton.TabIndex = 20;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(152, 173);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 21;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(18, 173);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 22;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(ExitButton);
            panel1.Controls.Add(ClearButton);
            panel1.Controls.Add(SummaryButton);
            panel1.Controls.Add(BookButton);
            panel1.Controls.Add(AddToCartButton);
            panel1.Controls.Add(SubmitButton);
            panel1.Controls.Add(DisplayButton);
            panel1.Location = new Point(747, 355);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 216);
            panel1.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 704);
            Controls.Add(panel1);
            Controls.Add(BookingGroupBox);
            Controls.Add(StockPanel);
            Controls.Add(DisplayPanel);
            Controls.Add(AddToCartListBox);
            Controls.Add(DressSizeListBox);
            Controls.Add(DressSizeLabel);
            Controls.Add(DressNameLabel);
            Controls.Add(DressListBox);
            Name = "Form1";
            Text = "Form1";
            DisplayPanel.ResumeLayout(false);
            DisplayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DressCountNumericUpDown).EndInit();
            StockPanel.ResumeLayout(false);
            StockPanel.PerformLayout();
            BookingGroupBox.ResumeLayout(false);
            BookingGroupBox.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox DressListBox;
        private Label DressNameLabel;
        private Label DressSizeLabel;
        private ListBox DressSizeListBox;
        private Label StockAvailableLabel;
        private Label AvailableStockLabel;
        private Label CostLabel;
        private Label DressCostLabel;
        private Button DisplayButton;
        private Button SubmitButton;
        private Button AddToCartButton;
        private Button BookButton;
        private ListBox AddToCartListBox;
        private Panel DisplayPanel;
        private Label DressSizeDisplayLabel;
        private Label DressNameDisplayLabel;
        private Label CountDisplayLabel;
        private Label PhoneNumberDisplayLabel;
        private Label CustomerNameDisplayLabel;
        private Label DateDisplayLabel;
        private Label DisplayPhoneNumberLabel;
        private Label DisplayPurchaseDateLabel;
        private Label DisplayCustomerNameLabel;
        private Label DisplayDressCountLabel;
        private Label DisplayDressSizeLabel;
        private Label DisplayDressLabel;
        private Label DressCountLabel;
        private NumericUpDown DressCountNumericUpDown;
        private Label DressRateDisplayLabel;
        private Label DisplayDressRateLabel;
        private Label TotalDressPurchasedLabel;
        private Label BookingTransactionNumberLabel;
        private Label BookingTotalCostLabel;
        private Label BookingTotalDressPurchased;
        private Panel StockPanel;
        private GroupBox BookingGroupBox;
        private Label BookingTransactionLabel;
        private Label TotalItemsLabel;
        private Label PhoneNumberLabel;
        private Label DateOfTranscationLabel;
        private Label CustomerNameLabel;
        private Label TotalCostLabel;
        private Button SummaryButton;
        private Button ClearButton;
        private Button ExitButton;
        private Label TransactionNumberLabel;
        private Label DateLabel;
        private TextBox CustomerNameTextBox;
        private Label OverallCostLabel;
        private Label ItemCountLabel;
        private TextBox PhoneNumberTextBox;
        private Button SearchButton;
        private Panel panel1;
    }
}