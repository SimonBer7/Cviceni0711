using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni0711
{
    internal class Vyhlidka : Policko
    {

    public Vyhlidka() : base(Typ.VYHLIDKA)
        {
        }

        public override bool SplnenUkol()
        {
            Console.WriteLine("Nachazite se na vyhlidce, pozastvte se promyslete si dalsi kroky :D");
            Console.Write("STIKNETE JAKOUKOLI KLAVESU");
            Console.ReadKey();


            return true;
        }

        public override string ToString()
        {
            if(Player != null)
            {
                return "K";
            }


            return "V";
        }
    }
}
