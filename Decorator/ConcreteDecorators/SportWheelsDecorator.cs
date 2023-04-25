namespace TMPS_lab2.Decorator.ConcreteDecorators
{
    public class SportWheelsDecorator : CarDecorator
    {
        public SportWheelsDecorator(ICar car) : base(car)
        {
        }

        public override Car GenerateCarEquipment()
        {
            Car carWithSportWheels = base.GenerateCarEquipment();
            carWithSportWheels.WheelType = "Sport";
            carWithSportWheels.WheelSize = 19;
            return carWithSportWheels;
        }
    }
}