using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab14
{
    class Space
    {
        private bool isFull = false;
        int size;

        public Space(int s)
        {
            //Size 0 is for motorcycles
            //Size 1 is compact
            //Size 2 is large
            if (s < 3 && s >= 0)
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

        public bool GetIsFull()
        {
            return isFull;
        }

        public void SetIsFull(bool f)
        {
            isFull = f;
        }
    }
}
