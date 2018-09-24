using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSA_Exercise7B
{
    class BeltFed : DirectFire
    {
        new public void Reload()
        {
            Console.WriteLine("Open feed tray, place new bel, and close feed tray");
        }
        new public void Fire()
        {
            Console.WriteLine("The weapon fired. Bang Bang Bang Bang Bang Bang.");
        }
    }
}
