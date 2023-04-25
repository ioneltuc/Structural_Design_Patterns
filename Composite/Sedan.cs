namespace TMPS_lab2.Composite
{
    public class Sedan : ICar
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int MaxSpeed { get; set; }

        public Sedan(string name, int weight, int maxSpeed)
        {
            Name = name;
            Weight = weight;
            MaxSpeed = maxSpeed;
        }

        public int ConvertKmsToMiles(int kms)
        {
            return (int)(kms * 0.62);
        }

        public int GetCarWeight()
        {
            return Weight;
        }
    }
}