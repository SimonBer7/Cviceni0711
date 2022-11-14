using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni0711
{
    internal class Chaloupka : Policko
    {
        public Chaloupka() : base(Typ.CHALOUPKA)
        {
        }

        public override bool SplnenUkol()
        {

            if (player.NumberOfDarky() > 1 && player.EnemyBylRychlejsi == false)
            {
                Console.WriteLine("Gratulace, karkulka uspesne dosla k babicce :)");
            }
            else
            {
                Console.WriteLine("Fail, karkulka prohrala :(");
            }

            return false;
        }


        public override string ToString()
        {
            if(Player != null)
            {
                return "K";
            }


            return "C";
        }

    }
}
