namespace WinFormsAssignment3
{
    partial class WinFormStandardItems
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
            this.labelNewOrderHeader = new System.Windows.Forms.Label();
            this.cusPizzaPanel = new System.Windows.Forms.Panel();
            this.addFantaBtn = new System.Windows.Forms.Button();
            this.fantaSizeCbox = new System.Windows.Forms.ComboBox();
            this.fantaLbl = new System.Windows.Forms.Label();
            this.addCokeBtn = new System.Windows.Forms.Button();
            this.cokeSizeCbox = new System.Windows.Forms.ComboBox();
            this.cokeLbl = new System.Windows.Forms.Label();
            this.addHawaiianBtn = new System.Windows.Forms.Button();
            this.addCheeseBtn = new System.Windows.Forms.Button();
            this.addPepperoniBtn = new System.Windows.Forms.Button();
            this.hawaiianBazeCbox = new System.Windows.Forms.ComboBox();
            this.cheeseBazeCbox = new System.Windows.Forms.ComboBox();
            this.pepperoniBazeCbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cheeseLbl = new System.Windows.Forms.Label();
            this.pepperoniLbl = new System.Windows.Forms.Label();
            this.cusPizzaOrderPanel = new System.Windows.Forms.Panel();
            this.standardPizzasDataGridView = new System.Windows.Forms.DataGridView();
            this.orderStndPizzaCancelBtn = new System.Windows.Forms.Button();
            this.orderStndPizzaAddBtn = new System.Windows.Forms.Button();
            this.removeItemBtn = new System.Windows.Forms.Button();
            this.cusPizzaPanel.SuspendLayout();
            this.cusPizzaOrderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardPizzasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNewOrderHeader
            // 
            this.labelNewOrderHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNewOrderHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewOrderHeader.Location = new System.Drawing.Point(0, 0);
            this.labelNewOrderHeader.Name = "labelNewOrderHeader";
            this.labelNewOrderHeader.Size = new System.Drawing.Size(1182, 32);
            this.labelNewOrderHeader.TabIndex = 1;
            this.labelNewOrderHeader.Text = "Standard Pizzas and Drinks";
            this.labelNewOrderHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cusPizzaPanel
            // 
            this.cusPizzaPanel.Controls.Add(this.addFantaBtn);
            this.cusPizzaPanel.Controls.Add(this.fantaSizeCbox);
            this.cusPizzaPanel.Controls.Add(this.fantaLbl);
            this.cusPizzaPanel.Controls.Add(this.addCokeBtn);
            this.cusPizzaPanel.Controls.Add(this.cokeSizeCbox);
            this.cusPizzaPanel.Controls.Add(this.cokeLbl);
            this.cusPizzaPanel.Controls.Add(this.addHawaiianBtn);
            this.cusPizzaPanel.Controls.Add(this.addCheeseBtn);
            this.cusPizzaPanel.Controls.Add(this.addPepperoniBtn);
            this.cusPizzaPanel.Controls.Add(this.hawaiianBazeCbox);
            this.cusPizzaPanel.Controls.Add(this.cheeseBazeCbox);
            this.cusPizzaPanel.Controls.Add(this.pepperoniBazeCbox);
            this.cusPizzaPanel.Controls.Add(this.label2);
            this.cusPizzaPanel.Controls.Add(this.cheeseLbl);
            this.cusPizzaPanel.Controls.Add(this.pepperoniLbl);
            this.cusPizzaPanel.Location = new System.Drawing.Point(21, 84);
            this.cusPizzaPanel.Name = "cusPizzaPanel";
            this.cusPizzaPanel.Size = new System.Drawing.Size(986, 165);
            this.cusPizzaPanel.TabIndex = 2;
            // 
            // addFantaBtn
            // 
            this.addFantaBtn.Location = new System.Drawing.Point(885, 71);
            this.addFantaBtn.Name = "addFantaBtn";
            this.addFantaBtn.Size = new System.Drawing.Size(75, 23);
            this.addFantaBtn.TabIndex = 14;
            this.addFantaBtn.Text = "Add";
            this.addFantaBtn.UseVisualStyleBackColor = true;
            this.addFantaBtn.Click += new System.EventHandler(this.addFantaBtn_Click);
            // 
            // fantaSizeCbox
            // 
            this.fantaSizeCbox.FormattingEnabled = true;
            this.fantaSizeCbox.Items.AddRange(new object[] {
            "1.25 liters",
            "2 liters"});
            this.fantaSizeCbox.Location = new System.Drawing.Point(740, 70);
            this.fantaSizeCbox.Name = "fantaSizeCbox";
            this.fantaSizeCbox.Size = new System.Drawing.Size(121, 24);
            this.fantaSizeCbox.TabIndex = 13;
            // 
            // fantaLbl
            // 
            this.fantaLbl.Location = new System.Drawing.Point(676, 73);
            this.fantaLbl.Name = "fantaLbl";
            this.fantaLbl.Size = new System.Drawing.Size(79, 17);
            this.fantaLbl.TabIndex = 12;
            this.fantaLbl.Text = "Fanta:";
            // 
            // addCokeBtn
            // 
            this.addCokeBtn.Location = new System.Drawing.Point(882, 29);
            this.addCokeBtn.Name = "addCokeBtn";
            this.addCokeBtn.Size = new System.Drawing.Size(75, 23);
            this.addCokeBtn.TabIndex = 11;
            this.addCokeBtn.Text = "Add";
            this.addCokeBtn.UseVisualStyleBackColor = true;
            this.addCokeBtn.Click += new System.EventHandler(this.addCokeBtn_Click);
            // 
            // cokeSizeCbox
            // 
            this.cokeSizeCbox.FormattingEnabled = true;
            this.cokeSizeCbox.Items.AddRange(new object[] {
            "1.25 liters",
            "2 liters"});
            this.cokeSizeCbox.Location = new System.Drawing.Point(737, 28);
            this.cokeSizeCbox.Name = "cokeSizeCbox";
            this.cokeSizeCbox.Size = new System.Drawing.Size(121, 24);
            this.cokeSizeCbox.TabIndex = 10;
            // 
            // cokeLbl
            // 
            this.cokeLbl.Location = new System.Drawing.Point(673, 31);
            this.cokeLbl.Name = "cokeLbl";
            this.cokeLbl.Size = new System.Drawing.Size(79, 17);
            this.cokeLbl.TabIndex = 9;
            this.cokeLbl.Text = "Coke:";
            // 
            // addHawaiianBtn
            // 
            this.addHawaiianBtn.Location = new System.Drawing.Point(295, 109);
            this.addHawaiianBtn.Name = "addHawaiianBtn";
            this.addHawaiianBtn.Size = new System.Drawing.Size(75, 23);
            this.addHawaiianBtn.TabIndex = 8;
            this.addHawaiianBtn.Text = "Add";
            this.addHawaiianBtn.UseVisualStyleBackColor = true;
            this.addHawaiianBtn.Click += new System.EventHandler(this.addHawaiianBtn_Click);
            // 
            // addCheeseBtn
            // 
            this.addCheeseBtn.Location = new System.Drawing.Point(295, 71);
            this.addCheeseBtn.Name = "addCheeseBtn";
            this.addCheeseBtn.Size = new System.Drawing.Size(75, 23);
            this.addCheeseBtn.TabIndex = 7;
            this.addCheeseBtn.Text = "Add";
            this.addCheeseBtn.UseVisualStyleBackColor = true;
            this.addCheeseBtn.Click += new System.EventHandler(this.addCheeseBtn_Click);
            // 
            // addPepperoniBtn
            // 
            this.addPepperoniBtn.Location = new System.Drawing.Point(295, 29);
            this.addPepperoniBtn.Name = "addPepperoniBtn";
            this.addPepperoniBtn.Size = new System.Drawing.Size(75, 23);
            this.addPepperoniBtn.TabIndex = 6;
            this.addPepperoniBtn.Text = "Add";
            this.addPepperoniBtn.UseVisualStyleBackColor = true;
            this.addPepperoniBtn.Click += new System.EventHandler(this.addPepperoniBtn_Click);
            // 
            // hawaiianBazeCbox
            // 
            this.hawaiianBazeCbox.FormattingEnabled = true;
            this.hawaiianBazeCbox.Items.AddRange(new object[] {
            "regular base",
            "gluten-free base"});
            this.hawaiianBazeCbox.Location = new System.Drawing.Point(150, 105);
            this.hawaiianBazeCbox.Name = "hawaiianBazeCbox";
            this.hawaiianBazeCbox.Size = new System.Drawing.Size(121, 24);
            this.hawaiianBazeCbox.TabIndex = 5;
            // 
            // cheeseBazeCbox
            // 
            this.cheeseBazeCbox.FormattingEnabled = true;
            this.cheeseBazeCbox.Items.AddRange(new object[] {
            "regular base",
            "gluten-free base"});
            this.cheeseBazeCbox.Location = new System.Drawing.Point(150, 68);
            this.cheeseBazeCbox.Name = "cheeseBazeCbox";
            this.cheeseBazeCbox.Size = new System.Drawing.Size(121, 24);
            this.cheeseBazeCbox.TabIndex = 4;
            // 
            // pepperoniBazeCbox
            // 
            this.pepperoniBazeCbox.FormattingEnabled = true;
            this.pepperoniBazeCbox.Items.AddRange(new object[] {
            "regular base",
            "gluten-free base"});
            this.pepperoniBazeCbox.Location = new System.Drawing.Point(150, 28);
            this.pepperoniBazeCbox.Name = "pepperoniBazeCbox";
            this.pepperoniBazeCbox.Size = new System.Drawing.Size(121, 24);
            this.pepperoniBazeCbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hawaiian Pizza:";
            // 
            // cheeseLbl
            // 
            this.cheeseLbl.AutoSize = true;
            this.cheeseLbl.Location = new System.Drawing.Point(29, 71);
            this.cheeseLbl.Name = "cheeseLbl";
            this.cheeseLbl.Size = new System.Drawing.Size(98, 17);
            this.cheeseLbl.TabIndex = 1;
            this.cheeseLbl.Text = "Cheese Pizza:";
            // 
            // pepperoniLbl
            // 
            this.pepperoniLbl.AutoSize = true;
            this.pepperoniLbl.Location = new System.Drawing.Point(29, 31);
            this.pepperoniLbl.Name = "pepperoniLbl";
            this.pepperoniLbl.Size = new System.Drawing.Size(115, 17);
            this.pepperoniLbl.TabIndex = 0;
            this.pepperoniLbl.Text = "Pepperoni Pizza:";
            // 
            // cusPizzaOrderPanel
            // 
            this.cusPizzaOrderPanel.Controls.Add(this.standardPizzasDataGridView);
            this.cusPizzaOrderPanel.Location = new System.Drawing.Point(21, 269);
            this.cusPizzaOrderPanel.Name = "cusPizzaOrderPanel";
            this.cusPizzaOrderPanel.Size = new System.Drawing.Size(986, 240);
            this.cusPizzaOrderPanel.TabIndex = 3;
            // 
            // standardPizzasDataGridView
            // 
            this.standardPizzasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.standardPizzasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standardPizzasDataGridView.Location = new System.Drawing.Point(0, 0);
            this.standardPizzasDataGridView.Name = "standardPizzasDataGridView";
            this.standardPizzasDataGridView.RowTemplate.Height = 24;
            this.standardPizzasDataGridView.Size = new System.Drawing.Size(986, 240);
            this.standardPizzasDataGridView.TabIndex = 1;
            // 
            // orderStndPizzaCancelBtn
            // 
            this.orderStndPizzaCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.orderStndPizzaCancelBtn.Location = new System.Drawing.Point(1015, 444);
            this.orderStndPizzaCancelBtn.Name = "orderStndPizzaCancelBtn";
            this.orderStndPizzaCancelBtn.Size = new System.Drawing.Size(164, 65);
            this.orderStndPizzaCancelBtn.TabIndex = 4;
            this.orderStndPizzaCancelBtn.Text = "Cancel";
            this.orderStndPizzaCancelBtn.UseVisualStyleBackColor = true;
            this.orderStndPizzaCancelBtn.Click += new System.EventHandler(this.orderStndPizzaCancelBtn_Click);
            // 
            // orderStndPizzaAddBtn
            // 
            this.orderStndPizzaAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.orderStndPizzaAddBtn.Location = new System.Drawing.Point(1015, 269);
            this.orderStndPizzaAddBtn.Name = "orderStndPizzaAddBtn";
            this.orderStndPizzaAddBtn.Size = new System.Drawing.Size(164, 65);
            this.orderStndPizzaAddBtn.TabIndex = 5;
            this.orderStndPizzaAddBtn.Text = "Add";
            this.orderStndPizzaAddBtn.UseVisualStyleBackColor = true;
            this.orderStndPizzaAddBtn.Click += new System.EventHandler(this.orderStndPizzaAddBtn_Click);
            // 
            // removeItemBtn
            // 
            this.removeItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeItemBtn.Location = new System.Drawing.Point(1015, 340);
            this.removeItemBtn.Name = "removeItemBtn";
            this.removeItemBtn.Size = new System.Drawing.Size(164, 65);
            this.removeItemBtn.TabIndex = 6;
            this.removeItemBtn.Text = "Remove";
            this.removeItemBtn.UseVisualStyleBackColor = true;
            this.removeItemBtn.Click += new System.EventHandler(this.removeItemBtn_Click);
            // 
            // WinFormStandardItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 521);
            this.Controls.Add(this.removeItemBtn);
            this.Controls.Add(this.orderStndPizzaAddBtn);
            this.Controls.Add(this.orderStndPizzaCancelBtn);
            this.Controls.Add(this.cusPizzaOrderPanel);
            this.Controls.Add(this.cusPizzaPanel);
            this.Controls.Add(this.labelNewOrderHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WinFormStandardItems";
            this.Text = "Lenny\'s Large Pizzas  - Standard Pizzas";
            this.Load += new System.EventHandler(this.WinFormStandardPizza_Load);
            this.cusPizzaPanel.ResumeLayout(false);
            this.cusPizzaPanel.PerformLayout();
            this.cusPizzaOrderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.standardPizzasDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNewOrderHeader;
        private System.Windows.Forms.Panel cusPizzaPanel;
        private System.Windows.Forms.Panel cusPizzaOrderPanel;
        private System.Windows.Forms.Button orderStndPizzaCancelBtn;
        private System.Windows.Forms.Button orderStndPizzaAddBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cheeseLbl;
        private System.Windows.Forms.Label pepperoniLbl;
        private System.Windows.Forms.ComboBox pepperoniBazeCbox;
        private System.Windows.Forms.ComboBox hawaiianBazeCbox;
        private System.Windows.Forms.ComboBox cheeseBazeCbox;
        private System.Windows.Forms.Button addHawaiianBtn;
        private System.Windows.Forms.Button addCheeseBtn;
        private System.Windows.Forms.Button addPepperoniBtn;
        private System.Windows.Forms.DataGridView standardPizzasDataGridView;
        private System.Windows.Forms.Button addFantaBtn;
        private System.Windows.Forms.ComboBox fantaSizeCbox;
        private System.Windows.Forms.Label fantaLbl;
        private System.Windows.Forms.Button addCokeBtn;
        private System.Windows.Forms.ComboBox cokeSizeCbox;
        private System.Windows.Forms.Label cokeLbl;
        private System.Windows.Forms.Button removeItemBtn;
    }
}