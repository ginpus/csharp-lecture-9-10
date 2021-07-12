using System;

namespace lecture9
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var pranas = new Person("Pranas", "Masiotas", 52);

            pranas.SetName("Algis");

            var tv = new TV();

            tv.ToggleOnOff();

            var book = new Book();

            book.Title = "Haris Poteris";

            Console.WriteLine(book.BookName);
        }
    }
}