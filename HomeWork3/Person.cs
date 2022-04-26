using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthTime { get; set; }
        public string Hobby { get; set; }
        public bool Gender { get; set; }

        public int GetAge()
        {
            return DateTime.Now.Year - BirthTime.Year;
        }
        public void Greeting()
        {
            Console.WriteLine($"Hello my name is {FirstName} {LastName}");
        }


    }
}
