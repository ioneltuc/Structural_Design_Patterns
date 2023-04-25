namespace TMPS_lab2.Decorator
{
    public class XenonHeadlightsDecorator : CarDecorator
    {
        public XenonHeadlightsDecorator(ICar car) : base(car)
        {
        }

        public override Car GenerateCarEquipment()
        {
            Car carWithXenonHeadlights = base.GenerateCarEquipment();
            carWithXenonHeadlights.Headlights = HeadlightsType.AdaptiveXenon;
            return carWithXenonHeadlights;
        }
    }
}