using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses.PersonClasses;

namespace MyClassesTest
{
    [TestClass]
    public class CollectionAssertClassTest
    {
        //Force error
        [TestMethod] 
        [Owner("Matheus")]
        public void AreCollectionEqualFailsBecauseNoComparerTest()
        {
            PersonManager pmr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            peopleExpected.Add(new Person() { FirstName = "Matheus", LastName = "Cruz" });
            peopleExpected.Add(new Person() { FirstName = "Victor", LastName = "Cruz" });
            peopleExpected.Add(new Person() { FirstName = "Mathias", LastName = "Matos" });

            //Won't pass
            peopleActual = pmr.GetPeople();

            CollectionAssert.AreEqual(peopleExpected, peopleActual);
        }

        [TestMethod]
        [Owner("Matheus")]
        public void AreCollectionEqualWithComparerTest()
        {
            PersonManager pmr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            peopleExpected.Add(new Person() { FirstName = "Matheus", LastName = "Cruz" });
            peopleExpected.Add(new Person() { FirstName = "Victor", LastName = "Cruz" });
            peopleExpected.Add(new Person() { FirstName = "Mathias", LastName = "Matos" });

            peopleActual = pmr.GetPeople();

            CollectionAssert.AreEqual(peopleExpected, peopleActual, 
                Comparer<Person>.Create((x, y) => 
                    x.FirstName == y.FirstName && x.LastName == y.LastName ? 0 : 1)
            );
        }

        [TestMethod]
        [Owner("Matheus")]
        public void AreCollectionEquivalentTest()
        {
            PersonManager pmr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            peopleActual = pmr.GetPeople();

            peopleExpected.Add(peopleActual[1]);
            peopleExpected.Add(peopleActual[2]);
            peopleExpected.Add(peopleActual[0]);

            CollectionAssert.AreEquivalent(peopleExpected, peopleActual);
        }

        [TestMethod]
        [Owner("Matheus")]
        public void IsCollectionOfTypeTest()
        {
            PersonManager pmr = new PersonManager();
            List<Person> peopleActual = new List<Person>();

            peopleActual = pmr.GetSupervisors();

            CollectionAssert.AllItemsAreInstancesOfType(peopleActual, typeof(Supervisor));
        }
    }
}
