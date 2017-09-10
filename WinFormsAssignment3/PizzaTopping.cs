using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace WinFormsAssignment3
{
    /// Author:         <Jasmin Amidzic>
    /// <summary>
    /// Representation of a pize topping allowing for a number of different topping types
    /// specifed by PizzaToppingType enum
    /// </summary>
    public class PizzaTopping
    {
        private PizzaToppingType name;

        public PizzaTopping(PizzaToppingType toppingType) 
        {
            name = toppingType;
        }

        public PizzaToppingType Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null)
                    throw new ArgumentException("topping  name cannot be null");

                this.name = value;
            }
        }

        public String Description
        {
            get
            {
                return EnumHelper.ToDescription(this.Name);
            }
        }

        public static PizzaToppingType toppingFromString(String topping)
        {

            foreach (PizzaTopping.PizzaToppingType toppingType in Enum.GetValues(typeof(PizzaTopping.PizzaToppingType)))
            {
            
                String description = EnumHelper.ToDescription(toppingType);
                if (description.Contains(topping))
                {
                    Debug.Print(@" topping type description ${description}");
                    return toppingType;
                }
            }

            throw new ArgumentException("Invalid topping type provided as argument");
        }

        public enum PizzaToppingType
        {
            [System.ComponentModel.Description("Cheese")] CHEESE,
            [System.ComponentModel.Description("Chicken")] CHICKEN,
            [System.ComponentModel.Description("Olives")] OLIVES,
            [System.ComponentModel.Description("Ham")] HAM,
            [System.ComponentModel.Description("Meatballs")] MEATBALLS,
            [System.ComponentModel.Description("Pineapple")] PINEAPPLE,
            [System.ComponentModel.Description("Pepperoni")] PEPPERONI,
            [System.ComponentModel.Description("Onions")] ONIONS,
            [System.ComponentModel.Description("Jalapenos")] JALAPENOS,
            [System.ComponentModel.Description("Anchovies")] ANCHOVIES,
            [System.ComponentModel.Description("Mushrooms")] MASHROOMS

        }
    }

  
}
