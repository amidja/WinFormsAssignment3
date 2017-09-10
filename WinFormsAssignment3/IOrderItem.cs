using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig3.Order
{
    /// Author:         <Jasmin Amidzic>
    /// <summary>
    /// Interface defining all methods/properties that must be implemented by an order item .
    /// 
    /// The class also define two categories of order items in the OrderItemType enum type.
    /// </summary>
    public interface IOrderItem
    {
        String Name {get;}

        String Description{get;}

        decimal Price {get;}

        String ItemType { get; }
    }

    public enum OrderItemType
    {
        [System.ComponentModel.Description("Pizza")] PIZZA,
        [System.ComponentModel.Description("Soft-drink")] SOFT_DRINK
    }
}
