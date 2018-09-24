using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSA_Exercise7B
{
    class AssaultMission : Mission
    {
        public void BeginAssault()
        {
            Console.WriteLine("The assault has begun");
        }
        public void EndAssualt()
        {
            Console.WriteLine("The assualt has ended");
        }
    }
}
