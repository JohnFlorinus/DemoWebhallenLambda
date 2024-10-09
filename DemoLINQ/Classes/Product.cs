using DemoWebhallenLambda.Classes;

namespace DemoWebhallenLambda.Classes
{
    public class Product
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public string Category { get; set; }
        public DateTime ReleaseDate { get; set; }

        public static List<Product> Search(string category, string condition, int max, int min)
        {
            var products = new List<Product>();
            Repository repo = new Repository();
            var allproducts = repo.GetProducts();

            products = allproducts
                .Where(p => p.Category == category
                && p.Title.ToLower().Contains(condition.ToLower()))
                //&& p.Price>=min && p.Price<=max)
                .ToList();

            return products;
        }
    }
}
