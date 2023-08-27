using ObjectsHierarchies.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsHierarchies.Implementations
{
    public class Truck : Car, ITruck
    {
        private int _cargoAmount { get; set; }

        public Truck
        (
            string licensePlate
        ) : base(licensePlate)
        {
        }

        public void Load(int weight)
        {
            _cargoAmount += weight;

            Console.WriteLine($"Загружаем { weight }, теперь на борту { _cargoAmount }");
        }

        public void Unload()
        {
            Console.WriteLine($"Выгружаем все { _cargoAmount } тонн груза");
            _cargoAmount = 0;
        }
    }
}
