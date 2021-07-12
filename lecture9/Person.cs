using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture9
{
    internal class Person
    {
        private string Name;
        private string SurName;
        private int Age;

        public Person(string name, string surname, int age)
        {
            Name = name;
            SurName = surname;
            Age = age;
        }

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
            Console.WriteLine(name);
        }
    }
}