using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSA_Exercise7B
{
    class MagFed : DirectFire
    {
        protected int magCapacity;

        new public void Reload()
        {
            Console.WriteLine("Eject magazine and insert new magazine");
        }
        new public void Fire()
        {
            Console.WriteLine("The weapon fired. Bang Bang.");
        }
    }
}
