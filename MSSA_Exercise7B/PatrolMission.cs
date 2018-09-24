using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSA_Exercise7B
{
    class PatrolMission : Mission
    {
        public void BeginPatrol()
        {
            Console.WriteLine("The patrol has started");
        }
        public void EndPatrol()
        {
            Console.WriteLine("The patrol has ended");
        }
    }
}
