using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni0711
{
    internal class Enemy : Policko
    {

        public Enemy() : base(Typ.ENEMY)
        {
        }


        public override bool SplnenUkol()
        {
            player.MetEnemy();
            return false;
        }


        public override string ToString()
        {
            if(Player != null)
            {
                return "K";
            }
            return "E";
        }



    }
}
