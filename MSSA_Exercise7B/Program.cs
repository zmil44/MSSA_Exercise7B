using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSA_Exercise7B
{
    class Program
    {
        static void Main(string[] args)
        {
            Work();
        }

        public static void Work()
        {
            Weapon weapon =new Weapon();
            Mission mission=new Mission();
            Vehicle vehicle = new Vehicle();

            MagFed magfed = new MagFed();
            BeltFed beltFed = new BeltFed();

            AssaultMission assault = new AssaultMission();
            PatrolMission patrolMission = new PatrolMission();

            SmallVehicle smallVehicle = new SmallVehicle();
            LargeVehicle largeVehicle = new LargeVehicle();

            assault.BeginMission();
            largeVehicle.Capacity();
            smallVehicle.Capacity();
            largeVehicle.StartEngine();
            largeVehicle.Drive();
            largeVehicle.StopEngine();
            assault.BeginMission();
            magfed.Fire();
            magfed.Reload();
            beltFed.Fire();
            beltFed.Reload();
            assault.EndAssualt();
            weapon.Clean();
            assault.EndMission();

            Console.WriteLine();
            patrolMission.BeginMission();
            smallVehicle.StartEngine();
            patrolMission.BeginPatrol();
            smallVehicle.Drive();
            patrolMission.EndPatrol();
            smallVehicle.StopEngine();
            patrolMission.EndMission();

        }
    }
}
