namespace TMPS_lab2.Composite
{
    public class Truck : ICar
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int MaxSpeed { get; set; }
        private List<ICar> _truckTrailer = new List<ICar>();

        public Truck(string name, int weight, int maxSpeed)
        {
            Name = name;
            Weight = weight;
            MaxSpeed = maxSpeed;
        }

        public void LoadNewCarIntoTrailer(ICar car)
        {
            _truckTrailer.Add(car);
        }

        public void UnloadCarFromTrailer(ICar car)
        {
            _truckTrailer.Remove(car);
        }

        public int ConvertKmsToMiles(int kms)
        {
            return (int)(kms * 0.62);
        }

        public int GetCarWeight()
        {
            int totalWeight = Weight;

            foreach (ICar car in _truckTrailer)
            {
                totalWeight += car.GetCarWeight();
            }

            return totalWeight;
        }
    }
}