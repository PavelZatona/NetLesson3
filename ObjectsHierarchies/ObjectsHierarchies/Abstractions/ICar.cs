namespace ObjectsHierarchies.Abstractions
{
    /// <summary>
    /// Интерфейс, описывающий общие методы машины
    /// </summary>
    public interface ICar
    {
        /// <summary>
        /// Завести мотор (у всех машин должен быть метод StartEngine)
        /// </summary>
        void StartEngline();

        /// <summary>
        /// Заглушить мотор
        /// </summary>
        void StopEngine();

        /// <summary>
        /// Везти указанное число людей в указанную точку
        /// </summary>
        void CarryPeople(int peopleCount, string destination);

        /// <summary>
        /// Вернуть номер транспортного средства
        /// </summary>
        string GetLicensePlate();

        /// <summary>
        /// Столкнуться с абстрактным транспортным средством
        /// </summary>
        void Crash(ICar anotherCar);
    }
}
