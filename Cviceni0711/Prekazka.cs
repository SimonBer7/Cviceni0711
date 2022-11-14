using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni0711
{
    internal class Prekazka : Policko
    {

        List<OtOd> list = new List<OtOd>();

        public Prekazka() : base(Typ.PREKAZKA)
        {
            list.Add(new OtOd("Nejmensi stat je: ", "Vatikan"));
            list.Add(new OtOd("Nejvetsi stat je: ", "Rusko"));
            list.Add(new OtOd("Kolik je v CR kraju: ", "14"));
            list.Add(new OtOd("Hlavni mesto CR: ", "Praha"));
            list.Add(new OtOd("Hlavni mesto Slovenska: ", "Bratislava"));
            list.Add(new OtOd("Hlavni mesto Nemecka: ", "Berlin"));
            list.Add(new OtOd("Hlavni mesto Lotysska: ", "Riga"));

        }

        public override bool SplnenUkol()
        {
            Random rnd = new Random();

            int tmp = rnd.Next(0, list.Count);
            Console.WriteLine("? Stoji pred Vami prekazka v podobe otazky ?");
            Console.WriteLine("Otazka: " + list[tmp].Otazka);
            string odpoved = Console.ReadLine();
            if(odpoved == list[tmp].Odpoved)
            {
                Console.WriteLine("Spravna odpoved, dostali jste se uspesne pres prekazku :)");
                Console.Write("STIKNETE JAKOUKOLI KLAVESU");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Odpovedeli jste spatne :(");
                if(player.NumberOfDarky() > 0)
                {
                    Console.WriteLine("Ztrata jednoho darku :| ");
                    player.OdeberDarek();
                    Console.Write("STIKNETE JAKOUKOLI KLAVESU");
                    Console.ReadKey();
                }

            }


            return true;

        }





        public override string ToString()
        {
            if(Player != null)
            {
                return "K";
            }
            return "P";
        }

    }
}
