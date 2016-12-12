using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bataille_navale
{
    class Bateau
    {
        int column;
        int row;

        public int Column
        {
            get
            {
                return column;
            }
        }

        public int Row
        {
            get
            {
                return row;
            }
        }

        public Bateau()
        {
            Random randomObject = new Random();
            row = randomObject.Next(0, 6);
            column = randomObject.Next(0, 4);
        }
    }


}
