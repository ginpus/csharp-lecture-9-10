using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture9
{
    internal class Rusis : Seima
    {
        //Sukurti trijų lygių klasių hierarchiją: Pirmas, Antras, Trecias.Visos klasės turi tūrėti po du konstruktorius: default’ini ir su parametru/-ais.Keikvienas konstruktorius turi informuoti išvesdamas tekstą į konsolę, apie savo kurimą, jei konstruktorius su parametru, jis turi išvesti ir jo reikšmę.
        //Main metode sukurti kelis objektus klasiu: Pirmas, Antras, Trečias.
        private string _rusisName;

        private string _seimaName;
        private string _karalysteName;

        public Rusis()
        {
            Console.WriteLine($"{this}, Rusis buvau iskviestas be parametru");
        }

        public Rusis(string rusisname, string seimaname, string karalystename) : base(seimaname, karalystename)
        {
            _rusisName = rusisname;
            _seimaName = seimaname;
            _karalysteName = karalystename;
            Console.WriteLine($"{this}, Rusis buvau iskviestas su parametru {rusisname}");
        }
    }

    internal class Seima : Karalyste
    {
        private string _seimaName;
        private string _karalysteName;

        public Seima()
        {
            Console.WriteLine($"{this}, Seima buvau iskviestas be parametru");
        }

        public Seima(string seimaname, string karalystename) : base(karalystename)
        {
            _seimaName = seimaname;
            _karalysteName = karalystename;
            Console.WriteLine($"{this}, Seima buvau iskviestas su parametru {seimaname}");
        }
    }

    internal class Karalyste
    {
        private string _karalysteName;

        public Karalyste()
        {
            Console.WriteLine($"{this}, Karalyste buvau iskviestas be parametru");
        }

        public Karalyste(string karalystename)
        {
            _karalysteName = karalystename;
            Console.WriteLine($"{this}, Karalyste buvau iskviestas su parametru {karalystename}");
        }
    }
}