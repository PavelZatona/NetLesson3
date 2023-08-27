using ObjectsHierarchies.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsHierarchies.Implementations
{
    public class Trolleybus : Car
    {
        /// <summary>
        /// Напряжение, потребное троллейбусу
        /// </summary>
        public int Voltage { get; set; }

        public Trolleybus
        (
            string licensePlate,
            int voltage
        ) : base(licensePlate)
        {
            Voltage = voltage;
        }

        /// <summary>
        /// Ключевое слово override у метода означает "этот метод заменяет собой метод предка"
        /// </summary>
        public override void StartEngline()
        {
            Console.WriteLine($"Троллейбус с номером {LicensePlate} заводит мотор используя напряжение {Voltage }");
        }

        public override void StopEngine()
        {
            Console.WriteLine($"Троллейбус с номером { LicensePlate } глушит мотор");
        }

        public override void CarryPeople(int peopleCount, string destination)
        {
            Console.WriteLine($"Троллейбус с номером {LicensePlate} везёт {peopleCount} человека в {destination}");
        }
    }
}
