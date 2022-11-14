using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni0711
{
    internal class Game
    {

        private Policko[,] mapa;
        private int xPlayer;
        private int yPlayer;
        private int rozmer = 8;
        private bool running = true;


        public Policko[,] Mapa
        {
            get { return mapa; }
            set { mapa = value; }
        }

        public int XPlayer
        {
            get { return xPlayer; }
            set { xPlayer = value; }
        }

        public int YPlayer
        {
            get { return yPlayer; }
            set { yPlayer = value; }
        }

        public int Rozmer
        {
            get { return rozmer; }
            set
            {
                rozmer = value;
            }
        }

        public bool Running
        {
            get { return running; }
            set
            {
                running = value;
            }
        }

        public Game()
        {
            GameMap();
            AddPlayer();
            AddSpecialPolicko(new Enemy());
            AddSpecialPolicko(new Chaloupka());
        }




        public void AddPlayer()
        {
            Random rnd = new Random();
            int x = rnd.Next(0, rozmer);
            int y = rnd.Next(0, rozmer);

            if (!(mapa[x, y].Typ == Typ.ZED))
            {
                mapa[x, y] = new Domecek();
                mapa[x, y].Player = new Player();
                XPlayer = x;
                YPlayer = y;
                Console.WriteLine(mapa[x, y].Player);
            }
            
            else AddPlayer();
        }



        public void AddSpecialPolicko(Policko p)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, rozmer);
            int y = rnd.Next(0, rozmer);

            if (!(mapa[x, y].Typ == Typ.ZED))
            {
                mapa[x, y] = p;
            }
            else
            {
                AddPlayer();
            }

        }



        private void GameMap()
        {
            Random random = new Random();
            mapa = new Policko[rozmer, rozmer];


            for (int i = 0; i < mapa.GetLength(0); i++)
            {
                for (int j = 0; j < mapa.GetLength(1); j++)
                {   
                    if (i == 0 || i == mapa.GetLength(0) - 1 || j == 0 || j == mapa.GetLength(1) - 1)
                        mapa[i, j] = new Zed();

                    else
                    {
                        int nahodneCislo = random.Next(0, 13);
                        switch (nahodneCislo)
                        {
                            case 0:
                                mapa[i, j] = new Vyhlidka();
                                break;
                            case 1:
                                mapa[i, j] = new Teleport(this);
                                break;
                            case 2:
                                mapa[i, j] = new Louka();
                                break;
                            case 3:
                                mapa[i, j] = new Prekazka();
                                break;
                            case 4:
                                mapa[i, j] = new Vyhlidka();
                                break;

                            default:
                                mapa[i, j] = new Trava();
                                break;
                        }
                    }

                }
            }
        }


        private void Move(int x, int y, Player karkulka)
        {
            
            mapa[XPlayer, YPlayer].Player = null;
            YPlayer = YPlayer + y;
            XPlayer = XPlayer + x;
            mapa[XPlayer, YPlayer].Player = karkulka;
        }


        public void PohniPlayerem(Smer s)
        {
            Player p = mapa[XPlayer, YPlayer].Player;

            switch (s)
            {
                case Smer.NAHORU:
                    if (Mapa[XPlayer - 1, YPlayer].Typ == Typ.ZED)
                        throw new Exception("Karkulka se nemuze pohnout zvolenym smerem");
                    else
                        Move(-1, 0, p);
                    Running = mapa[XPlayer, YPlayer].SplnenUkol();
                    break;

                case Smer.DOLU:
                    if (Mapa[XPlayer + 1, YPlayer].Typ == Typ.ZED)
                        throw new Exception("Karkulka se nemuze pohnout zvolenym smerem");
                    else
                        Move(1, 0, p);
                    Running = mapa[XPlayer, YPlayer].SplnenUkol();
                    break;

                case Smer.DOLEVA:
                    if (Mapa[XPlayer, YPlayer - 1].Typ == Typ.ZED)
                        throw new Exception("Karkulka se nemuze pohnout zvolenym smerem");
                    else
                        Move(0, -1, p);
                    Running = mapa[XPlayer, YPlayer].SplnenUkol();
                    break;

                case Smer.DOPRAVA:
                    if (Mapa[XPlayer, YPlayer + 1].Typ == Typ.ZED)
                        throw new Exception("Karkulka se nemuze pohnout zvolenym smerem");
                    else
                        Move(0, 1, p);
                    Running = mapa[XPlayer, YPlayer].SplnenUkol();
                    break;

                default:
                    throw new Exception("Error, neznamy smer");
            }
        }



        public void PlayeruvMove(string smer)
        {
            if (smer.Equals("w"))
                PohniPlayerem(Smer.NAHORU);
            else if (smer.Equals("s"))
                PohniPlayerem(Smer.DOLU);
            else if (smer.Equals("a"))
                PohniPlayerem(Smer.DOLEVA);
            else if (smer.Equals("d"))
                PohniPlayerem(Smer.DOPRAVA);
        }



        public void Vypis()
        {
            Console.Write("Darky: ");
            int pocetDarku = mapa[xPlayer, yPlayer].Player.PocetDarku;
            for (int i = 0; i < pocetDarku; i++)
            {
                Console.Write(" $ ");
            }
            Console.WriteLine();
            for(int i = 0; i < mapa.GetLength(0); i++)
            {
                for(int j = 0; j < mapa.GetLength(1); j++)
                {
                    Console.Write(mapa[i, j]+ " ");
                }
                Console.WriteLine();
            }

        }







    }
}
