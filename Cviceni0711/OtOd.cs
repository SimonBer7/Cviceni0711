using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni0711
{
    internal class OtOd
    {

        private string otazka;
        private string odpoved;

        public string Otazka
        {
            get { return otazka; }
            set { otazka = value; }
        }

        public string Odpoved
        {
            get { return odpoved; }
            set { odpoved = value; }
        }

        public OtOd(string otazka, string odpoved)
        {
            Otazka = otazka;
            Odpoved = odpoved;
        }

    }
}
