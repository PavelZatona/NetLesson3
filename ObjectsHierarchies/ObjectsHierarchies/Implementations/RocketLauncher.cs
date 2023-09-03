using ObjectsHierarchies.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsHierarchies.Implementations
{
    /// <summary>
    /// Рокет ланчер - он оружие и тяжёлое
    /// </summary>
    public class RocketLauncher : Gun, IHeavyWeapon
    {
        public RocketLauncher(string weaponName, int ammoSize) : base(weaponName, ammoSize)
        {
        }

        public void SlowMovement()
        {
            Console.WriteLine($"Роект ланчер { WeaponName } тяжёлый, он замедляет движение!");
        }
    }
}
