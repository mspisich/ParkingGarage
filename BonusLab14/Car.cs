using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab14
{
    class Car : IVehicle
    {
        private int size;

        public Car(int s)
        {
            //1 is compact
            //2 is large
            if (s <= 2 && s >= 1)
            {
                size = s;
            }
            else
            {
                try
                {
                    throw new IndexOutOfRangeException();
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid size.");
                    size = -1;
                }
            }
        }

        public int GetSize()
        {
            return size;
        }

        public void Park(Space s)
        {
            //Space must not be full and car must be small enough to fit
            if (s.GetIsFull() == false && this.size <= s.GetSize())
            {
                s.SetIsFull(true);
            }
        }
    }
}
