using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAssignment3;

namespace Assig3.Order
{
    /// Author:         <Jasmin Amidzic>
    /// <summary>
    /// Abstract class that all classes implementing IOrderItem should extend from.
    /// 
    /// The class also define worth for different types of order items that are used in 
    /// calculations of item's price.
    /// </summary>
    public abstract class OrderItem : IOrderItem
    {
        protected  const decimal STANDARD_PIZZA_WITH_REG_BASE = 14m;
        protected const decimal STANDARD_PIZZA_WITH_GLTFREE_BASE = 16m;
        protected const decimal CUSTOM_PIZZA_WITH_REG_BASE = 16m;
        protected const decimal CUSTOM_PIZZA_WITH_GLTFREE_BASE = 18m;

        protected const decimal SOFTDRINK_STANDARD = 4m;
        protected const decimal SOFTDRINK_LARGE = 6m;

        private decimal cost;

        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract string ItemType { get; }
        protected abstract decimal getItemPrice();


        /// <summary>
        /// Implementation of the Price property using getItemPrice method that 
        /// must be implemented by each class that is extending from this class.
        /// </summary>
        public decimal Price
        {
            get
            {
                cost = this.getItemPrice();
                return this.cost;
            }
        }
    }
}