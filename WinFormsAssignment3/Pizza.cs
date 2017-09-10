using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assig3.Order;

namespace WinFormsAssignment3
{
    /// Author:         <Jasmin Amidzic>
    /// <summary>
    /// This class represents pizza 
    /// </summary>
    public class Pizza : OrderItem
    {
        public static int MAX_NO_TOPPINGS = 5;

        private String name;
        private PizzaType pizzaType;
        private PizzaBase pizzaBase;
        private PizzaSauce pizzaSauce;
        private List<PizzaTopping> pizzaToppings;

        public Pizza(String name, PizzaType pizzaType)
        {
            this.name = name;
            this.pizzaToppings = new List<PizzaTopping>();
            this.pizzaBase = new PizzaBase();
            this.pizzaSauce = new PizzaSauce();
            this.pizzaType = pizzaType;
        }

        public override  String Name
        {
            get{return this.name;}
        }

        public override String Description
        {
            get {return EnumHelper.ToDescription(this.pizzaType) ;}
        }

        public override String ItemType
        {
            get { return EnumHelper.ToDescription(OrderItemType.PIZZA); }
        }

        protected override decimal getItemPrice()
        {
            if (this.pizzaType == PizzaType.STANDARD)
            {
                if (this.pizzaBase.Style == PizzaBase.PizzaBaseType.GLUTEN_FREEE)
                    return STANDARD_PIZZA_WITH_GLTFREE_BASE;
                else
                    return STANDARD_PIZZA_WITH_REG_BASE;
            }
            else
            {
                if (this.pizzaBase.Style == PizzaBase.PizzaBaseType.GLUTEN_FREEE)
                    return CUSTOM_PIZZA_WITH_GLTFREE_BASE;
                else
                    return CUSTOM_PIZZA_WITH_REG_BASE;
            }
        }

        public void addPizzaTopping(PizzaTopping.PizzaToppingType pizzaToppingType)
        {
            addPizzaTopping(new PizzaTopping(pizzaToppingType));
        }

        public void addPizzaTopping(PizzaTopping pizzaTopping)
        {
            if (pizzaToppings.Count >= MAX_NO_TOPPINGS)
            {
                throw new ArgumentException("Pizza cannot have more then " + MAX_NO_TOPPINGS + " toppings");
            }
            pizzaToppings.Add(pizzaTopping);
        }

        public void setPizzaSauce(PizzaSauce.PizzaSauceType pizzaSauceType)
        {
            this.pizzaSauce = new PizzaSauce();
            this.pizzaSauce.Flavour = pizzaSauceType;
        }

        public void setPizzaBase(PizzaBase.PizzaBaseType pizzaBaseType)
        {
            this.pizzaBase = new PizzaBase();
            this.pizzaBase.Style = pizzaBaseType;
        }

        public  enum PizzaType
        {
            [System.ComponentModel.Description("Standard")] STANDARD,
            [System.ComponentModel.Description("Custom Pizza")] CUSTOM,
        }
    }
}
