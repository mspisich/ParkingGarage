using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab14
{
    class Bus : IVehicle
    {
        private int size;

        public Bus()
        {
            size = 15;
        }

        public int GetSize()
        {
            return size;
        }

        public void Park(Space s, Level l)
        {
            //jjjj
            int totalSpaces = l.GetSpaces();
            int emptySpots = 0;

            for (int i = 0; i < totalSpaces; i++)
            {
                if (s.GetIsFull() == false && this.size >= 2)
                {
                    emptySpots++;
                }
            }
            
        }
    }
}
}
