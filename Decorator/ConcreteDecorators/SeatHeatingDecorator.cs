using TMPS_lab2.Decorator.Enums;

namespace TMPS_lab2.Decorator.ConcreteDecorators
{
    public class SeatHeatingDecorator : CarDecorator
    {
        public SeatHeatingDecorator(ICar car) : base(car)
        {
        }

        public override Car GenerateCarEquipment()
        {
            Car carWithAllHeatingSeats = base.GenerateCarEquipment();
            carWithAllHeatingSeats.SeatHeating = SeatHeatingType.All;
            return carWithAllHeatingSeats;
        }
    }
}