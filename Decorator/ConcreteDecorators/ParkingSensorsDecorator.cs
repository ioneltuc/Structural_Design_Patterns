using TMPS_lab2.Decorator.Enums;

namespace TMPS_lab2.Decorator.ConcreteDecorators
{
    public class ParkingSensorsDecorator : CarDecorator
    {
        public ParkingSensorsDecorator(ICar car) : base(car)
        {
        }

        public override Car GenerateCarEquipment()
        {
            Car carWithParkingSensors = base.GenerateCarEquipment();
            carWithParkingSensors.ParkingSensors = ParkingSensorsType.AllAround;
            return carWithParkingSensors;
        }
    }
}