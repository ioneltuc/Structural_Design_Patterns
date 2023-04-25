namespace TMPS_lab2.Adapter
{
    public class ProductsBagUSAdapter : IProductsBag
    {
        private ProductsBag _bag;

        public ProductsBagUSAdapter(ProductsBag bag)
        {
            _bag = bag;
        }

        public string GenerateHTMLSection(List<Product> products)
        {
            foreach (Product product in products)
            {
                product.Price = convertFromEurosToDollars(product.Price);
            }

            string htmlBag = _bag.GenerateHTMLSection(products);
            htmlBag = htmlBag.Replace("euros", "$");

            return htmlBag;
        }

        private double convertFromEurosToDollars(double amount)
        {
            return Math.Round(amount * 1.1, 2);
        }
    }
}