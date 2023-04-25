using TMPS_lab2.Decorator.ConcreteDecorators;

namespace TMPS_lab2.Decorator
{
    public static class DecoratorExample
    {
        public static void StartExample()
        {
            ICar skoda = new Car("Skoda", "Octavia", "TSI", 1984);

            Console.WriteLine("Skoda Octavia RS - echiparea masinii");
            Console.WriteLine("Da/Nu");

            Console.WriteLine("Doriti ca masina sa fie echipata cu senzori de parcare?");
            string input = Console.ReadLine();
            if (input.ToLower() == "da")
            {
                skoda = new ParkingSensorsDecorator(skoda);
                skoda.GenerateCarEquipment();
            }

            Console.WriteLine("Doriti ca masina sa fie echipata cu incalzire scaune fata/spate?");
            input = Console.ReadLine();
            if (input.ToLower() == "da")
            {
                skoda = new SeatHeatingDecorator(skoda);
                skoda.GenerateCarEquipment();
            }

            Console.WriteLine("Doriti ca masina sa fie echipata cu roti sportive?");
            input = Console.ReadLine();
            if (input.ToLower() == "da")
            {
                skoda = new SportWheelsDecorator(skoda);
                skoda.GenerateCarEquipment();
            }

            Console.WriteLine("Doriti ca masina sa fie echipata cu faruri xenon?");
            input = Console.ReadLine();
            if (input.ToLower() == "da")
            {
                skoda = new XenonHeadlightsDecorator(skoda);
                skoda.GenerateCarEquipment();
            }

            Console.WriteLine($"Skoda Octavia RS - rezultatul final\n{skoda.GetCarInfo()}");
        }
    }
}