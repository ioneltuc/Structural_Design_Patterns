namespace TMPS_lab2.Proxy
{
    public class PopulationManager : IPopulation
    {
        private List<Person> _people;
        private Random _random;

        public PopulationManager()
        {
            _people = new List<Person>();
            _random = new Random();
        }

        public void GeneratePopulation(int numberOfPeople)
        {
            for (int i = 0; i < numberOfPeople; i++)
            {
                Person person = new Person();
                person.FirstName = NameGenerator.GenerateName(_random.Next(3, 9));
                person.LastName = NameGenerator.GenerateName(_random.Next(3, 9));
                person.Age = _random.Next(0, 110);

                _people.Add(person);
            }
        }

        public List<Person> SortByAge(SortType sortType = SortType.Ascending)
        {
            var sortedPeople = new List<Person>();

            if (sortType == SortType.Ascending)
            {
                sortedPeople = _people.OrderBy(p => p.Age).ToList();
            }
            else
            {
                sortedPeople = _people.OrderByDescending(p => p.Age).ToList();
            }

            return sortedPeople;
        }

        public List<Person> SortByFirstName(SortType sortType = SortType.Ascending)
        {
            var sortedPeople = new List<Person>();

            if (sortType == SortType.Ascending)
            {
                sortedPeople = _people.OrderBy(p => p.FirstName).ToList();
            }
            else
            {
                sortedPeople = _people.OrderByDescending(p => p.FirstName).ToList();
            }

            return sortedPeople;
        }

        public List<Person> SortByLastName(SortType sortType = SortType.Ascending)
        {
            var sortedPeople = new List<Person>();

            if (sortType == SortType.Ascending)
            {
                sortedPeople = _people.OrderBy(p => p.LastName).ToList();
            }
            else
            {
                sortedPeople = _people.OrderByDescending(p => p.LastName).ToList();
            }

            return sortedPeople;
        }
    }
}