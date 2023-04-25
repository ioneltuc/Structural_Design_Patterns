namespace TMPS_lab2.Proxy
{
    public interface IPopulation
    {
        List<Person> SortByAge(SortType sortType = SortType.Ascending);

        List<Person> SortByFirstName(SortType sortType = SortType.Ascending);

        List<Person> SortByLastName(SortType sortType = SortType.Ascending);
    }
}