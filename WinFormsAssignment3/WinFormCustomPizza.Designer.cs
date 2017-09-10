namespace WinFormsAssignment3
{
    partial class WinFormCustomPizza
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
            this.labelCustPizzaHeader = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pizzaToppingsGBox = new System.Windows.Forms.GroupBox();
            this.selectedToppingsGBox = new System.Windows.Forms.GroupBox();
            this.pizzaToppingsDataGridView = new System.Windows.Forms.DataGridView();
            this.lpizzaToppingsLbl = new System.Windows.Forms.Label();
            this.pizzaToppingsBtn = new System.Windows.Forms.Button();
            this.pizzaToppingsCbox = new System.Windows.Forms.ComboBox();
            this.pizzaSauceTypGBox = new System.Windows.Forms.GroupBox();
            this.pizzaSauceLbl = new System.Windows.Forms.Label();
            this.pizzaSauceRbTomato = new System.Windows.Forms.RadioButton();
            this.pizzaSauceRbBBQ = new System.Windows.Forms.RadioButton();
            this.pizzaBaseTypGBox = new System.Windows.Forms.GroupBox();
            this.pizzaBaseLbl = new System.Windows.Forms.Label();
            this.pizzaBaseRbGltFree = new System.Windows.Forms.RadioButton();
            this.pizzaBaseRbGltRegular = new System.Windows.Forms.RadioButton();
            this.pizzaChefCancelBtn = new System.Windows.Forms.Button();
            this.addToOrderBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.pizzaToppingsGBox.SuspendLayout();
            this.selectedToppingsGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaToppingsDataGridView)).BeginInit();
            this.pizzaSauceTypGBox.SuspendLayout();
            this.pizzaBaseTypGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCustPizzaHeader
            // 
            this.labelCustPizzaHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCustPizzaHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustPizzaHeader.Location = new System.Drawing.Point(0, 0);
            this.labelCustPizzaHeader.Name = "labelCustPizzaHeader";
            this.labelCustPizzaHeader.Size = new System.Drawing.Size(1182, 32);
            this.labelCustPizzaHeader.TabIndex = 1;
            this.labelCustPizzaHeader.Text = "Pizza Chef";
            this.labelCustPizzaHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pizzaToppingsGBox);
            this.groupBox1.Controls.Add(this.pizzaSauceTypGBox);
            this.groupBox1.Controls.Add(this.pizzaBaseTypGBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(986, 442);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // pizzaToppingsGBox
            // 
            this.pizzaToppingsGBox.Controls.Add(this.selectedToppingsGBox);
            this.pizzaToppingsGBox.Controls.Add(this.lpizzaToppingsLbl);
            this.pizzaToppingsGBox.Controls.Add(this.pizzaToppingsBtn);
            this.pizzaToppingsGBox.Controls.Add(this.pizzaToppingsCbox);
            this.pizzaToppingsGBox.Location = new System.Drawing.Point(306, 138);
            this.pizzaToppingsGBox.Name = "pizzaToppingsGBox";
            this.pizzaToppingsGBox.Size = new System.Drawing.Size(476, 296);
            this.pizzaToppingsGBox.TabIndex = 11;
            this.pizzaToppingsGBox.TabStop = false;
            // 
            // selectedToppingsGBox
            // 
            this.selectedToppingsGBox.Controls.Add(this.pizzaToppingsDataGridView);
            this.selectedToppingsGBox.Location = new System.Drawing.Point(6, 59);
            this.selectedToppingsGBox.Name = "selectedToppingsGBox";
            this.selectedToppingsGBox.Size = new System.Drawing.Size(464, 231);
            this.selectedToppingsGBox.TabIndex = 13;
            this.selectedToppingsGBox.TabStop = false;
            this.selectedToppingsGBox.Text = "Your Toppings";
            // 
            // pizzaToppingsDataGridView
            // 
            this.pizzaToppingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pizzaToppingsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pizzaToppingsDataGridView.Location = new System.Drawing.Point(3, 18);
            this.pizzaToppingsDataGridView.Name = "pizzaToppingsDataGridView";
            this.pizzaToppingsDataGridView.RowTemplate.Height = 24;
            this.pizzaToppingsDataGridView.Size = new System.Drawing.Size(458, 210);
            this.pizzaToppingsDataGridView.TabIndex = 2;
            // 
            // lpizzaToppingsLbl
            // 
            this.lpizzaToppingsLbl.AutoSize = true;
            this.lpizzaToppingsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpizzaToppingsLbl.Location = new System.Drawing.Point(6, 18);
            this.lpizzaToppingsLbl.Name = "lpizzaToppingsLbl";
            this.lpizzaToppingsLbl.Size = new System.Drawing.Size(82, 20);
            this.lpizzaToppingsLbl.TabIndex = 11;
            this.lpizzaToppingsLbl.Text = "Toppings:";
            // 
            // pizzaToppingsBtn
            // 
            this.pizzaToppingsBtn.Location = new System.Drawing.Point(385, 18);
            this.pizzaToppingsBtn.Name = "pizzaToppingsBtn";
            this.pizzaToppingsBtn.Size = new System.Drawing.Size(75, 23);
            this.pizzaToppingsBtn.TabIndex = 10;
            this.pizzaToppingsBtn.Text = "Add";
            this.pizzaToppingsBtn.UseVisualStyleBackColor = true;
            this.pizzaToppingsBtn.Click += new System.EventHandler(this.pizzaToppingsBtn_Click);
            // 
            // pizzaToppingsCbox
            // 
            this.pizzaToppingsCbox.FormattingEnabled = true;
            this.pizzaToppingsCbox.Location = new System.Drawing.Point(150, 14);
            this.pizzaToppingsCbox.Name = "pizzaToppingsCbox";
            this.pizzaToppingsCbox.Size = new System.Drawing.Size(207, 24);
            this.pizzaToppingsCbox.TabIndex = 9;
            // 
            // pizzaSauceTypGBox
            // 
            this.pizzaSauceTypGBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pizzaSauceTypGBox.Controls.Add(this.pizzaSauceLbl);
            this.pizzaSauceTypGBox.Controls.Add(this.pizzaSauceRbTomato);
            this.pizzaSauceTypGBox.Controls.Add(this.pizzaSauceRbBBQ);
            this.pizzaSauceTypGBox.Location = new System.Drawing.Point(306, 77);
            this.pizzaSauceTypGBox.Name = "pizzaSauceTypGBox";
            this.pizzaSauceTypGBox.Size = new System.Drawing.Size(476, 56);
            this.pizzaSauceTypGBox.TabIndex = 7;
            this.pizzaSauceTypGBox.TabStop = false;
            // 
            // pizzaSauceLbl
            // 
            this.pizzaSauceLbl.AutoSize = true;
            this.pizzaSauceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaSauceLbl.Location = new System.Drawing.Point(6, 18);
            this.pizzaSauceLbl.Name = "pizzaSauceLbl";
            this.pizzaSauceLbl.Size = new System.Drawing.Size(108, 20);
            this.pizzaSauceLbl.TabIndex = 7;
            this.pizzaSauceLbl.Text = "Pizza Sauce:";
            // 
            // pizzaSauceRbTomato
            // 
            this.pizzaSauceRbTomato.AutoSize = true;
            this.pizzaSauceRbTomato.Location = new System.Drawing.Point(150, 17);
            this.pizzaSauceRbTomato.Name = "pizzaSauceRbTomato";
            this.pizzaSauceRbTomato.Size = new System.Drawing.Size(77, 21);
            this.pizzaSauceRbTomato.TabIndex = 6;
            this.pizzaSauceRbTomato.TabStop = true;
            this.pizzaSauceRbTomato.Text = "Tomato";
            this.pizzaSauceRbTomato.UseVisualStyleBackColor = true;
            // 
            // pizzaSauceRbBBQ
            // 
            this.pizzaSauceRbBBQ.AutoSize = true;
            this.pizzaSauceRbBBQ.Location = new System.Drawing.Point(282, 18);
            this.pizzaSauceRbBBQ.Name = "pizzaSauceRbBBQ";
            this.pizzaSauceRbBBQ.Size = new System.Drawing.Size(58, 21);
            this.pizzaSauceRbBBQ.TabIndex = 5;
            this.pizzaSauceRbBBQ.TabStop = true;
            this.pizzaSauceRbBBQ.Text = "BBQ";
            this.pizzaSauceRbBBQ.UseVisualStyleBackColor = true;
            // 
            // pizzaBaseTypGBox
            // 
            this.pizzaBaseTypGBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pizzaBaseTypGBox.Controls.Add(this.pizzaBaseLbl);
            this.pizzaBaseTypGBox.Controls.Add(this.pizzaBaseRbGltFree);
            this.pizzaBaseTypGBox.Controls.Add(this.pizzaBaseRbGltRegular);
            this.pizzaBaseTypGBox.Location = new System.Drawing.Point(306, 20);
            this.pizzaBaseTypGBox.Name = "pizzaBaseTypGBox";
            this.pizzaBaseTypGBox.Size = new System.Drawing.Size(476, 51);
            this.pizzaBaseTypGBox.TabIndex = 6;
            this.pizzaBaseTypGBox.TabStop = false;
            // 
            // pizzaBaseLbl
            // 
            this.pizzaBaseLbl.AutoSize = true;
            this.pizzaBaseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaBaseLbl.Location = new System.Drawing.Point(6, 18);
            this.pizzaBaseLbl.Name = "pizzaBaseLbl";
            this.pizzaBaseLbl.Size = new System.Drawing.Size(100, 20);
            this.pizzaBaseLbl.TabIndex = 7;
            this.pizzaBaseLbl.Text = "Pizza Base:";
            // 
            // pizzaBaseRbGltFree
            // 
            this.pizzaBaseRbGltFree.AutoSize = true;
            this.pizzaBaseRbGltFree.Location = new System.Drawing.Point(150, 21);
            this.pizzaBaseRbGltFree.Name = "pizzaBaseRbGltFree";
            this.pizzaBaseRbGltFree.Size = new System.Drawing.Size(104, 21);
            this.pizzaBaseRbGltFree.TabIndex = 6;
            this.pizzaBaseRbGltFree.TabStop = true;
            this.pizzaBaseRbGltFree.Text = "Gluten Free";
            this.pizzaBaseRbGltFree.UseVisualStyleBackColor = true;
            // 
            // pizzaBaseRbGltRegular
            // 
            this.pizzaBaseRbGltRegular.AutoSize = true;
            this.pizzaBaseRbGltRegular.Location = new System.Drawing.Point(282, 24);
            this.pizzaBaseRbGltRegular.Name = "pizzaBaseRbGltRegular";
            this.pizzaBaseRbGltRegular.Size = new System.Drawing.Size(79, 21);
            this.pizzaBaseRbGltRegular.TabIndex = 5;
            this.pizzaBaseRbGltRegular.TabStop = true;
            this.pizzaBaseRbGltRegular.Text = "Regular";
            this.pizzaBaseRbGltRegular.UseVisualStyleBackColor = true;
            // 
            // pizzaChefCancelBtn
            // 
            this.pizzaChefCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pizzaChefCancelBtn.Location = new System.Drawing.Point(1006, 446);
            this.pizzaChefCancelBtn.Name = "pizzaChefCancelBtn";
            this.pizzaChefCancelBtn.Size = new System.Drawing.Size(164, 65);
            this.pizzaChefCancelBtn.TabIndex = 3;
            this.pizzaChefCancelBtn.Text = "Cancel";
            this.pizzaChefCancelBtn.UseVisualStyleBackColor = true;
            this.pizzaChefCancelBtn.Click += new System.EventHandler(this.pizzaChefCancelBtn_Click);
            // 
            // addToOrderBtn
            // 
            this.addToOrderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addToOrderBtn.Location = new System.Drawing.Point(1006, 375);
            this.addToOrderBtn.Name = "addToOrderBtn";
            this.addToOrderBtn.Size = new System.Drawing.Size(164, 65);
            this.addToOrderBtn.TabIndex = 4;
            this.addToOrderBtn.Text = "Add to Order";
            this.addToOrderBtn.UseVisualStyleBackColor = true;
            this.addToOrderBtn.Click += new System.EventHandler(this.addToOrderBtn_Click);
            // 
            // WinFormCustomPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 523);
            this.Controls.Add(this.addToOrderBtn);
            this.Controls.Add(this.pizzaChefCancelBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelCustPizzaHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WinFormCustomPizza";
            this.Text = "Lenny\'s Large Pizzas  - Standard Pizzas";
            this.Load += new System.EventHandler(this.WinFormCustomPizza_Load);
            this.groupBox1.ResumeLayout(false);
            this.pizzaToppingsGBox.ResumeLayout(false);
            this.pizzaToppingsGBox.PerformLayout();
            this.selectedToppingsGBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pizzaToppingsDataGridView)).EndInit();
            this.pizzaSauceTypGBox.ResumeLayout(false);
            this.pizzaSauceTypGBox.PerformLayout();
            this.pizzaBaseTypGBox.ResumeLayout(false);
            this.pizzaBaseTypGBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCustPizzaHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pizzaChefCancelBtn;
        private System.Windows.Forms.Button addToOrderBtn;
        private System.Windows.Forms.GroupBox pizzaBaseTypGBox;
        private System.Windows.Forms.Label pizzaBaseLbl;
        private System.Windows.Forms.RadioButton pizzaBaseRbGltFree;
        private System.Windows.Forms.RadioButton pizzaBaseRbGltRegular;
        private System.Windows.Forms.GroupBox pizzaSauceTypGBox;
        private System.Windows.Forms.Label pizzaSauceLbl;
        private System.Windows.Forms.RadioButton pizzaSauceRbTomato;
        private System.Windows.Forms.RadioButton pizzaSauceRbBBQ;
        private System.Windows.Forms.GroupBox pizzaToppingsGBox;
        private System.Windows.Forms.Button pizzaToppingsBtn;
        private System.Windows.Forms.ComboBox pizzaToppingsCbox;
        private System.Windows.Forms.Label lpizzaToppingsLbl;
        private System.Windows.Forms.GroupBox selectedToppingsGBox;
        private System.Windows.Forms.DataGridView pizzaToppingsDataGridView;
    }
}