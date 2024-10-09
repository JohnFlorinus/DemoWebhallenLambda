using DemoWebhallenLambda.Classes;

namespace DemoWebhallenLambda.Classes
{
    public class Product
    {
        //Här skapar vi olika properties.
        public string Headline { get; set; }
        public double Price { get; set; }

        public string Category { get; set; }
        public DateTime ReleaseDate { get; set; }

        //Här gör vi en LAMBDA
        public static List<Product> Search(string category, string condition, int max, int min)
        {
            var products = new List<Product>();
            Repository repo = new Repository();
            var allproducts = repo.GetProducts();

            products = allproducts
                .Where(p => p.Category == category
                && p.Headline.ToLower().Contains(condition.ToLower()))
                //&& p.Price>=min && p.Price<=max)
                .ToList();

            return products;
        }
    }
}
