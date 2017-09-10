using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assig3.Order;

namespace WinFormsAssignment3
{
    public class Drink : OrderItem
    {
        private String name;
        private DrinkSize size;

        public Drink(String name, DrinkSize drinkSize)
        {
            this.name = name;
            this.size = drinkSize;
        }

        public DrinkSize Size
        {
            get{return size;}
        }

        public override String Name
        {
            get{return this.name;}
        }

        public override String Description
        {
            get{return EnumHelper.ToDescription(this.size);}
        }

        public override String ItemType
        {
            get { return EnumHelper.ToDescription(OrderItemType.SOFT_DRINK); }
        }

        protected override decimal getItemPrice()
        {
            if (this.Size == Drink.DrinkSize.LARG)
                return SOFTDRINK_LARGE;

            return SOFTDRINK_STANDARD;
        }

        public static DrinkSize sizeFromString(String drinkSize)
        {
            if (drinkSize.ToLower().Contains("1.25"))
                return DrinkSize.STANDARD;

            return DrinkSize.LARG;
        }


     

        public enum DrinkSize
        {
            [System.ComponentModel.Description("1.25 liters" )] STANDARD,
            [System.ComponentModel.Description("2 liters")] LARG,
        }
    }
}
