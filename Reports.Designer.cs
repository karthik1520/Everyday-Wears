namespace EverydayWears
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DressTypeComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            DressSizeComboBox = new ComboBox();
            SearchEngineGroupBox = new GroupBox();
            DateOfTransactionSearchTextBox = new TextBox();
            CustomerNameSearchTextBox = new TextBox();
            TransactionNumberSearchTextBox = new TextBox();
            DateOfTransactionRadioButton = new RadioButton();
            CustomerNameRadioButton = new RadioButton();
            TransactionNumberRadioButton = new RadioButton();
            SearchAndSummaryResultListBox = new ListBox();
            CloseButton = new Button();
            SearchEngineGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // DressTypeComboBox
            // 
            DressTypeComboBox.FormattingEnabled = true;
            DressTypeComboBox.Items.AddRange(new object[] { "Jogger", "Jumper", "Shorts", "Tracks", "Shirts", "T-Shirts", "Hoodie", "OverCoat", "Skirt", "Leggings", "Jeans", "Pants", "NightWear", "Sweater", "TrenchCoat" });
            DressTypeComboBox.Location = new Point(126, 43);
            DressTypeComboBox.Name = "DressTypeComboBox";
            DressTypeComboBox.Size = new Size(167, 28);
            DressTypeComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 1;
            label1.Text = "Dress Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Dress Size";
            // 
            // DressSizeComboBox
            // 
            DressSizeComboBox.FormattingEnabled = true;
            DressSizeComboBox.Items.AddRange(new object[] { "Extra Small", "Small", "Medium", "Large", "Extra Large" });
            DressSizeComboBox.Location = new Point(126, 98);
            DressSizeComboBox.Name = "DressSizeComboBox";
            DressSizeComboBox.Size = new Size(167, 28);
            DressSizeComboBox.TabIndex = 3;
            // 
            // SearchEngineGroupBox
            // 
            SearchEngineGroupBox.Controls.Add(DateOfTransactionSearchTextBox);
            SearchEngineGroupBox.Controls.Add(CustomerNameSearchTextBox);
            SearchEngineGroupBox.Controls.Add(TransactionNumberSearchTextBox);
            SearchEngineGroupBox.Controls.Add(DateOfTransactionRadioButton);
            SearchEngineGroupBox.Controls.Add(CustomerNameRadioButton);
            SearchEngineGroupBox.Controls.Add(TransactionNumberRadioButton);
            SearchEngineGroupBox.Location = new Point(325, 43);
            SearchEngineGroupBox.Name = "SearchEngineGroupBox";
            SearchEngineGroupBox.Size = new Size(481, 176);
            SearchEngineGroupBox.TabIndex = 4;
            SearchEngineGroupBox.TabStop = false;
            SearchEngineGroupBox.Text = "Search Engine";
            // 
            // DateOfTransactionSearchTextBox
            // 
            DateOfTransactionSearchTextBox.Location = new Point(256, 129);
            DateOfTransactionSearchTextBox.Name = "DateOfTransactionSearchTextBox";
            DateOfTransactionSearchTextBox.Size = new Size(201, 27);
            DateOfTransactionSearchTextBox.TabIndex = 5;
            // 
            // CustomerNameSearchTextBox
            // 
            CustomerNameSearchTextBox.Location = new Point(256, 83);
            CustomerNameSearchTextBox.Name = "CustomerNameSearchTextBox";
            CustomerNameSearchTextBox.Size = new Size(201, 27);
            CustomerNameSearchTextBox.TabIndex = 4;
            // 
            // TransactionNumberSearchTextBox
            // 
            TransactionNumberSearchTextBox.Location = new Point(256, 38);
            TransactionNumberSearchTextBox.Name = "TransactionNumberSearchTextBox";
            TransactionNumberSearchTextBox.Size = new Size(201, 27);
            TransactionNumberSearchTextBox.TabIndex = 3;
            // 
            // DateOfTransactionRadioButton
            // 
            DateOfTransactionRadioButton.AutoSize = true;
            DateOfTransactionRadioButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DateOfTransactionRadioButton.Location = new Point(6, 132);
            DateOfTransactionRadioButton.Name = "DateOfTransactionRadioButton";
            DateOfTransactionRadioButton.Size = new Size(169, 24);
            DateOfTransactionRadioButton.TabIndex = 2;
            DateOfTransactionRadioButton.TabStop = true;
            DateOfTransactionRadioButton.Text = "Date Of Transaction";
            DateOfTransactionRadioButton.UseVisualStyleBackColor = true;
            // 
            // CustomerNameRadioButton
            // 
            CustomerNameRadioButton.AutoSize = true;
            CustomerNameRadioButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerNameRadioButton.Location = new Point(6, 86);
            CustomerNameRadioButton.Name = "CustomerNameRadioButton";
            CustomerNameRadioButton.Size = new Size(144, 24);
            CustomerNameRadioButton.TabIndex = 1;
            CustomerNameRadioButton.TabStop = true;
            CustomerNameRadioButton.Text = "Customer Name";
            CustomerNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // TransactionNumberRadioButton
            // 
            TransactionNumberRadioButton.AutoSize = true;
            TransactionNumberRadioButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TransactionNumberRadioButton.Location = new Point(6, 41);
            TransactionNumberRadioButton.Name = "TransactionNumberRadioButton";
            TransactionNumberRadioButton.Size = new Size(173, 24);
            TransactionNumberRadioButton.TabIndex = 0;
            TransactionNumberRadioButton.TabStop = true;
            TransactionNumberRadioButton.Text = "Transaction Number";
            TransactionNumberRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchAndSummaryResultListBox
            // 
            SearchAndSummaryResultListBox.BackColor = SystemColors.Control;
            SearchAndSummaryResultListBox.FormattingEnabled = true;
            SearchAndSummaryResultListBox.ItemHeight = 20;
            SearchAndSummaryResultListBox.Location = new Point(33, 234);
            SearchAndSummaryResultListBox.Name = "SearchAndSummaryResultListBox";
            SearchAndSummaryResultListBox.ScrollAlwaysVisible = true;
            SearchAndSummaryResultListBox.Size = new Size(943, 304);
            SearchAndSummaryResultListBox.TabIndex = 5;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(857, 568);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(94, 29);
            CloseButton.TabIndex = 6;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 609);
            Controls.Add(CloseButton);
            Controls.Add(SearchAndSummaryResultListBox);
            Controls.Add(SearchEngineGroupBox);
            Controls.Add(DressSizeComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DressTypeComboBox);
            Name = "Reports";
            Text = "Reports";
            SearchEngineGroupBox.ResumeLayout(false);
            SearchEngineGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox DressTypeComboBox;
        private Label label1;
        private Label label2;
        private ComboBox DressSizeComboBox;
        private GroupBox SearchEngineGroupBox;
        private RadioButton CustomerNameRadioButton;
        private RadioButton TransactionNumberRadioButton;
        private RadioButton DateOfTransactionRadioButton;
        private TextBox DateOfTransactionSearchTextBox;
        private TextBox CustomerNameSearchTextBox;
        private TextBox TransactionNumberSearchTextBox;
        private ListBox SearchAndSummaryResultListBox;
        private Button CloseButton;
    }
}