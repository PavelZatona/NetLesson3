namespace ObjectsHierarchies.Abstractions
{
    /// <summary>
    /// Интерфейс описывающий общие методы оружия
    /// </summary>
        public interface IGuns
        {
            /// <summary>
            /// Прицелиться для стрельбы
            /// </summary>
            void GunTakeAim();

            /// <summary>
            /// Выстрелить из оружия
            /// </summary>
            void GunShoot();

            /// <summary>
            /// Перезарядить оружие
            /// </summary>
            void GunReload();

            /// <summary>
            /// Проверить боезапас
            /// </summary>
            int AmmoCapacity();

            /// <summary>
            /// Определить одноручное или двуручное оружие
            /// </summary>
            void GunSize();

            /// <summary>
            /// Определить вес оружия
            /// </summary>
            void GunWeigth();

            /// <summary>
            /// Вернуть имя оружия
            /// </summary>
            string GetWeaponName();

            /// <summary>
            /// Столкнуться с абстрактным транспортным средством
            /// </summary>
            void GunChangeGun(IGuns anotherGun);
        }
    }
