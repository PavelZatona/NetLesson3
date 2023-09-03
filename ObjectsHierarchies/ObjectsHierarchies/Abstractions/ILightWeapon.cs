namespace ObjectsHierarchies.Abstractions
{
    internal interface ILightWeapon
    {
        /// <summary>
        /// Заклинить оружие во время стрельбы
        /// </summary>
        void GunJammed();

        /// <summary>
        /// Починить заклиненное или перегретое оружие
        /// </summary>
        void GunRepaired();

        /// <summary>
        /// Перегреть оружие при стрельбе
        /// </summary>
        void GunOverheated();
    }
}
