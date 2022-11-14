using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni0711
{
    internal class Zed : Policko
    {

        public Zed() : base(Typ.ZED)
        {
        }

        public override string ToString()
        {
            if(Player != null)
            {
                return "K";
            }

            return "X";
        }


    }
}
