namespace ObjectsHierarchies.Abstractions
{
    /// <summary>
    /// Интерфейс, описывающий грузовики
    /// </summary>
    public interface ITruck
    {
        /// <summary>
        /// Принять столько-то тонн груза на борт
        /// </summary>
        void Load(int weight);

        /// <summary>
        /// Разгрузиться
        /// </summary>
        void Unload();
    }
}
