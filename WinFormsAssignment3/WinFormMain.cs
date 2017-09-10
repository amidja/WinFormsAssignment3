using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assig3.Restaurant;
using Assig3.Order;

namespace WinFormsAssignment3
{
    /// Author:         <Jasmin Amidzic>
    /// <summary>
    /// This is main form that is used to capture customer details 
    /// and start the order.
    /// </summary>
    public partial class WinFormMain : Form
    {
        
        public WinFormMain()
        {
            InitializeComponent();  
        }

        private void mainExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Initialise the new order and open the order form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainNewOrderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer(this.mainCustomerNameText.Text);
                customer.Address = this.mainCustomerAddressText.Text;
                customer.Phone = this.mainCustomerPhoneText.Text;

                Order custOrder = new Order(customer);
                if (this.mainOrderTypRbDelivery.Checked)
                    custOrder.OrderDeliveryType = DeliveryType.DELIVERY;
                else
                    custOrder.OrderDeliveryType = DeliveryType.PICKUP;

                //Create Customer and it to the order object 
                this.Hide();
                WinFormOrder winFormOrder = new WinFormOrder(this, custOrder);
                winFormOrder.Show();

            }
            catch(ArgumentException ex)
            {
                String errorMsg = "Please provide required personal details!";
                DialogResult result = MessageBox.Show(errorMsg, "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.mainCustomerNameText.Focus();

            }
        }

        private void WinFormMain_Load(object sender, EventArgs e)
        {
            this.mainOrderTypRbDelivery.Select();
            this.mainCustomerNameText.Focus(); 
        }

        /// <summary>
        /// This method performs validation of customer's name and adds error to the
        /// error provider if invalid input was provided by a user. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainCustomerNameText_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(mainCustomerNameText.Text))
                nameErrorProvider.SetError(this.mainCustomerNameText, "Customer name is required.");
            else
                nameErrorProvider.SetError(this.mainCustomerNameText, "");
        }

        /// <summary>
        /// This method performs validation of customer's address and adds error to the
        /// error provider if invalid input was provided by a user. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainCustomerAddressText_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(mainCustomerAddressText.Text))
                addressErrorProvider.SetError(this.mainCustomerAddressText, "Address is required.");
            else
                addressErrorProvider.SetError(this.mainCustomerAddressText, "");
        }

        /// <summary>
        /// This method performs validation of customer's phone and adds error to the
        /// error provider if invalid input was provided by a user. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainCustomerPhoneText_Validating(object sender, CancelEventArgs e)
        {
            String phoneNumber = mainCustomerPhoneText.Text.Trim();
            if (String.IsNullOrEmpty(phoneNumber))
                phoneErrorProvider.SetError(this.mainCustomerPhoneText, "Phone number is required.");
            else if(!Regex.Match(phoneNumber.Trim(), @"^[0-9]{10}$").Success)
                phoneErrorProvider.SetError(this.mainCustomerPhoneText, "Invalid phone number format.");
            else
                phoneErrorProvider.SetError(this.mainCustomerPhoneText, "");
        }

        /// <summary>
        /// Presents Yes/No dialog box to the user and returns true if user has 
        /// selected Yes button.
        /// </summary>
        /// <param name="msgText"></param>
        /// <returns></returns>
        private bool confirmExit(String msgText)
        {
            DialogResult result = MessageBox.Show(msgText, "Warning",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                return true;
            else 
                return false;
        } 
    }
}