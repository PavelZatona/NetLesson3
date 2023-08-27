using ObjectsHierarchies.Abstractions;

namespace ObjectsHierarchies.Implementations
{
    /// <summary>
    /// Родительский класс для всех транспортных средств
    /// </summary>
    public class Car : ICar
    {
        /// <summary>
        /// Номер машины
        /// </summary>
        public string LicensePlate { get; private set; }

        /// <summary>
        /// Я - конструктор машины, я создаю машину с указанным номером
        /// </summary>
        public Car(string licensePlate)
        {
            LicensePlate = licensePlate;
        }

        /// <summary>
        /// Виртуальный метод "везти людей". Виртуальный значит "потомки могут изменять его поведение"
        /// </summary>
        public virtual void CarryPeople(int peopleCount, string destination)
        {
            Console.WriteLine($"Машина с номером {LicensePlate} везёт { peopleCount } человека в { destination }");
        }

        public virtual void StartEngline()
        {
            Console.WriteLine($"Машина с номером { LicensePlate } заводит мотор");
        }

        public virtual void StopEngine()
        {
            Console.WriteLine($"Машина с номером {LicensePlate} глушит мотор");
        }

        public void Crash(ICar anotherCar)
        {
            Console.WriteLine($"Транспортное средство с номером { LicensePlate } сталкивается с транспортным средством с номером { anotherCar.GetLicensePlate()}");
        }

        public string GetLicensePlate()
        {
            return LicensePlate;
        }
    }
}
