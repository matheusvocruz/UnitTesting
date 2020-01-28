using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;
using MyClasses.PersonClasses;

namespace MyClassesTest
{
    [TestClass]
    public class AssertClassTest
    {
        #region AreEqual/AreNotEqual Tests
        [TestMethod]
        [Owner("Matheus")]
        public void AreEqualTest()
        {
            string str1 = "Matheus";
            string str2 = "Matheus";

            Assert.AreEqual(str1, str2);
        }

        [TestMethod]
        [Owner("Matheus")]
        public void AreNotEqualTest()
        {
            string str1 = "Matheus";
            string str2 = "matheus";

            Assert.AreNotEqual(str1, str2);
        }

        [TestMethod]
        [Owner("Matheus")]
        [ExpectedException(typeof(AssertFailedException))]
        public void AreEqualCaseSensitiveTest()
        {
            string str1 = "Matheus";
            string str2 = "matheus";

            Assert.AreEqual(str1, str2, false);
        }

        #endregion AreEqual/AreNotEqual Tests

        #region AreSame/AreNotSame Tests
        [TestMethod]
        [Owner("Matheus")]
        public void AreSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = x;

            Assert.AreSame(x, y);
        }

        [TestMethod]
        [Owner("Matheus")]
        public void AreNotSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = new FileProcess();

            Assert.AreNotSame(x, y);
        }
        #endregion

        #region IsInstanceOfType Tests
        [TestMethod]
        [Owner("Matheus")]
        public void IsInstanceOfTypeTest()
        {
            PersonManager mgr = new PersonManager();
            Person per;

            per = mgr.CreatePerson("Matheus", "Cruz", true);

            Assert.IsInstanceOfType(per, typeof(Supervisor));
        }

        [TestMethod]
        [Owner("Matheus")]
        public void IsNullTest()
        {
            PersonManager mgr = new PersonManager();
            Person per;

            per = mgr.CreatePerson("", "Cruz", true);

            Assert.IsNull(per);
        }
        #endregion IsInstanceOfType Tests
    }
}
