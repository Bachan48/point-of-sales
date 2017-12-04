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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.recordsTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportsTab = new System.Windows.Forms.TabPage();
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
            this.billingTotalButton = new System.Windows.Forms.Button();
            this.billingQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addToBillingButton = new System.Windows.Forms.Button();
            this.billingCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.billingTotal = new System.Windows.Forms.TextBox();
            this.billingClear = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.billingName = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.recordsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.recordsTab.Controls.Add(this.deleteButton);
            this.recordsTab.Controls.Add(this.comboBox1);
            this.recordsTab.Controls.Add(this.label14);
            this.recordsTab.Controls.Add(this.dataGridView1);
            this.recordsTab.Location = new System.Drawing.Point(8, 51);
            this.recordsTab.Margin = new System.Windows.Forms.Padding(4);
            this.recordsTab.Name = "recordsTab";
            this.recordsTab.Padding = new System.Windows.Forms.Padding(4);
            this.recordsTab.Size = new System.Drawing.Size(845, 953);
            this.recordsTab.TabIndex = 0;
            this.recordsTab.Text = "Records";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNameColumn,
            this.CategoryColumn,
            this.ItemPriceColumn});
            this.dataGridView1.Location = new System.Drawing.Point(4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(838, 746);
            this.dataGridView1.TabIndex = 0;
            // 
            // ItemNameColumn
            // 
            this.ItemNameColumn.HeaderText = "Name";
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
            this.reportsTab.Location = new System.Drawing.Point(8, 51);
            this.reportsTab.Margin = new System.Windows.Forms.Padding(4);
            this.reportsTab.Name = "reportsTab";
            this.reportsTab.Padding = new System.Windows.Forms.Padding(4);
            this.reportsTab.Size = new System.Drawing.Size(845, 953);
            this.reportsTab.TabIndex = 1;
            this.reportsTab.Text = "Reports";
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
            this.addButton.Location = new System.Drawing.Point(286, 240);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(247, 64);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
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
            this.category.FormattingEnabled = true;
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
            this.panel1.Size = new System.Drawing.Size(582, 256);
            this.panel1.TabIndex = 11;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearButton.Location = new System.Drawing.Point(205, 174);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(180, 56);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.browseButton.Location = new System.Drawing.Point(47, 174);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(165, 56);
            this.browseButton.TabIndex = 12;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            // 
            // importButton
            // 
            this.importButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.importButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.importButton.Location = new System.Drawing.Point(376, 174);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(161, 57);
            this.importButton.TabIndex = 13;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "File Location: ";
            // 
            // fileLocation
            // 
            this.fileLocation.Location = new System.Drawing.Point(46, 134);
            this.fileLocation.Margin = new System.Windows.Forms.Padding(4);
            this.fileLocation.Name = "fileLocation";
            this.fileLocation.Size = new System.Drawing.Size(491, 31);
            this.fileLocation.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 22);
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
            this.panel2.Controls.Add(this.billingClear);
            this.panel2.Controls.Add(this.billingTotal);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.billingTotalButton);
            this.panel2.Controls.Add(this.billingQuantity);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.addToBillingButton);
            this.panel2.Controls.Add(this.billingCategory);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(-4, 563);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 442);
            this.panel2.TabIndex = 12;
            // 
            // billingTotalButton
            // 
            this.billingTotalButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.billingTotalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingTotalButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.billingTotalButton.Location = new System.Drawing.Point(46, 236);
            this.billingTotalButton.Name = "billingTotalButton";
            this.billingTotalButton.Size = new System.Drawing.Size(247, 53);
            this.billingTotalButton.TabIndex = 20;
            this.billingTotalButton.Text = "Total";
            this.billingTotalButton.UseVisualStyleBackColor = false;
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
            this.label6.Location = new System.Drawing.Point(40, 19);
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
            // addToBillingButton
            // 
            this.addToBillingButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.addToBillingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToBillingButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addToBillingButton.Location = new System.Drawing.Point(290, 236);
            this.addToBillingButton.Name = "addToBillingButton";
            this.addToBillingButton.Size = new System.Drawing.Size(247, 53);
            this.addToBillingButton.TabIndex = 17;
            this.addToBillingButton.Text = "Add";
            this.addToBillingButton.UseVisualStyleBackColor = false;
            // 
            // billingCategory
            // 
            this.billingCategory.FormattingEnabled = true;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 307);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 37);
            this.label10.TabIndex = 21;
            this.label10.Text = "Total : ";
            // 
            // billingTotal
            // 
            this.billingTotal.Location = new System.Drawing.Point(290, 313);
            this.billingTotal.Margin = new System.Windows.Forms.Padding(4);
            this.billingTotal.Name = "billingTotal";
            this.billingTotal.Size = new System.Drawing.Size(247, 31);
            this.billingTotal.TabIndex = 22;
            // 
            // billingClear
            // 
            this.billingClear.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.billingClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.billingClear.Location = new System.Drawing.Point(46, 347);
            this.billingClear.Name = "billingClear";
            this.billingClear.Size = new System.Drawing.Size(165, 51);
            this.billingClear.TabIndex = 15;
            this.billingClear.Text = "Clear";
            this.billingClear.UseVisualStyleBackColor = false;
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
            // billingName
            // 
            this.billingName.FormattingEnabled = true;
            this.billingName.Location = new System.Drawing.Point(290, 131);
            this.billingName.Name = "billingName";
            this.billingName.Size = new System.Drawing.Size(247, 33);
            this.billingName.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 781);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(340, 45);
            this.comboBox1.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 784);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 37);
            this.label14.TabIndex = 25;
            this.label14.Text = "Sort By";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(564, 776);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(278, 53);
            this.deleteButton.TabIndex = 24;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1428, 1006);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPriceColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button billingTotalButton;
        private System.Windows.Forms.TextBox billingQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addToBillingButton;
        private System.Windows.Forms.ComboBox billingCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button billingClear;
        private System.Windows.Forms.TextBox billingTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox billingName;
    }
}

