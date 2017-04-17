using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab14
{
    class ParkingGarage
    {
        Level[] levels;

        public ParkingGarage(int numLevels)
        {
            levels = new Level[numLevels];
        }

        public Level GetLevel(int index)
        {
            Level l = levels[index];
            return l;
        }
    }
}
