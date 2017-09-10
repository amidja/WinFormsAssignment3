using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assig3.Order;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsAssignment3
{
    /// Author:         <Jasmin Amidzic>
    /// <summary>
    /// Allows customers to create their own pizza and add it to the order.
    /// </summary>
    public partial class WinFormCustomPizza : Form
    {
        private Form parentForm;
        private Order customerOrder;
        private Pizza customPizza;
        BindingSource bs;

     
        public WinFormCustomPizza (Form parentForm, Order custOrder)
        {
            this.parentForm = parentForm;
            this.customerOrder = custOrder;
            bs = new BindingSource(); ;
            bs.DataSource = typeof(PizzaTopping);
            InitializeComponent();
        }

        /// <summary>
        /// Initialise form's components and create pizza object 
        /// to be added to the order. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinFormCustomPizza_Load(object sender, EventArgs e)
        {
            //Initialize Base and Souce RadioButtons
            this.pizzaBaseRbGltRegular.Select();
            this.pizzaSauceRbTomato.Select();

            //Initialize toppings combo box
            foreach (PizzaTopping.PizzaToppingType toppingType in Enum.GetValues(typeof(PizzaTopping.PizzaToppingType)))
            {
                String description = EnumHelper.ToDescription(toppingType);
                pizzaToppingsCbox.Items.Add(description);
                Debug.Print(@" topping type description ${description}");
            }

            // Initialize the DataGridView. 
            pizzaToppingsDataGridView.AutoGenerateColumns = false;
            pizzaToppingsDataGridView.DataSource = bs;

            // Initialize and add a text box column.
            DataGridViewColumn columnDescription = new DataGridViewTextBoxColumn();
            columnDescription.DataPropertyName = "Description";
            columnDescription.Name = "Pizza Topping";
            pizzaToppingsDataGridView.Columns.Add(columnDescription);

            //Create new pizza object that can be added to the order 
            String pizzaName = customerOrder.OrderCustomer.Name + "'s Pizza";
            customPizza = new Pizza(pizzaName, Pizza.PizzaType.CUSTOM);
            customPizza.setPizzaBase(PizzaBase.PizzaBaseType.REGULAR);
            customPizza.setPizzaSauce(PizzaSauce.PizzaSauceType.TOMATO);
        }

        /// <summary>
        /// Performs basic validation on user selections and adds 
        /// the custom pizza to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addToOrderBtn_Click(object sender, EventArgs e)
        {
            if (this.pizzaBaseRbGltFree.Checked)
                customPizza.setPizzaBase(PizzaBase.PizzaBaseType.GLUTEN_FREEE);

            if (this.pizzaSauceRbBBQ.Checked)
                customPizza.setPizzaSauce(PizzaSauce.PizzaSauceType.BARBECUE);

            //Make sure customer has selected at least one topping
            if (bs.Count <= 0)
            {
                String caption = "Lenny's Large Pizza";
                String msgText = "Please select at least one topping for your pizza.";
                MessageBox.Show(msgText, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //add pizza to the order and return the parent form
            foreach (PizzaTopping item in bs.List)
                customPizza.addPizzaTopping(item);

            customerOrder.addItem(customPizza);
            this.Close();
        }

        /// <summary>
        /// Closes the window form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pizzaChefCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Adds selected topping to the pizza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pizzaToppingsBtn_Click(object sender, EventArgs e)
        {
            Object selectedItem = pizzaToppingsCbox.SelectedItem;
            if (selectedItem != null)
            {
                if (bs.Count >= Pizza.MAX_NO_TOPPINGS)
                {
                    String caption = "Lenny's Large Pizza";
                    String msgText = "You can only add up to" + Pizza.MAX_NO_TOPPINGS + " toppings to your pizza.";
                    MessageBox.Show(msgText, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PizzaTopping.PizzaToppingType pizzaToppingType = PizzaTopping.toppingFromString((String)selectedItem);
                PizzaTopping pizzaTopping = new PizzaTopping(pizzaToppingType);
                bs.Add(pizzaTopping);
            }
        }
    }
}
