using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab14
{
    interface IVehicle
    {
        int GetSize();
        void Park(Space);
    }
}
