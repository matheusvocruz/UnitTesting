using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses.PersonClasses
{
    public class PersonManager
    {
        public Person CreatePerson(string first, string last, bool isSupervisor)
        {
            Person per = null;

            if (!string.IsNullOrEmpty(first))
            {
                if (isSupervisor)
                {
                    per = new Supervisor();
                } else
                {
                    per = new Employee();
                }

                per.FirstName = first;
                per.LastName = last;
            }

            return per;
        }

        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();

            people.Add(new Person() { FirstName = "Matheus", LastName = "Cruz" });
            people.Add(new Person() { FirstName = "Victor", LastName = "Cruz" });
            people.Add(new Person() { FirstName = "Mathias", LastName = "Matos" });

            return people;
        }

        public List<Person> GetSupervisors()
        {
            List<Person> people = new List<Person>();

            people.Add(CreatePerson("Matheus", "Cruz", true));
            people.Add(CreatePerson("Victor", "Cruz", true));

            return people;
        }
    }
}
