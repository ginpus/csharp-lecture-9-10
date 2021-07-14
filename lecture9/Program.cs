using System;

namespace lecture9
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*            var pranas = new Person("Pranas", "Masiotas", 52);

                        pranas.SetName("Algis");

                        var tv = new TV();

                        tv.ToggleOnOff();

                        var book = new Book();

                        book.Title = "Haris Poteris";

                        Console.WriteLine(book.BookName);

                        var father = new Father("Tevukas");

                        father.SayHello();

                        var son = new Son("Sunelis", 15);

                        son.SayName();
                        father.SayName();*/

            /*            var karalyste = new Karalyste();
                        var seima = new Seima();
                        var rusis = new Rusis();

                        *//*            karalyste.SayHello();
                                    seima.SayHello();
                                    rusis.SayHello();*/

            /*            var naujaKaralyste = new Karalyste("gyvunai");
                        var naujaSeima = new Seima("homidai");*//*
            var naujaRusis = new Rusis("homo sapiens", "homidai", "gyvunai");*/

            /*            var motociklas = new Motociklas(600, "Street", 2, "Honda", "Raudonas");
                        motociklas.Judeti(); // Transporto priemones metodas (bendras)
                        motociklas.AntVieno(); // motociklo metodas (specifinis)

                        motociklas.GiveStatus();
                        Console.WriteLine("iskvieciu dauzau:");
                        motociklas.Dauzau(true);
                        motociklas.GiveStatus();*/

            var studentas1 = new Studentas("365489", "Antanas", "Sukodaitis");
            var studentas2 = new Studentas("Janina", "Bekodaitiene");

            studentas1.GetName();
            studentas1.GetSurName();
            studentas1.GetInfo();
            studentas1.GiveNumber();
            Console.WriteLine("numerio keitimas");
            studentas1.ChangeNumber("123456");
            //studentas1.GetInfo();

            studentas2.GetName();
            studentas2.GetSurName();
            studentas2.GetInfo();
            studentas2.GiveNumber();
            Console.WriteLine("numerio idejimas");
            studentas2.ChangeNumber("654321");
            studentas2.GetInfo();

            // galim konvertuoti studenta i asmeni. Upcastingas
            Asmuo fuksas = (Asmuo)studentas1;
            studentas1.GetInfo();
            fuksas.GetInfo();

            // downcastingas
            var velStudentas = (Studentas)studentas1;
            studentas1.GetInfo();
        }
    }
}