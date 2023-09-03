using ObjectsHierarchies.Abstractions;

namespace ObjectsHierarchies.Implementations
{
    /// <summary>
    /// Родительский класс для всех пушек
    /// </summary>
    public class Gun : IGuns
    {
        /// <summary>
        /// Название оружия
        /// </summary>
        public string WeaponName { get; private set; }

        /// <summary>
        /// Количество выстрелов, которое можно сделать
        /// </summary>
        public int AmmoCount { get; private set; }

        /// <summary>
        /// Я - конструктор пистолета, я создаю пистолет с указанным названием
        /// </summary>
        public Gun
        (
            string weaponName,
            int ammoSize
        )
        {
            WeaponName = weaponName;
            AmmoCount = ammoSize;
        }

        public virtual void GunReload()
        {
            Console.WriteLine($"Оружие с именем {WeaponName} перезаряжено");
        }

        public virtual void GunTakeAim()
        {
            Console.WriteLine($"Оружие с именем {WeaponName} прицелено для выстрела");
        }

        public virtual void GunShoot()
        {
            Console.WriteLine($"Оружие с именем {WeaponName} выстрило");
        }

        public void GunChangeGun(IGuns anotherGun)
        {
            Console.WriteLine($"Оружие {WeaponName} заменено оружием {anotherGun.GetWeaponName()}");
        }

        public void GunSize()
        {
            throw new NotImplementedException();
        }

        public void GunWeigth()
        {
            throw new NotImplementedException();
        }

        public string GetWeaponName()
        {
            return WeaponName;
        }

        public int AmmoCapacity()
        {
            return AmmoCount;
        }
    }
}
