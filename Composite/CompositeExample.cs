namespace TMPS_lab2.Composite
{
    public static class CompositeExample
    {
        public static void StartExample()
        {
            Sedan mercedes = new Sedan("Mercedes E Class", 1450, 215);
            Truck whiteIveco = new Truck("Iveco", 6000, 120);
            Truck redIveco = new Truck("Iveco", 9500, 135);
            Truck man = new Truck("Man", 12000, 160);

            whiteIveco.LoadNewCarIntoTrailer(mercedes);
            redIveco.LoadNewCarIntoTrailer(whiteIveco);
            man.LoadNewCarIntoTrailer(redIveco);

            int totalManWeight = man.GetCarWeight();

            if (totalManWeight > 20000)
            {
                Console.WriteLine($"Greutatea: {totalManWeight}");
                Console.WriteLine("Camionul impreuna cu incarcatura sa cantareste mai mult de 20 tone.\n" +
                    "Accesul pe noul pod este interzis!");
            }
            else
            {
                Console.WriteLine($"Greutatea: {totalManWeight}");
                Console.WriteLine("Camionul impreuna cu incarcatura sa cantareste mai putin de 20 tone.\n" +
                    "Accesul pe noul pod este permis!");
            }
        }
    }
}