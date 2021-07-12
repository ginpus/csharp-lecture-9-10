using System;

namespace lecture9
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var pranas = new Person("Pranas", "Masiotas", 52);

            pranas.SetName("Algis");
        }
    }
}