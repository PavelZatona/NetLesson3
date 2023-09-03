using ObjectsHierarchies.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsHierarchies.Implementations
{
    /// <summary>
    /// Пистолеты - они - пушки и лёгкие
    /// </summary>
    public class Pistol : Gun, ILightWeapon
    {
        public Pistol(string weaponName, int ammoSize) : base(weaponName, ammoSize)
        {
        }

        public void GunJammed()
        {
            Console.WriteLine($"Лёгкое оружие { WeaponName } заклинило.");
        }

        public void GunOverheated()
        {
            Console.WriteLine($"Лёгкое оружие {WeaponName} перегрелось.");
        }

        public void GunRepaired()
        {
            Console.WriteLine($"Лёгкое оружие {WeaponName} починено.");
        }
    }
}
