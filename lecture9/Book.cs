using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture9
{
    internal class Book
    {
        private string _title; // private kintamieji zymimi su _ priekyje

        // setteriai ir geteriai - properciams naudojami, savyje turi metodus, kuriais gali buti ir nustatomi, ir grazinami
        public string Title
        {
            //get => _title; // kai get, grazink sito fieldo reiksme
            //set => _title = value; // kai get, grazint

            get { return _title; }
            set
            {
                _title = value;
                Console.WriteLine(_title);
            }
        }

        public string Author { get; set; } //lygiai tas pats kas:

        /*        private string _author;

                public string Author
                {
                    get => _author;
                    set => _author = value;
                }*/

        // galim apibrezti pradine verte sitai:
        public string BookName { get; set; } = "Harris Poteris ir Paslapciu Kambarys";
    }
}