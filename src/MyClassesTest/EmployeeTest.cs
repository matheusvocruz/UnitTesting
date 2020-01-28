using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses.PersonClasses;

namespace MyClassesTest
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        [Owner("Matheus")]
        public void DoEmployeeExistTest()
        {
            Supervisor super = new Supervisor();

            super.Employees = new List<Employee>();
            super.Employees.Add(new Employee()
            {
                FirstName = "Matheus",
                LastName = "Cruz"
            });

            Assert.IsTrue(super.Employees.Count > 0);
        }
    }
}
