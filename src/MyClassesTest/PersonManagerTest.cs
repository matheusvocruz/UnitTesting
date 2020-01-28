using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses.PersonClasses;

namespace MyClassesTest
{
    [TestClass]
    public class PersonManagerTest
    {
        [TestMethod]
        [Owner("Matheus")]
        public void CreatePerson_OfTypeemployeeTest()
        {
            PersonManager pmr = new PersonManager();
            Person per;

            per = pmr.CreatePerson("Matheus", "Cruz", false);

            Assert.IsInstanceOfType(per, typeof(EmployeeTest));
        }
    }
}
