namespace WinFormsAssignment3
{
    partial class WinFormOrder
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
            this.orderCancelBtn = new System.Windows.Forms.Button();
            this.orderRequestBtn = new System.Windows.Forms.Button();
            this.orderStdPizzaBtn = new System.Windows.Forms.Button();
            this.orderItemsPanel = new System.Windows.Forms.Panel();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.orderCustomPizzaBtn = new System.Windows.Forms.Button();
            this.labelOrderInfo = new System.Windows.Forms.Label();
            this.labelOrderCost = new System.Windows.Forms.Label();
            this.labelOrderType = new System.Windows.Forms.Label();
            this.orderItemsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNewOrderHeader
            // 
            this.labelNewOrderHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNewOrderHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewOrderHeader.Location = new System.Drawing.Point(0, 0);
            this.labelNewOrderHeader.Name = "labelNewOrderHeader";
            this.labelNewOrderHeader.Size = new System.Drawing.Size(1182, 32);
            this.labelNewOrderHeader.TabIndex = 0;
            this.labelNewOrderHeader.Text = "Order Details";
            this.labelNewOrderHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // orderCancelBtn
            // 
            this.orderCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.orderCancelBtn.Location = new System.Drawing.Point(1006, 444);
            this.orderCancelBtn.Name = "orderCancelBtn";
            this.orderCancelBtn.Size = new System.Drawing.Size(164, 65);
            this.orderCancelBtn.TabIndex = 2;
            this.orderCancelBtn.Text = "Cancel Order";
            this.orderCancelBtn.UseVisualStyleBackColor = true;
            this.orderCancelBtn.Click += new System.EventHandler(this.orderCancelBtn_Click);
            // 
            // orderRequestBtn
            // 
            this.orderRequestBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.orderRequestBtn.Location = new System.Drawing.Point(1006, 373);
            this.orderRequestBtn.Name = "orderRequestBtn";
            this.orderRequestBtn.Size = new System.Drawing.Size(164, 65);
            this.orderRequestBtn.TabIndex = 3;
            this.orderRequestBtn.Text = "Place Order";
            this.orderRequestBtn.UseVisualStyleBackColor = true;
            this.orderRequestBtn.Click += new System.EventHandler(this.orderRequestBtn_Click);
            // 
            // orderStdPizzaBtn
            // 
            this.orderStdPizzaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.orderStdPizzaBtn.Location = new System.Drawing.Point(1006, 82);
            this.orderStdPizzaBtn.Name = "orderStdPizzaBtn";
            this.orderStdPizzaBtn.Size = new System.Drawing.Size(164, 65);
            this.orderStdPizzaBtn.TabIndex = 4;
            this.orderStdPizzaBtn.Text = "Standard Items";
            this.orderStdPizzaBtn.UseVisualStyleBackColor = true;
            this.orderStdPizzaBtn.Click += new System.EventHandler(this.orderStdPizzaBtn_Click);
            // 
            // orderItemsPanel
            // 
            this.orderItemsPanel.Controls.Add(this.orderDataGridView);
            this.orderItemsPanel.Location = new System.Drawing.Point(12, 153);
            this.orderItemsPanel.Name = "orderItemsPanel";
            this.orderItemsPanel.Size = new System.Drawing.Size(986, 356);
            this.orderItemsPanel.TabIndex = 5;
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDataGridView.Location = new System.Drawing.Point(0, 0);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowTemplate.Height = 24;
            this.orderDataGridView.Size = new System.Drawing.Size(986, 356);
            this.orderDataGridView.TabIndex = 0;
            this.orderDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.orderDataGridView_UserDeletedRow);
            // 
            // orderCustomPizzaBtn
            // 
            this.orderCustomPizzaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.orderCustomPizzaBtn.Location = new System.Drawing.Point(1006, 153);
            this.orderCustomPizzaBtn.Name = "orderCustomPizzaBtn";
            this.orderCustomPizzaBtn.Size = new System.Drawing.Size(164, 65);
            this.orderCustomPizzaBtn.TabIndex = 6;
            this.orderCustomPizzaBtn.Text = "Custom Pizza";
            this.orderCustomPizzaBtn.UseVisualStyleBackColor = true;
            this.orderCustomPizzaBtn.Click += new System.EventHandler(this.orderCustomPizzaBtn_Click);
            // 
            // labelOrderInfo
            // 
            this.labelOrderInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderInfo.Location = new System.Drawing.Point(12, 82);
            this.labelOrderInfo.Name = "labelOrderInfo";
            this.labelOrderInfo.Size = new System.Drawing.Size(536, 65);
            this.labelOrderInfo.TabIndex = 7;
            this.labelOrderInfo.Text = "Order:";
            this.labelOrderInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelOrderCost
            // 
            this.labelOrderCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOrderCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderCost.Location = new System.Drawing.Point(778, 82);
            this.labelOrderCost.Name = "labelOrderCost";
            this.labelOrderCost.Size = new System.Drawing.Size(220, 65);
            this.labelOrderCost.TabIndex = 8;
            this.labelOrderCost.Text = "Price:";
            this.labelOrderCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelOrderType
            // 
            this.labelOrderType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOrderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderType.Location = new System.Drawing.Point(554, 82);
            this.labelOrderType.Name = "labelOrderType";
            this.labelOrderType.Size = new System.Drawing.Size(220, 65);
            this.labelOrderType.TabIndex = 9;
            this.labelOrderType.Text = "Type:";
            this.labelOrderType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WinFormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 521);
            this.Controls.Add(this.labelOrderType);
            this.Controls.Add(this.labelOrderCost);
            this.Controls.Add(this.labelOrderInfo);
            this.Controls.Add(this.orderCustomPizzaBtn);
            this.Controls.Add(this.orderItemsPanel);
            this.Controls.Add(this.orderStdPizzaBtn);
            this.Controls.Add(this.orderRequestBtn);
            this.Controls.Add(this.orderCancelBtn);
            this.Controls.Add(this.labelNewOrderHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WinFormOrder";
            this.Text = "Lenny\'s Large Pizzas  - New Order";
            this.Load += new System.EventHandler(this.WinFormOrder_Load);
            this.orderItemsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNewOrderHeader;
        private System.Windows.Forms.Button orderCancelBtn;
        private System.Windows.Forms.Button orderRequestBtn;
        private System.Windows.Forms.Button orderStdPizzaBtn;
        private System.Windows.Forms.Panel orderItemsPanel;
        private System.Windows.Forms.Button orderCustomPizzaBtn;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.Label labelOrderInfo;
        private System.Windows.Forms.Label labelOrderCost;
        private System.Windows.Forms.Label labelOrderType;
    }
}