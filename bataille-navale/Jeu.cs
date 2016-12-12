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
            bateaux = new List<Bateau>();
            for(var i = 0; i < nbBateaux; i++)
            {
                Bateau unBateau = new Bateau();
                bateaux.Add(unBateau);
            }
        }
    }
}
