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
            BookingTransactionNumberLabel = new Label();
            TotalDressPurchasedLabel = new Label();
            BookingTotalDressPurchased = new Label();
            TotalCostLabel = new Label();
            BookingTotalCostLabel = new Label();
            StockPanel = new Panel();
            DisplayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DressCountNumericUpDown).BeginInit();
            StockPanel.SuspendLayout();
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
            DisplayButton.Location = new Point(597, 45);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(94, 29);
            DisplayButton.TabIndex = 8;
            DisplayButton.Text = "Display";
            DisplayButton.UseVisualStyleBackColor = true;
            DisplayButton.Click += DisplayButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(597, 215);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(94, 29);
            SubmitButton.TabIndex = 9;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Location = new Point(597, 104);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(94, 29);
            AddToCartButton.TabIndex = 10;
            AddToCartButton.Text = "Add to Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // BookButton
            // 
            BookButton.Location = new Point(597, 163);
            BookButton.Name = "BookButton";
            BookButton.Size = new Size(94, 29);
            BookButton.TabIndex = 11;
            BookButton.Text = "Book";
            BookButton.UseVisualStyleBackColor = true;
            // 
            // AddToCartListBox
            // 
            AddToCartListBox.FormattingEnabled = true;
            AddToCartListBox.ItemHeight = 20;
            AddToCartListBox.Location = new Point(713, 45);
            AddToCartListBox.Name = "AddToCartListBox";
            AddToCartListBox.Size = new Size(254, 224);
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
            // BookingTransactionNumberLabel
            // 
            BookingTransactionNumberLabel.AutoSize = true;
            BookingTransactionNumberLabel.Location = new Point(199, 33);
            BookingTransactionNumberLabel.Name = "BookingTransactionNumberLabel";
            BookingTransactionNumberLabel.Size = new Size(142, 20);
            BookingTransactionNumberLabel.TabIndex = 25;
            BookingTransactionNumberLabel.Text = "Transaction Number";
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
            // TotalCostLabel
            // 
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TotalCostLabel.Location = new Point(97, 221);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(87, 20);
            TotalCostLabel.TabIndex = 28;
            TotalCostLabel.Text = "Total Cost :";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 704);
            Controls.Add(StockPanel);
            Controls.Add(DisplayPanel);
            Controls.Add(AddToCartListBox);
            Controls.Add(BookButton);
            Controls.Add(AddToCartButton);
            Controls.Add(SubmitButton);
            Controls.Add(DisplayButton);
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
        private Label TotalCostLabel;
        private Label BookingTotalDressPurchased;
        private Panel StockPanel;
    }
}