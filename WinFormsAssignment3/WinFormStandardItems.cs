using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Assig3.Order;

namespace WinFormsAssignment3
{
    /// Author:         <Jasmin Amidzic>
    /// <summary>
    /// Presents a list of standard items that can be ordered and 
    /// allows customers to add any number of standard items to the order.
    /// </summary>
    public partial class WinFormStandardItems : Form
    {
        private Form parentForm;
        private Order customerOrder;
        BindingSource bs;
    
        public WinFormStandardItems(Form parentForm, Order custOrder)
        {
            this.parentForm = parentForm;
            this.customerOrder = custOrder;
            bs = new BindingSource(); ;
            bs.DataSource = typeof(OrderItem);
            InitializeComponent();
        }

        private void WinFormStandardPizza_Load(object sender, EventArgs e)
        {
            this.pepperoniBazeCbox.SelectedItem = "regular base";
            this.cheeseBazeCbox.SelectedItem = "regular base";
            this.hawaiianBazeCbox.SelectedItem = "regular base";
            this.cokeSizeCbox.SelectedItem = "1.25 liters";
            this.fantaSizeCbox.SelectedItem = "1.25 liters";

            // Initialize the DataGridView.
            standardPizzasDataGridView.AutoGenerateColumns = false;
            standardPizzasDataGridView.DataSource = bs;
           
            // Initialize and add a text box column.
            DataGridViewColumn columnName = new DataGridViewTextBoxColumn();
            columnName.DataPropertyName = "Name";
            columnName.Name = "Name";
            standardPizzasDataGridView.Columns.Add(columnName);

            // Initialize and add a text box column.
            DataGridViewColumn columnDescription = new DataGridViewTextBoxColumn();
            columnDescription.DataPropertyName = "Description";
            columnDescription.Name = "Description";
            standardPizzasDataGridView.Columns.Add(columnDescription);

            // Initialize and add a text box column.
            DataGridViewColumn columnItemType = new DataGridViewTextBoxColumn();
            columnItemType.DataPropertyName = "ItemType";
            columnItemType.Name = "Item Type";
            standardPizzasDataGridView.Columns.Add(columnItemType);

            // Initialize and add a text box column.
            DataGridViewColumn columnPrice = new DataGridViewTextBoxColumn();
            columnPrice.DataPropertyName = "Price";
            columnPrice.Name = "Price";
            columnPrice.DefaultCellStyle.Format = "c";
            standardPizzasDataGridView.Columns.Add(columnPrice);
            
        }

        /// <summary>
        /// Closes the window form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderStndPizzaCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Build Papperoni pizza and add it to the list of ordered items.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPepperoniBtn_Click(object sender, EventArgs e)
        {
            Object selectedItem = pepperoniBazeCbox.SelectedItem;
            PizzaBase.PizzaBaseType pizzaBaseType = PizzaBase.baseFromString((String)selectedItem);

            Pizza pepperoniPizza = new Pizza("Pepperoni", Pizza.PizzaType.STANDARD);
            pepperoniPizza.setPizzaBase(pizzaBaseType);
            pepperoniPizza.addPizzaTopping(PizzaTopping.PizzaToppingType.CHEESE);
            pepperoniPizza.addPizzaTopping(PizzaTopping.PizzaToppingType.OLIVES);
            pepperoniPizza.addPizzaTopping(PizzaTopping.PizzaToppingType.ONIONS);
            pepperoniPizza.addPizzaTopping(PizzaTopping.PizzaToppingType.PEPPERONI);
        
            bs.Add(pepperoniPizza);
            
        }

        /// <summary>
        /// Build Cheeze pizza and add it to the list of standard order items.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCheeseBtn_Click(object sender, EventArgs e)
        {
            Object selectedItem = cheeseBazeCbox.SelectedItem;
            PizzaBase.PizzaBaseType pizzaBaseType = PizzaBase.baseFromString((String)selectedItem);

            Pizza cheesePizza = new Pizza("Cheese", Pizza.PizzaType.STANDARD);
            cheesePizza.setPizzaBase(pizzaBaseType);
            cheesePizza.addPizzaTopping(PizzaTopping.PizzaToppingType.CHEESE);
            cheesePizza.addPizzaTopping(PizzaTopping.PizzaToppingType.CHEESE);
            cheesePizza.addPizzaTopping(PizzaTopping.PizzaToppingType.CHEESE);
            cheesePizza.addPizzaTopping(PizzaTopping.PizzaToppingType.OLIVES);
            cheesePizza.addPizzaTopping(PizzaTopping.PizzaToppingType.ONIONS);

            bs.Add(cheesePizza);
        }

        /// <summary>
        /// Build Hawaiian pizza and add it to the list of standard order items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addHawaiianBtn_Click(object sender, EventArgs e)
        {
            Object selectedItem = hawaiianBazeCbox.SelectedItem;
            PizzaBase.PizzaBaseType pizzaBaseType = PizzaBase.baseFromString((String)selectedItem);

            Pizza hawaiianPizza = new Pizza("Hawaiian", Pizza.PizzaType.STANDARD);
            hawaiianPizza.setPizzaBase(pizzaBaseType);
            hawaiianPizza.addPizzaTopping(PizzaTopping.PizzaToppingType.HAM);
            hawaiianPizza.addPizzaTopping(PizzaTopping.PizzaToppingType.PINEAPPLE);
            hawaiianPizza.addPizzaTopping(PizzaTopping.PizzaToppingType.CHEESE);
            hawaiianPizza.addPizzaTopping(PizzaTopping.PizzaToppingType.JALAPENOS);
            hawaiianPizza.addPizzaTopping(PizzaTopping.PizzaToppingType.ONIONS);

            bs.Add(hawaiianPizza);
        }

        /// <summary>
        /// Build Coke and add it to the list of standard order items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCokeBtn_Click(object sender, EventArgs e)
        {
            Object selectedItem = cokeSizeCbox.SelectedItem;
            Drink.DrinkSize drinkSizeType = Drink.sizeFromString((String)selectedItem);

            Drink coke = new Drink("Coca Cola", drinkSizeType);
            bs.Add(coke);
        }

        /// <summary>
        /// Build Fanta and add it to the list of standard order items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addFantaBtn_Click(object sender, EventArgs e)
        {
            Object selectedItem = fantaSizeCbox.SelectedItem;
            Drink.DrinkSize drinkSizeType = Drink.sizeFromString((String)selectedItem);

            Drink fanta = new Drink("Fanta", drinkSizeType);
            bs.Add(fanta);
        }

        /// <summary>
        /// Allows user to remove any of the items from the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeItemBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = standardPizzasDataGridView.CurrentRow;
            if (selectedRow != null)
            {
                 OrderItem selectedItem = (OrderItem)selectedRow.DataBoundItem;
                 if (selectedItem != null) 
                    bs.Remove(selectedItem);
            }
          
        }

        /// <summary>
        /// Gets newly selected items from the list adds them to the order and 
        /// returns to the parent form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderStndPizzaAddBtn_Click(object sender, EventArgs e)
        {         
            foreach (OrderItem orderItem in bs.List)
            {
                Debug.WriteLine($"... adding order item {orderItem.Name}!");
                customerOrder.addItem(orderItem);
            }
            parentForm.Show();
            this.Close();
        }
    }
}