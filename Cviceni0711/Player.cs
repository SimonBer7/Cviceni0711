using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni0711
{
    internal class Player
    {

        private bool sbirala = false;
        private bool enemyBylRychlejsi = false;
        private int pocetDarku = 2;

        public Player()
        {
        }
        
        public bool Sbirala
        {
            get { return sbirala; }
            set { sbirala = value; }
        }

        public int PocetDarku
        {
            get { return pocetDarku; }
            set { pocetDarku = value; }
        }

        public bool EnemyBylRychlejsi
        {
            get { return enemyBylRychlejsi; }
            set { enemyBylRychlejsi = value; }
        }



        public override string ToString()
        {
            return "Karkulka, pocet darku: " + pocetDarku;
        }


        public int NumberOfDarky()
        {
            return pocetDarku;
        }


        public int OdeberDarek()
        {
            pocetDarku = pocetDarku-1;
            return pocetDarku;
        }


        public void MetEnemy()
        {
            if (sbirala)
            {
                enemyBylRychlejsi = true;
            }
        }


    }
}
