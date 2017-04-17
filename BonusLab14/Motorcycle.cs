using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab14
{
    class Motorcycle : IVehicle
    {
        private int size;

        public Motorcycle()
        {
            size = 0;
        }

        public int GetSize()
        {
            return size;
        }

        public void Park(Space s)
        {
            //Space must not be full
            if (s.GetIsFull() == false)
            {
                s.SetIsFull(true);
            }
        }
    }
}
