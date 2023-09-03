using ObjectsHierarchies.Abstractions;
using ObjectsHierarchies.Implementations;
using System.Data;

namespace ObjectsHierarchies
{
    public class Program
    {
        public static void Main(string[] args)
        {
           /* ICar trolleybus = new Trolleybus("PG1234", 220);

            trolleybus.StartEngline();
            trolleybus.CarryPeople(4, "Тиват");
            trolleybus.StopEngine();

            ICar truck = new Truck("PG9876");
            truck.StartEngline();
            truck.CarryPeople(2, "Бар");
            truck.StopEngine();

            Console.WriteLine($"Троллейбус - грузовик? { trolleybus is ITruck }");
            Console.WriteLine($"Грузовик - грузовик? {truck is ITruck}");

            // Пытаемся возить грузы на троллейбусе
            if (trolleybus is ITruck)
            {
                Console.WriteLine("На троллейбусе можно возить грузы");

                ITruck trolleybusAsTruck = trolleybus as ITruck;
                trolleybusAsTruck.Load(5);
                trolleybusAsTruck.Unload();
            }
            

            // Пытаемся возить грузы на грузовике
            if (truck is ITruck)
            {
                Console.WriteLine("На грузовике можно возить грузы");

                ITruck truckAsTruck = truck as ITruck;
                truckAsTruck.Load(5);
                truckAsTruck.Unload();
            }

            trolleybus.Crash(truck);
*/

            IGuns pistol = new Pistol("TT", 7);
            IGuns rocketLauncher = new RocketLauncher("RocketLauncher", 4);

            ShowWeaponSummary(pistol);
            ShowWeaponSummary(rocketLauncher);

            //pistol.GunChangeGun(rocketLauncher);

            Console.ReadLine();
        }

        private static void ShowWeaponSummary(IGuns gun)
        {
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine($"Количество зарядов: {gun.AmmoCapacity()}"); ;
            gun.GunReload();
            gun.GunTakeAim();
            gun.GunShoot();
            Console.WriteLine("----------------------------------------------------------------------------------------");

            DoLightWeaponActions(gun);
            DoHeavyWeaponActions(gun);
        }

        private static void DoLightWeaponActions(IGuns gun)
        {
            Console.WriteLine("----------------------------------------------------------------------------------------");

            if (!(gun is ILightWeapon))
            {
                Console.WriteLine($"Оружие {gun.GetWeaponName()} не является лёгким.");
                return;
            }

            ILightWeapon lightWeapon = gun as ILightWeapon;
            lightWeapon.GunOverheated();
            lightWeapon.GunJammed();
            lightWeapon.GunRepaired();

            Console.WriteLine("----------------------------------------------------------------------------------------");
        }

        private static void DoHeavyWeaponActions(IGuns gun)
        {
            Console.WriteLine("----------------------------------------------------------------------------------------");

            if (!(gun is IHeavyWeapon))
            {
                Console.WriteLine($"Оружие {gun.GetWeaponName()} не является тяжёлым.");
                return;
            }

            IHeavyWeapon heavyWeapon = gun as IHeavyWeapon;
            heavyWeapon.SlowMovement();

            Console.WriteLine("----------------------------------------------------------------------------------------");
        }
    }
}