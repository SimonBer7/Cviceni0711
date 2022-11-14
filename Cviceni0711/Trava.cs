using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni0711
{
    internal class Trava : Policko
    {

        public Trava() : base(Typ.TRAVA)
        {
        }


        public override string ToString()
        {
            if(Player != null)
            {
                return "K";
            }

            return "-";
        }



    }
}
