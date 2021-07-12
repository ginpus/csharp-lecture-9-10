using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture9
{
    internal class Person
    {
        //private atributai liks klases visuje (nebus iskisti/panaudojami)
        private string Name;

        private string SurName;
        private int Age;

        public Person(string name, string surname, int age)
        {
            Name = name;
            SurName = surname;
            Age = age;
            Console.WriteLine($"Created person: {Name}, {SurName}, {Age}");
        }

        // tik su metodu public ir kas yra po juo mes galesim naudoti main'e (exposinti)
        public void SetName(string name)
        {
            Name = name;
            SayName(name);
        }

        public string GetName()
        {
            return Name;
        }

        public void SayName(string name)
        {
            Console.WriteLine($"Now the new name is {name} and the surname is {SurName}. Age is still the same - {Age}");
        }
    }
}