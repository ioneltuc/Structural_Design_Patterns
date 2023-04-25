namespace TMPS_lab2.Proxy
{
    public class ProxyPopulationManager : IPopulation
    {
        private PopulationManager _populationManager;
        private List<Person> _peopleByAge = null;
        private List<Person> _peopleByAgeDesc = null;
        private List<Person> _peopleByFirstName = null;
        private List<Person> _peopleByFirstNameDesc = null;
        private List<Person> _peopleByLastName = null;
        private List<Person> _peopleByLastNameDesc = null;

        public ProxyPopulationManager(PopulationManager populationManager)
        {
            _populationManager = populationManager;
        }

        public List<Person> SortByAge(SortType sortType = SortType.Ascending)
        {
            if (sortType == SortType.Ascending)
            {
                if (_peopleByAge == null)
                {
                    _peopleByAge = _populationManager.SortByAge();
                    return _peopleByAge;
                }

                return _peopleByAge;
            }
            else
            {
                if (_peopleByAgeDesc == null)
                {
                    _peopleByAgeDesc = _populationManager.SortByAge(SortType.Descending);
                    return _peopleByAgeDesc;
                }

                return _peopleByAgeDesc;
            }
        }

        public List<Person> SortByFirstName(SortType sortType = SortType.Ascending)
        {
            if (sortType == SortType.Ascending)
            {
                if (_peopleByFirstName == null)
                {
                    _peopleByFirstName = _populationManager.SortByFirstName();
                    return _peopleByFirstName;
                }

                return _peopleByFirstName;
            }
            else
            {
                if (_peopleByFirstNameDesc == null)
                {
                    _peopleByFirstNameDesc = _populationManager.SortByFirstName(SortType.Descending);
                    return _peopleByFirstNameDesc;
                }

                return _peopleByFirstNameDesc;
            }
        }

        public List<Person> SortByLastName(SortType sortType = SortType.Ascending)
        {
            if (sortType == SortType.Ascending)
            {
                if (_peopleByLastName == null)
                {
                    _peopleByLastName = _populationManager.SortByLastName();
                    return _peopleByLastName;
                }

                return _peopleByLastName;
            }
            else
            {
                if (_peopleByLastNameDesc == null)
                {
                    _peopleByLastNameDesc = _populationManager.SortByLastName(SortType.Descending);
                    return _peopleByLastNameDesc;
                }

                return _peopleByLastNameDesc;
            }
        }
    }
}