using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni0711
{
    internal class Teleport : Policko
    {

        private Game hra;

        public Teleport(Game hra) : base(Typ.TELEPORT)
        {
            Hra = hra;
        }

        public Game Hra
        {
            get { return hra; }
            set { hra = value; }
        }

        public override bool SplnenUkol()
        {
            Console.WriteLine("@ Slapnul/a jste na teleport @\nSTISTKNETE JAKOUKOLI KLAVESU");
            Console.ReadKey();

            Random rnd = new Random();
            int tmp = rnd.Next(0, 4);
            switch (tmp)
            {
                case 0:
                    Hra.PohniPlayerem(Smer.DOLEVA);
                    break;

                case 1:
                    Hra.PohniPlayerem(Smer.DOPRAVA);
                    break;

                case 2:
                    Hra.PohniPlayerem(Smer.NAHORU);
                    break;

                case 3:
                    Hra.PohniPlayerem(Smer.DOLU);
                    break;
            }

            return true;
        }


        public override string ToString()
        {
            if(Player != null)
            {
                return "K";
            }
            return "@";
        }




    }
}
