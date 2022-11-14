using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni0711
{
    internal class Domecek : Policko
    {
        public Domecek() : base(Typ.DOMECEK)
        {
        }


        public override string ToString()
        {
            if(Player != null)
            {
                return "K";
            }

            return "D";
        }


    }
}
