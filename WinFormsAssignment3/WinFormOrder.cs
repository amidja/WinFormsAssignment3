using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assig3.Order;
using System.Diagnostics;

namespace WinFormsAssignment3
{
    /// Author:         <Jasmin Amidzic>
    /// <summary>
    /// Windows Form class used to manage customer's order.
    /// </summary>
    public partial class WinFormOrder : Form
    {
        private Form parentForm;
        private Order customerOrder;
        private BindingSource bs = new BindingSource();

        /// <summary>
        /// Form constructor
        /// </summary>
        /// <param name="parentForm"></param>
        /// <param name="newOrder"></param>
        public WinFormOrder(Form parentForm, Order newOrder)
        {
            this.parentForm = parentForm;
            this.customerOrder = newOrder;
            InitializeComponent();
        }

        private void WinFormOrder_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("... Order Form in Load event!");
            // Initialize the DataGridView.
            bs.DataSource = typeof(OrderItem);
            //bs.DataSource = customerOrder.getItems();
            orderDataGridView.AutoGenerateColumns = false;
            orderDataGridView.DataSource = bs;

            // Initialize and add a text box column.
            DataGridViewColumn columnName = new DataGridViewTextBoxColumn();
            columnName.DataPropertyName = "Name";
            columnName.Name = "Name";
            orderDataGridView.Columns.Add(columnName);

            // Initialize and add a text box column.
            DataGridViewColumn columnDescription = new DataGridViewTextBoxColumn();
            columnDescription.DataPropertyName = "Description";
            columnDescription.Name = "Description";
            orderDataGridView.Columns.Add(columnDescription);

            // Initialize and add a text box column.
            DataGridViewColumn columnItemType = new DataGridViewTextBoxColumn();
            columnItemType.DataPropertyName = "ItemType";
            columnItemType.Name = "Item Type";
            orderDataGridView.Columns.Add(columnItemType);

            // Initialize and add a text box column.
            DataGridViewColumn columnPrice = new DataGridViewTextBoxColumn();
            columnPrice.DataPropertyName = "Price";
            columnPrice.Name = "Price";
            columnPrice.DefaultCellStyle.Format = "c";
            orderDataGridView.Columns.Add(columnPrice);

            //Add Order Info to the form labels
            this.labelOrderInfo.Text += customerOrder.OrderId + " for " + customerOrder.OrderCustomer.Name;

            if (customerOrder.OrderDeliveryType == Assig3.Restaurant.DeliveryType.DELIVERY)
                this.labelOrderType.Text = "Type: Delivery";
            else
                this.labelOrderType.Text = "Type: Pick-up";

            labelOrderCost.Text = customerOrder.getOrderPrice().ToString("C");
        }


        /// <summary>
        /// This method calls WinFormStandardItems form as a dialog and 
        /// on return from the form presents all items stored in the order in 
        /// the data grid view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderStdPizzaBtn_Click(object sender, EventArgs e)
        {
            WinFormStandardItems winFormStandardPizza = new WinFormStandardItems(this, customerOrder);
            winFormStandardPizza.ShowDialog();
            bs.Clear();
            foreach (OrderItem orderItem in customerOrder.getItems())
            {
                bs.Add(orderItem);
                Debug.WriteLine($"... adding order item to the list {orderItem.Name}!");
            }
            labelOrderCost.Text = customerOrder.getOrderPrice().ToString("C");
        }

        /// <summary>
        /// This method calls WinFormStandardItems form as a dialog and 
        /// on return from the form presents all items stored in the order in 
        /// the data grid view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderCustomPizzaBtn_Click(object sender, EventArgs e)
        {
            WinFormCustomPizza winFormCustomPizza = new WinFormCustomPizza(this, customerOrder);
            winFormCustomPizza.ShowDialog();
            bs.Clear();
            foreach (OrderItem orderItem in customerOrder.getItems())
            {
                bs.Add(orderItem);
                Debug.WriteLine($"... adding order item to the list {orderItem.Name}!");
            }
            labelOrderCost.Text = customerOrder.getOrderPrice().ToString("C");
        }

        /// <summary>
        /// Allows for deletion order items using the data grid view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            int tmpId = (int)e.Row.Index;

            customerOrder.clearItems();
            foreach (OrderItem item in bs.List)
            {
                customerOrder.addItem(item);
            }
            labelOrderCost.Text = customerOrder.getOrderPrice().ToString("C");

        }

        /// <summary>
        /// Simple checkout message dialog box that displayes the total worth of the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderRequestBtn_Click(object sender, EventArgs e)
        {
            String caption = "Lenny's Large Pizza";
            String msgText = "The total worth of your order is " + customerOrder.getOrderPrice().ToString("C");
            msgText += "\nWould you like to place this order?";

            DialogResult dialogResult = MessageBox.Show(msgText, caption, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                parentForm.Show();
                this.Close();
            }
        }

        /// <summary>
        /// Cancel the order and return to the main window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderCancelBtn_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

    }
}

