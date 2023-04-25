namespace TMPS_lab2.Adapter
{
    public static class AdapterExample
    {
        public static void StartExample()
        {
            var products = new List<Product>()
            {
                new Product() { Name = "Shoes", Price = 55 },
                new Product() { Name = "T-Shirt", Price = 29.95 },
                new Product() { Name = "Hat", Price = 10.95 },
            };

            var productsBagUSAdapter = new ProductsBagUSAdapter(new ProductsBag());

            Console.WriteLine(productsBagUSAdapter.GenerateHTMLSection(products));
        }
    }
}