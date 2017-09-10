using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsAssignment3;

namespace SimpleUnitTestProject
{
    [TestClass]
    public class UnitTestEnumHelper
    {
        [TestMethod]
        public void TestMethod2()
        {
            String pizaBaseTypeStr = EnumHelper.ToDescription(PizzaBase.PizzaBaseType.REGULAR);
            Assert.AreEqual("Regular", pizaBaseTypeStr);
        }

        [TestMethod]
        public void TestMethod1()
        {
            string[][] cases ={
                new string[] {null, string.Empty},
                new string[] {string.Empty, string.Empty},
                new string[] {" ", string.Empty},
                new string[] {"A", "A"},
                new string[] {"z", "Z"},

                new string[] {"Pascal", "Pascal"},
                new string[] {"camel", "Camel"},

                new string[] {"PascalCase", "Pascal Case"},
                new string[] {"ABCPascal", "ABC Pascal"},
                new string[] {"PascalABC", "Pascal ABC"},
                new string[] {"Pascal123", "Pascal 123"},
                new string[] {"Pascal123ABC", "Pascal 123 ABC"},
                new string[] {"PascalABC123", "Pascal ABC 123"},
                new string[] {"123Pascal", "123 Pascal"},
                new string[] {"123ABCPascal", "123 ABC Pascal"},
                new string[] {"ABC123Pascal", "ABC 123 Pascal"},

                new string[] {"camelCase", "Camel Case"},
                new string[] {"camelABC", "Camel ABC"},
                new string[] {"camel123", "Camel 123"},
            };

            foreach (string[] givens in cases)
            {
                string input = givens[0];
                string expected = givens[1];
                string output = StringHelper.ToFriendlyName(input);

                Assert.AreEqual(expected, output);
            }

        }
    }
}
