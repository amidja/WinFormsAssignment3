using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAssignment3
{
    /// Author:         <Jasmin Amidzic>
    /// <summary>
    /// Representation of a pize base allowing for two types of base: regular and gluten-free; 
    /// </summary>
    public class PizzaBase
    {
        private PizzaBaseType style;

        public PizzaBase()
        {
            style = PizzaBaseType.REGULAR;
        }

        public PizzaBaseType Style
        {
            get
            {
                return style;
            }

            set
            {
                if (value == null)
                    throw new ArgumentException("style cannot be null");

                this.style = value;
            }
        }

  
        public static PizzaBaseType baseFromString(String baseType)
        {
            
            if (baseType.ToLower().Contains("gluten"))
            {
                return PizzaBaseType.GLUTEN_FREEE;
            }
            return PizzaBaseType.REGULAR;
        }

        public enum PizzaBaseType
        {
            [System.ComponentModel.Description("Regular")] REGULAR,
            [System.ComponentModel.Description("Gluten-Free")] GLUTEN_FREEE
        }
    }
}