namespace TMPS_lab2.Adapter
{
    public class ProductsBag
    {
        public string GenerateHTMLSection(List<Product> products)
        {
            string htmlProducts = string.Empty;

            foreach (Product product in products)
            {
                htmlProducts += $"\n\t\t<div><b>{product.Name}</b> {product.Price} euros</div>";
            }

            string htmlBag = $"<div>" +
                $"\n\t<p>Products count: {products.Count()}</p>" +
                $"\n\t<div>" +
                $"{htmlProducts}" +
                $"\n\t<div>" +
                $"\n</div>";

            return htmlBag;
        }
    }
}