using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni0711
{
    internal class Policko
    {

        protected Player player = null;
        private Typ typ;


        public Policko(Typ t)
        {
            Typ = t;
        }

        public Typ Typ
        {
            get { return typ; }
            set { typ = value; }
        }
       
        public Player Player
        {
            get { return player; }
            set
            {
                player = value;
            }
        }

        public virtual bool SplnenUkol()
        {
            return true;
        }

        public override string ToString()
        {
            return " ";
        }




    }
}
