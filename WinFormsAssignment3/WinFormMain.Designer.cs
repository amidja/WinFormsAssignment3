namespace WinFormsAssignment3
{
    partial class WinFormMain
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
            this.components = new System.ComponentModel.Container();
            this.mainNewOrderBtn = new System.Windows.Forms.Button();
            this.mainExitBtn = new System.Windows.Forms.Button();
            this.labelMainHeader = new System.Windows.Forms.Label();
            this.mainOrderTypGBox = new System.Windows.Forms.GroupBox();
            this.mainCustomerDeliveryLbl = new System.Windows.Forms.Label();
            this.mainOrderTypRbPickup = new System.Windows.Forms.RadioButton();
            this.mainOrderTypRbDelivery = new System.Windows.Forms.RadioButton();
            this.mainCustomerGBox = new System.Windows.Forms.GroupBox();
            this.mainCustomerPhoneText = new System.Windows.Forms.TextBox();
            this.mainCustomerAddressText = new System.Windows.Forms.TextBox();
            this.mainCustomerNameText = new System.Windows.Forms.TextBox();
            this.mainCustomerPhoneLbl = new System.Windows.Forms.Label();
            this.mainCustomerAddressLbl = new System.Windows.Forms.Label();
            this.mainCustomerNameLbl = new System.Windows.Forms.Label();
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.addressErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.phoneErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mainOrderTypGBox.SuspendLayout();
            this.mainCustomerGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // mainNewOrderBtn
            // 
            this.mainNewOrderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mainNewOrderBtn.Location = new System.Drawing.Point(887, 98);
            this.mainNewOrderBtn.Name = "mainNewOrderBtn";
            this.mainNewOrderBtn.Size = new System.Drawing.Size(164, 75);
            this.mainNewOrderBtn.TabIndex = 0;
            this.mainNewOrderBtn.Text = "Order";
            this.mainNewOrderBtn.UseVisualStyleBackColor = true;
            this.mainNewOrderBtn.Click += new System.EventHandler(this.mainNewOrderBtn_Click);
            // 
            // mainExitBtn
            // 
            this.mainExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mainExitBtn.Location = new System.Drawing.Point(887, 456);
            this.mainExitBtn.Name = "mainExitBtn";
            this.mainExitBtn.Size = new System.Drawing.Size(164, 65);
            this.mainExitBtn.TabIndex = 1;
            this.mainExitBtn.Text = "Exit";
            this.mainExitBtn.UseVisualStyleBackColor = true;
            this.mainExitBtn.Click += new System.EventHandler(this.mainExitBtn_Click);
            // 
            // labelMainHeader
            // 
            this.labelMainHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMainHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainHeader.Location = new System.Drawing.Point(0, 0);
            this.labelMainHeader.Name = "labelMainHeader";
            this.labelMainHeader.Size = new System.Drawing.Size(1063, 32);
            this.labelMainHeader.TabIndex = 2;
            this.labelMainHeader.Text = "Welcome to Lenny\'s Large Pizzas";
            this.labelMainHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainOrderTypGBox
            // 
            this.mainOrderTypGBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mainOrderTypGBox.Controls.Add(this.mainCustomerDeliveryLbl);
            this.mainOrderTypGBox.Controls.Add(this.mainOrderTypRbPickup);
            this.mainOrderTypGBox.Controls.Add(this.mainOrderTypRbDelivery);
            this.mainOrderTypGBox.Location = new System.Drawing.Point(68, 320);
            this.mainOrderTypGBox.Name = "mainOrderTypGBox";
            this.mainOrderTypGBox.Size = new System.Drawing.Size(646, 96);
            this.mainOrderTypGBox.TabIndex = 5;
            this.mainOrderTypGBox.TabStop = false;
            // 
            // mainCustomerDeliveryLbl
            // 
            this.mainCustomerDeliveryLbl.AutoSize = true;
            this.mainCustomerDeliveryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCustomerDeliveryLbl.Location = new System.Drawing.Point(30, 39);
            this.mainCustomerDeliveryLbl.Name = "mainCustomerDeliveryLbl";
            this.mainCustomerDeliveryLbl.Size = new System.Drawing.Size(150, 20);
            this.mainCustomerDeliveryLbl.TabIndex = 7;
            this.mainCustomerDeliveryLbl.Text = "Pickup or Delivery:";
            // 
            // mainOrderTypRbPickup
            // 
            this.mainOrderTypRbPickup.AutoSize = true;
            this.mainOrderTypRbPickup.Location = new System.Drawing.Point(304, 40);
            this.mainOrderTypRbPickup.Name = "mainOrderTypRbPickup";
            this.mainOrderTypRbPickup.Size = new System.Drawing.Size(77, 21);
            this.mainOrderTypRbPickup.TabIndex = 6;
            this.mainOrderTypRbPickup.TabStop = true;
            this.mainOrderTypRbPickup.Text = "Pick Up";
            this.mainOrderTypRbPickup.UseVisualStyleBackColor = true;
            // 
            // mainOrderTypRbDelivery
            // 
            this.mainOrderTypRbDelivery.AutoSize = true;
            this.mainOrderTypRbDelivery.Location = new System.Drawing.Point(529, 40);
            this.mainOrderTypRbDelivery.Name = "mainOrderTypRbDelivery";
            this.mainOrderTypRbDelivery.Size = new System.Drawing.Size(80, 21);
            this.mainOrderTypRbDelivery.TabIndex = 5;
            this.mainOrderTypRbDelivery.TabStop = true;
            this.mainOrderTypRbDelivery.Text = "Delivery";
            this.mainOrderTypRbDelivery.UseVisualStyleBackColor = true;
            // 
            // mainCustomerGBox
            // 
            this.mainCustomerGBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mainCustomerGBox.Controls.Add(this.mainCustomerPhoneText);
            this.mainCustomerGBox.Controls.Add(this.mainCustomerAddressText);
            this.mainCustomerGBox.Controls.Add(this.mainCustomerNameText);
            this.mainCustomerGBox.Controls.Add(this.mainCustomerPhoneLbl);
            this.mainCustomerGBox.Controls.Add(this.mainCustomerAddressLbl);
            this.mainCustomerGBox.Controls.Add(this.mainCustomerNameLbl);
            this.mainCustomerGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCustomerGBox.Location = new System.Drawing.Point(68, 85);
            this.mainCustomerGBox.Name = "mainCustomerGBox";
            this.mainCustomerGBox.Size = new System.Drawing.Size(646, 205);
            this.mainCustomerGBox.TabIndex = 6;
            this.mainCustomerGBox.TabStop = false;
            this.mainCustomerGBox.Text = "Your Details:";
            // 
            // mainCustomerPhoneText
            // 
            this.mainCustomerPhoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCustomerPhoneText.Location = new System.Drawing.Point(304, 139);
            this.mainCustomerPhoneText.Name = "mainCustomerPhoneText";
            this.mainCustomerPhoneText.Size = new System.Drawing.Size(305, 27);
            this.mainCustomerPhoneText.TabIndex = 5;
            this.mainCustomerPhoneText.Validating += new System.ComponentModel.CancelEventHandler(this.mainCustomerPhoneText_Validating);
            // 
            // mainCustomerAddressText
            // 
            this.mainCustomerAddressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCustomerAddressText.Location = new System.Drawing.Point(304, 92);
            this.mainCustomerAddressText.Name = "mainCustomerAddressText";
            this.mainCustomerAddressText.Size = new System.Drawing.Size(305, 27);
            this.mainCustomerAddressText.TabIndex = 4;
            this.mainCustomerAddressText.Validating += new System.ComponentModel.CancelEventHandler(this.mainCustomerAddressText_Validating);
            // 
            // mainCustomerNameText
            // 
            this.mainCustomerNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCustomerNameText.Location = new System.Drawing.Point(304, 48);
            this.mainCustomerNameText.Name = "mainCustomerNameText";
            this.mainCustomerNameText.Size = new System.Drawing.Size(305, 27);
            this.mainCustomerNameText.TabIndex = 3;
            this.mainCustomerNameText.Validating += new System.ComponentModel.CancelEventHandler(this.mainCustomerNameText_Validating);
            // 
            // mainCustomerPhoneLbl
            // 
            this.mainCustomerPhoneLbl.AutoSize = true;
            this.mainCustomerPhoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCustomerPhoneLbl.Location = new System.Drawing.Point(30, 146);
            this.mainCustomerPhoneLbl.Name = "mainCustomerPhoneLbl";
            this.mainCustomerPhoneLbl.Size = new System.Drawing.Size(61, 20);
            this.mainCustomerPhoneLbl.TabIndex = 2;
            this.mainCustomerPhoneLbl.Text = "Phone:";
            // 
            // mainCustomerAddressLbl
            // 
            this.mainCustomerAddressLbl.AutoSize = true;
            this.mainCustomerAddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCustomerAddressLbl.Location = new System.Drawing.Point(30, 95);
            this.mainCustomerAddressLbl.Name = "mainCustomerAddressLbl";
            this.mainCustomerAddressLbl.Size = new System.Drawing.Size(76, 20);
            this.mainCustomerAddressLbl.TabIndex = 1;
            this.mainCustomerAddressLbl.Text = "Address:";
            // 
            // mainCustomerNameLbl
            // 
            this.mainCustomerNameLbl.AutoSize = true;
            this.mainCustomerNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCustomerNameLbl.Location = new System.Drawing.Point(30, 48);
            this.mainCustomerNameLbl.Name = "mainCustomerNameLbl";
            this.mainCustomerNameLbl.Size = new System.Drawing.Size(58, 20);
            this.mainCustomerNameLbl.TabIndex = 0;
            this.mainCustomerNameLbl.Text = "Name:";
            // 
            // nameErrorProvider
            // 
            this.nameErrorProvider.ContainerControl = this;
            // 
            // addressErrorProvider
            // 
            this.addressErrorProvider.ContainerControl = this;
            // 
            // phoneErrorProvider
            // 
            this.phoneErrorProvider.ContainerControl = this;
            // 
            // WinFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 533);
            this.Controls.Add(this.mainCustomerGBox);
            this.Controls.Add(this.mainOrderTypGBox);
            this.Controls.Add(this.labelMainHeader);
            this.Controls.Add(this.mainExitBtn);
            this.Controls.Add(this.mainNewOrderBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WinFormMain";
            this.Text = "Lenny\'s Large Pizzas";
            this.Load += new System.EventHandler(this.WinFormMain_Load);
            this.mainOrderTypGBox.ResumeLayout(false);
            this.mainOrderTypGBox.PerformLayout();
            this.mainCustomerGBox.ResumeLayout(false);
            this.mainCustomerGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainNewOrderBtn;
        private System.Windows.Forms.Button mainExitBtn;
        private System.Windows.Forms.Label labelMainHeader;
        private System.Windows.Forms.GroupBox mainOrderTypGBox;
        private System.Windows.Forms.RadioButton mainOrderTypRbPickup;
        private System.Windows.Forms.RadioButton mainOrderTypRbDelivery;
        private System.Windows.Forms.GroupBox mainCustomerGBox;
        private System.Windows.Forms.Label mainCustomerDeliveryLbl;
        private System.Windows.Forms.TextBox mainCustomerNameText;
        private System.Windows.Forms.Label mainCustomerPhoneLbl;
        private System.Windows.Forms.Label mainCustomerAddressLbl;
        private System.Windows.Forms.Label mainCustomerNameLbl;
        private System.Windows.Forms.TextBox mainCustomerPhoneText;
        private System.Windows.Forms.TextBox mainCustomerAddressText;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        private System.Windows.Forms.ErrorProvider addressErrorProvider;
        private System.Windows.Forms.ErrorProvider phoneErrorProvider;
    }
}

