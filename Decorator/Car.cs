using TMPS_lab2.Decorator.Enums;

namespace TMPS_lab2.Decorator
{
    public class Car : ICar
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string EngineType { get; set; }
        public int EngineCapacity { get; set; }
        public SeatHeatingType SeatHeating { get; set; } = SeatHeatingType.Front;
        public ParkingSensorsType ParkingSensors { get; set; } = ParkingSensorsType.None;
        public HeadlightsType Headlights { get; set; } = HeadlightsType.Halogen;
        public string WheelType { get; set; } = "Standard";
        public int WheelSize { get; set; } = 17;

        public Car(string brand, string model, string engineType, int engineCapacity)
        {
            Brand = brand;
            Model = model;
            EngineType = engineType;
            EngineCapacity = engineCapacity;
        }

        public Car GenerateCarEquipment()
        {
            return this;
        }

        public string GetCarInfo()
        {
            return $"Brand: {Brand}\nMode: {Model}\nEngine: {EngineCapacity} ml {EngineType}\n" +
                $"Seat heating: {SeatHeating}\nParking sensors: {ParkingSensors}\nHeadlights: {Headlights}\n" +
                $"Wheel type: {WheelType}\nWheel size: {WheelSize}";
        }
    }
}