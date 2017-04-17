using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab14
{
    class Level
    {
        public Space[] spaces;

        public Level(int numSpaces)
        {
            spaces = new Space[numSpaces];
        }

        public void EditSpace(Space s, int index)
        {
            spaces[index] = s;
        }

        public int GetSpaces()
        {
            return spaces.Length;
        }
    }
}
