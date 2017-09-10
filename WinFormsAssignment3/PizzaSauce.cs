using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAssignment3
{
    /// Author:         <Jasmin Amidzic>
    /// <summary>
    /// Representation of a pize sauce allowing for two types of base: regular and gluten-free; 
    /// </summary>
    public class PizzaSauce
    {
        private PizzaSauceType flavour;

        public PizzaSauce()
        {
            flavour = PizzaSauceType.TOMATO;
        }

        public PizzaSauceType Flavour
        {
            get
            {
                return this.flavour;
            }

            set
            {
                if (value == null)
                    throw new ArgumentException("pizza sauce cannot be null");

                this.flavour = value;
            }
        }

        public enum PizzaSauceType
        {
            [System.ComponentModel.Description("Tomato")] TOMATO,
            [System.ComponentModel.Description("Barbecue")] BARBECUE
        }
    }

    
}
