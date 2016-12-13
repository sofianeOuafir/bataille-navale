using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bataille_navale
{
    class Jeu
    {
        List<Bateau> bateaux;

        public List<Bateau> Bateaux
        {
            get
            {
                return bateaux;
            }
        }

        public Jeu(int nbBateaux)
        {
            List<String> tableau = new List<string>();
            int k = 0;
            for(var row = 0; row < 6; row++)
            {
                for(var col = 0; col < 4; col++)
                {
                    tableau.Add(row + "," + col);
                }
            }

            bateaux = new List<Bateau>();
            Random randomObject = new Random();
            int number;
            var interval = 24;
            for (var i = 0; i < nbBateaux; i++)
            {
                number = randomObject.Next(0, interval);
                Bateau unBateau = new Bateau(int.Parse(tableau[number].Split(',')[0]), int.Parse(tableau[number].Split(',')[1]));
                tableau.RemoveAt(number);
                interval--;
                bateaux.Add(unBateau);
            }
        }
    }
}
