using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni0711
{
    internal class Louka : Policko
    {

        public Louka() : base(Typ.LOUKA)
        {
        }


        public override bool SplnenUkol()
        {

            if (!player.Sbirala)
            {
                player.Sbirala = true;
                player.PocetDarku = player.PocetDarku + 1;
            }
            else
            {
                Console.WriteLine("Karkulka nemuze sbirat znovu");
                Console.Write("STIKNETE JAKOUKOLI KLAVESU");
                Console.ReadKey();
            }




            return true;
        }


        public override string ToString()
        {
            if(Player != null)
            {
                return "K";
            }
            return "L";
        }




    }
}
