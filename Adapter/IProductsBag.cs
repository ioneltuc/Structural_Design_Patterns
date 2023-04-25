namespace TMPS_lab2.Adapter
{
    public interface IProductsBag
    {
        string GenerateHTMLSection(List<Product> products);
    }
}