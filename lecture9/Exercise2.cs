using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture9
{
    internal class TransportoPriemone
    {
        /*        Klasės: TransportoPriemone, Masina, Sunkvezimis, Motociklas
        ● Bendri duomenys: ratų sk., markė, spalva
        ● Bendri netodai: Judeti(), Sustok(), Kairen(), Desinen()
        ● Kiekviena vaikinė klasė turi pridėti
        ○ bent du naujus laukus
        ○ bent du naujus metodus*/
        protected int _ratuSkaicius;
        protected string _marke;
        protected string _spalva;

        public void Judeti()
        {
            Console.WriteLine($"{this} Judu");
        }

        public void Sustok()
        {
            Console.WriteLine($"{this} Sustoju");
        }

        public void Kairen()
        {
            Console.WriteLine($"{this} Suku kairen");
        }

        public void Desinen()
        {
            Console.WriteLine($"{this} Suku desinen");
        }

        public TransportoPriemone(int ratuSkaicius, string marke, string spalva)
        {
            _ratuSkaicius = ratuSkaicius;
            _marke = marke;
            _spalva = spalva;
            Console.WriteLine($"Naujai sukurta transporto priemone su {ratuSkaicius} ratais, {marke} markes ir {spalva} spalvos");
        }
    }

    internal class Masina : TransportoPriemone
    {
        protected int _arklioGalios;
        protected string _kebulas;

        public void Lenkti()
        {
            Console.WriteLine($"{this} Lenkiu");
        }

        public void Rudiju()
        {
            Console.WriteLine($"{this} Rudiju");
        }

        public Masina(int arklioGalios, string kebulas, int ratuSkaicius, string marke, string spalva) : base(ratuSkaicius, marke, spalva)
        {
            _arklioGalios = arklioGalios;
            _kebulas = kebulas;
            _ratuSkaicius = ratuSkaicius;
            _marke = marke;
            _spalva = spalva;
            Console.WriteLine($"Naujai sukurta masina {arklioGalios} arklio galiu ir {kebulas} kebulo");
        }
    }

    internal class Sunkvezimis : TransportoPriemone
    {
        protected int _mase;
        protected int _asiuSkaicius;

        public void Vezu()
        {
            Console.WriteLine($"{this} Vezu");
        }

        public void Velku()
        {
            Console.WriteLine($"{this} Velku");
        }

        public Sunkvezimis(int mase, int asiuSkaicius, int ratuSkaicius, string marke, string spalva) : base(ratuSkaicius, marke, spalva)
        {
            _mase = mase;
            _asiuSkaicius = asiuSkaicius;
            _ratuSkaicius = ratuSkaicius;
            _marke = marke;
            _spalva = spalva;
            Console.WriteLine($"Naujai sukurtas sukvezimis {mase} tonu mases ir {asiuSkaicius} asiu skaiciumi");
        }
    }

    internal class Motociklas : TransportoPriemone
    {
        protected int _kubatura;
        protected string _stilius;

        public void AntVieno()
        {
            Console.WriteLine($"{this} Vaziuoju ant vieno rato");
        }

        public void Svyru()
        {
            Console.WriteLine($"{this} Svyru ties posukiu");
        }

        public Motociklas(int kubatura, string stilius, int ratuSkaicius, string marke, string spalva) : base(ratuSkaicius, marke, spalva)
        {
            _kubatura = kubatura;
            _stilius = stilius;
            _ratuSkaicius = ratuSkaicius;
            _marke = marke;
            _spalva = spalva;
            Console.WriteLine($"Naujai sukurtas motociklas {kubatura} kubaturos variklio ir {stilius} stiliaus");
        }
    }
}