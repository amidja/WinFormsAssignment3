using System;
using WinFormsAssignment3;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleUnitTestProject
{
    [TestClass]
    public class UnitTestEnumTypes
    {
        [TestMethod]
        public void TestEnumsMethod1()
        {

            foreach (PizzaTopping.PizzaToppingType toppingType in Enum.GetValues(typeof(PizzaTopping.PizzaToppingType)))
            {
                Debug.Print(@" topping type ${toppingType.ToString()}");
                String description = EnumHelper.ToDescription(toppingType);
                Debug.Print(@" topping type description ${description}");
            }
                
        }
    }
}
