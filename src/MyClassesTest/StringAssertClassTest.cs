using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace MyClassesTest
{
    [TestClass]
    public class StringAssertClassTest
    {
        [TestMethod]
        [Owner("Matheus")]
        public void ContainsTest()
        {
            string str1 = "Matheus Cruz";
            string str2 = "Cruz";

            StringAssert.Contains(str1, str2);
        }

        [TestMethod]
        [Owner("Matheus")]
        public void StartsWithTest()
        {
            string str1 = "Matheus Cruz";
            string str2 = "Matheus C";

            StringAssert.StartsWith(str1, str2);
        }

        [TestMethod]
        [Owner("Matheus")]
        public void IsAllLowerCaseTest()
        {
            Regex reg = new Regex(@"^([^A-Z])+$");
           
            StringAssert.Matches("matheus", reg);
        }

        [TestMethod]
        [Owner("Matheus")]
        public void IsNotAllLowerCaseTest()
        {
            Regex reg = new Regex(@"^([^A-Z])+$");

            StringAssert.DoesNotMatch("Matheus", reg);
        }
    }
}
