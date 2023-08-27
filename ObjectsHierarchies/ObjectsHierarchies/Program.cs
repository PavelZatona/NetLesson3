using ObjectsHierarchies.Abstractions;
using ObjectsHierarchies.Implementations;

namespace ObjectsHierarchies
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICar trolleybus = new Trolleybus("PG1234", 220);

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

            Console.ReadLine();
        }
    }
}