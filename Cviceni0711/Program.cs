namespace Cviceni0711
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Inspiroval jsem se praci Ondreje Kulhaveho a snazil jsem se pochopit ten hlavni princip a o neco to inovovat.

            Game game = new Game();

            while (game.Running == true)
            {
                Console.Clear();
                game.Vypis();
                Console.WriteLine("Zadej pohyb (w = nahoru, s = dolu, a = doleva, d = doprava): ");
                string tmp = Console.ReadLine();

                game.PlayeruvMove(tmp);

            }

            Console.WriteLine();
            Console.WriteLine("Konec hry");




        }
    }
}