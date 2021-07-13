using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture9
{
    internal class Son : Father // paveldejimas vyksta i viena puse - sunus paveldi tevo, bet ne atvirksciai. pasiekiama viskas, kas po Father yra public. private yra nepasiekiamas
    {
        private int _age;

        public void GetMother()
        {
            Console.WriteLine($"Father's wife (and Sons mother) is {_wifesName}");
        }

        public Son(string name, int age) : base(name) // base nusako, kas perduoda teviniam konstruktoriui. kurdami ir sunu, mes sukuriam ir teva
        {
            _age = age;
        }
    }

    internal class Father
    {
        //private string _wifesName = "Zmona"; // nebus pasiekiamas
        protected string _wifesName = "Zmona";// protected leid=ia pasiekti tik paveldejusioje klaseje

        protected readonly string _name;

        public Father(string name)
        {
            _name = name;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello from old generation...");
        }

        public void SayName()
        {
            Console.WriteLine(_name);
        }
    }
}