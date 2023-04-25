namespace TMPS_lab2.Proxy
{
    public static class ProxyExample
    {
        public static void StartExample()
        {
            var populationManager = new PopulationManager();
            populationManager.GeneratePopulation(3000000);
            var proxyPopulationManager = new ProxyPopulationManager(populationManager);

            Console.WriteLine("Sort\n1 - By age\n2 - By age descending\n3 - By first name\n" +
                "4 - By first name descending\n5 - By last name\n6 - By last name descending\n" +
                "0 - Exit");

            var people = new List<Person>();

            string input = Console.ReadLine();
            while (input != "0")
            {
                switch (input)
                {
                    case "1":
                        people.AddRange(proxyPopulationManager.SortByAge());
                        Console.WriteLine("Sorted!");
                        DisplayThreePeople(people);
                        break;

                    case "2":
                        people.AddRange(proxyPopulationManager.SortByAge(SortType.Descending));
                        Console.WriteLine("Sorted!");
                        DisplayThreePeople(people);
                        break;

                    case "3":
                        people.AddRange(proxyPopulationManager.SortByFirstName());
                        Console.WriteLine("Sorted!");
                        DisplayThreePeople(people);
                        break;

                    case "4":
                        people.AddRange(proxyPopulationManager.SortByFirstName(SortType.Descending));
                        Console.WriteLine("Sorted!");
                        DisplayThreePeople(people);
                        break;

                    case "5":
                        people.AddRange(proxyPopulationManager.SortByLastName());
                        Console.WriteLine("Sorted!");
                        DisplayThreePeople(people);
                        break;

                    case "6":
                        people.AddRange(proxyPopulationManager.SortByLastName(SortType.Descending));
                        Console.WriteLine("Sorted!");
                        DisplayThreePeople(people);
                        break;

                    default:
                        Console.WriteLine("Incorrect command!");
                        break;
                }

                people.Clear();
                input = Console.ReadLine();
            }
        }

        private static void DisplayThreePeople(List<Person> people)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("First name: " + people[i].FirstName);
                Console.WriteLine("Last name: " + people[i].LastName);
                Console.WriteLine("Age name: " + people[i].Age);
                Console.WriteLine();
            }
        }
    }
}