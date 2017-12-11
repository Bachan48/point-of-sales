namespace POS_CourseWorkBachanGhimire
{
    partial class POSForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.recordsTab = new System.Windows.Forms.TabPage();
            this.sort = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.sortBy = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.RecordsGridView = new System.Windows.Forms.DataGridView();
            this.ItemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportsTab = new System.Windows.Forms.TabPage();
            this.SalesGridView = new System.Windows.Forms.DataGridView();
            this.SalesNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesCategoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.fileLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.billingName = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.billingQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addToSalesButton = new System.Windows.Forms.Button();
            this.billingCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.recordsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsGridView)).BeginInit();
            this.reportsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReport)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.recordsTab);
            this.tabControl.Controls.Add(this.reportsTab);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(572, 1);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(861, 1012);
            this.tabControl.TabIndex = 0;
            // 
            // recordsTab
            // 
            this.recordsTab.BackColor = System.Drawing.Color.AliceBlue;
            this.recordsTab.Controls.Add(this.sort);
            this.recordsTab.Controls.Add(this.deleteButton);
            this.recordsTab.Controls.Add(this.sortBy);
            this.recordsTab.Controls.Add(this.label14);
            this.recordsTab.Controls.Add(this.RecordsGridView);
            this.recordsTab.Location = new System.Drawing.Point(8, 51);
            this.recordsTab.Margin = new System.Windows.Forms.Padding(4);
            this.recordsTab.Name = "recordsTab";
            this.recordsTab.Padding = new System.Windows.Forms.Padding(4);
            this.recordsTab.Size = new System.Drawing.Size(845, 953);
            this.recordsTab.TabIndex = 0;
            this.recordsTab.Text = "Item Records";
            // 
            // sort
            // 
            this.sort.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sort.Location = new System.Drawing.Point(377, 853);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(222, 53);
            this.sort.TabIndex = 26;
            this.sort.Text = "Sort\r\n";
            this.sort.UseVisualStyleBackColor = false;
            this.sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(617, 853);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(228, 53);
            this.deleteButton.TabIndex = 24;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // sortBy
            // 
            this.sortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortBy.FormattingEnabled = true;
            this.sortBy.Items.AddRange(new object[] {
            "Name",
            "Price"});
            this.sortBy.Location = new System.Drawing.Point(143, 858);
            this.sortBy.Name = "sortBy";
            this.sortBy.Size = new System.Drawing.Size(209, 45);
            this.sortBy.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 861);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 37);
            this.label14.TabIndex = 25;
            this.label14.Text = "Sort By";
            // 
            // RecordsGridView
            // 
            this.RecordsGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RecordsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNameColumn,
            this.CategoryColumn,
            this.ItemPriceColumn});
            this.RecordsGridView.Location = new System.Drawing.Point(4, 5);
            this.RecordsGridView.Name = "RecordsGridView";
            this.RecordsGridView.RowTemplate.Height = 33;
            this.RecordsGridView.Size = new System.Drawing.Size(838, 827);
            this.RecordsGridView.TabIndex = 0;
            // 
            // ItemNameColumn
            // 
            this.ItemNameColumn.HeaderText = "Item Name";
            this.ItemNameColumn.Name = "ItemNameColumn";
            this.ItemNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ItemNameColumn.Width = 175;
            // 
            // CategoryColumn
            // 
            this.CategoryColumn.HeaderText = "Category";
            this.CategoryColumn.Name = "CategoryColumn";
            this.CategoryColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ItemPriceColumn
            // 
            this.ItemPriceColumn.HeaderText = "Price";
            this.ItemPriceColumn.Name = "ItemPriceColumn";
            this.ItemPriceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemPriceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // reportsTab
            // 
            this.reportsTab.BackColor = System.Drawing.Color.LightSteelBlue;
            this.reportsTab.Controls.Add(this.SalesGridView);
            this.reportsTab.Controls.Add(this.SalesReport);
            this.reportsTab.Location = new System.Drawing.Point(8, 51);
            this.reportsTab.Margin = new System.Windows.Forms.Padding(4);
            this.reportsTab.Name = "reportsTab";
            this.reportsTab.Padding = new System.Windows.Forms.Padding(4);
            this.reportsTab.Size = new System.Drawing.Size(845, 953);
            this.reportsTab.TabIndex = 1;
            this.reportsTab.Text = "Sales Report";
            // 
            // SalesGridView
            // 
            this.SalesGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SalesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesNameColumn,
            this.SalesCategoryColumn,
            this.SalesPriceColumn});
            this.SalesGridView.Location = new System.Drawing.Point(4, 6);
            this.SalesGridView.Name = "SalesGridView";
            this.SalesGridView.RowTemplate.Height = 33;
            this.SalesGridView.Size = new System.Drawing.Size(841, 427);
            this.SalesGridView.TabIndex = 1;
            // 
            // SalesNameColumn
            // 
            this.SalesNameColumn.HeaderText = "Sold Item";
            this.SalesNameColumn.Name = "SalesNameColumn";
            this.SalesNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.SalesNameColumn.Width = 175;
            // 
            // SalesCategoryColumn
            // 
            this.SalesCategoryColumn.HeaderText = "Category";
            this.SalesCategoryColumn.Name = "SalesCategoryColumn";
            this.SalesCategoryColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // SalesPriceColumn
            // 
            this.SalesPriceColumn.HeaderText = "Price";
            this.SalesPriceColumn.Name = "SalesPriceColumn";
            this.SalesPriceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesPriceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // SalesReport
            // 
            chartArea2.Name = "ChartArea1";
            this.SalesReport.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.SalesReport.Legends.Add(legend2);
            this.SalesReport.Location = new System.Drawing.Point(0, 432);
            this.SalesReport.Name = "SalesReport";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.SalesReport.Series.Add(series2);
            this.SalesReport.Size = new System.Drawing.Size(845, 521);
            this.SalesReport.TabIndex = 0;
            this.SalesReport.Text = "Sales Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add an item to Record";
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel.Location = new System.Drawing.Point(36, 78);
            this.itemLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(173, 37);
            this.itemLabel.TabIndex = 2;
            this.itemLabel.Text = "Item Name";
            // 
            // itemName
            // 
            this.itemName.Location = new System.Drawing.Point(286, 84);
            this.itemName.Margin = new System.Windows.Forms.Padding(4);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(247, 31);
            this.itemName.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addButton.Location = new System.Drawing.Point(289, 240);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(244, 51);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Item Category";
            // 
            // category
            // 
            this.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Drinks",
            "Breakfast",
            "Meal",
            "Snacks"});
            this.category.Location = new System.Drawing.Point(286, 136);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(247, 33);
            this.category.TabIndex = 7;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(286, 189);
            this.price.Margin = new System.Windows.Forms.Padding(4);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(247, 31);
            this.price.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Item Price";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.browseButton);
            this.panel1.Controls.Add(this.importButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.fileLocation);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-4, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 353);
            this.panel1.TabIndex = 11;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearButton.Location = new System.Drawing.Point(208, 220);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(180, 56);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.browseButton.Location = new System.Drawing.Point(50, 220);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(165, 56);
            this.browseButton.TabIndex = 12;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // importButton
            // 
            this.importButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.importButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.importButton.Location = new System.Drawing.Point(379, 220);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(161, 57);
            this.importButton.TabIndex = 13;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = false;
            this.importButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "File Location: ";
            // 
            // fileLocation
            // 
            this.fileLocation.Location = new System.Drawing.Point(49, 180);
            this.fileLocation.Margin = new System.Windows.Forms.Padding(4);
            this.fileLocation.Name = "fileLocation";
            this.fileLocation.Size = new System.Drawing.Size(491, 31);
            this.fileLocation.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(363, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "Import Items to Record";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.billingName);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.billingQuantity);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.addToSalesButton);
            this.panel2.Controls.Add(this.billingCategory);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(-1, 669);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 344);
            this.panel2.TabIndex = 12;
            // 
            // billingName
            // 
            this.billingName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.billingName.FormattingEnabled = true;
            this.billingName.Location = new System.Drawing.Point(290, 131);
            this.billingName.Name = "billingName";
            this.billingName.Size = new System.Drawing.Size(247, 33);
            this.billingName.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Gray;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(3, 432);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(585, 10);
            this.label13.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Gray;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(585, 10);
            this.label12.TabIndex = 13;
            // 
            // billingQuantity
            // 
            this.billingQuantity.Location = new System.Drawing.Point(290, 184);
            this.billingQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.billingQuantity.Name = "billingQuantity";
            this.billingQuantity.Size = new System.Drawing.Size(247, 31);
            this.billingQuantity.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 37);
            this.label7.TabIndex = 18;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 37);
            this.label6.TabIndex = 15;
            this.label6.Text = "Billing";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 37);
            this.label8.TabIndex = 15;
            this.label8.Text = "Item Category";
            // 
            // addToSalesButton
            // 
            this.addToSalesButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.addToSalesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToSalesButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addToSalesButton.Location = new System.Drawing.Point(290, 236);
            this.addToSalesButton.Name = "addToSalesButton";
            this.addToSalesButton.Size = new System.Drawing.Size(247, 53);
            this.addToSalesButton.TabIndex = 17;
            this.addToSalesButton.Text = "Add to Sales";
            this.addToSalesButton.UseVisualStyleBackColor = false;
            this.addToSalesButton.Click += new System.EventHandler(this.AddToSalesButton_Click);
            // 
            // billingCategory
            // 
            this.billingCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.billingCategory.FormattingEnabled = true;
            this.billingCategory.Items.AddRange(new object[] {
            "Drinks",
            "Breakfast",
            "Meal",
            "Snacks"});
            this.billingCategory.Location = new System.Drawing.Point(290, 81);
            this.billingCategory.Name = "billingCategory";
            this.billingCategory.Size = new System.Drawing.Size(247, 33);
            this.billingCategory.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 125);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 37);
            this.label9.TabIndex = 13;
            this.label9.Text = "Item Name";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Gray;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(-1, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(579, 10);
            this.label11.TabIndex = 1;
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1428, 1010);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "POSForm";
            this.Text = "Point of Sales";
            this.tabControl.ResumeLayout(false);
            this.recordsTab.ResumeLayout(false);
            this.recordsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsGridView)).EndInit();
            this.reportsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage recordsTab;
        private System.Windows.Forms.TabPage reportsTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fileLocation;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox billingQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addToSalesButton;
        private System.Windows.Forms.ComboBox billingCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox sortBy;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox billingName;
        private System.Windows.Forms.DataGridView RecordsGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart SalesReport;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.DataGridView SalesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesCategoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPriceColumn;
    }
}

