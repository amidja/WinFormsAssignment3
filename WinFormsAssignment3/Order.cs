using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assig3.Restaurant;
using WinFormsAssignment3;

namespace Assig3.Order
{
    /// Author:         <Jasmin Amidzic>
    /// <summary>
    /// This class represents customer's order.
    /// </summary>
    public class Order
    {
        private int orderId;
        private Customer customer;
        public DeliveryType OrderDeliveryType { get; set; }
        private List<OrderItem> orderItems;

        public Order(Customer customer)
        {
            if (customer == null)
                throw new ArgumentException("order cannot be created without customer object");

            Random rnd = new Random();
            orderId = rnd.Next();
            this.customer = customer;
            OrderDeliveryType = DeliveryType.PICKUP;
            orderItems = new List<OrderItem>(1);
        }

        public void clearItems()
        {
            orderItems = new List<OrderItem>(1);
        }

        public void addItem(OrderItem orderItem)
        {
            orderItems.Add(orderItem);
        }

        public List<OrderItem> getItems()
        {
            return orderItems;
        }

        public int OrderId
        {
            get{return this.orderId;}
        }

        public Customer OrderCustomer
        {
            get{return this.customer;}
        }

        /// <summary>
        /// Calculates the total worth of the order 
        /// </summary>
        /// <returns>Price of the order</returns>
        public decimal getOrderPrice()
        {
            decimal price = 0m;

            //add surcharge for delivery
            if (this.OrderDeliveryType == DeliveryType.DELIVERY)
                price += 5m;

            foreach(OrderItem orderItem in orderItems){
                price += orderItem.Price;
            }

            return price;
        }
    }
}