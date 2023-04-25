namespace TMPS_lab2.Decorator
{
    public class CarDecorator : ICar
    {
        protected ICar car;

        public CarDecorator(ICar car)
        {
            this.car = car;
        }

        public virtual Car GenerateCarEquipment()
        {
            return car.GenerateCarEquipment();
        }

        public virtual string GetCarInfo()
        {
            return car.GetCarInfo();
        }
    }
}