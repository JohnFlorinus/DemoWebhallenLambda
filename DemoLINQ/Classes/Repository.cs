using System.Text.Json;

namespace DemoWebhallenLambda.Classes
{
    public class Repository
    {
        //Här skapar vi en lista
        public List<string> GetCategories()
        {
            var products = GetProducts();

            var categories = products.Select(p => p.Category)
                .Distinct()
                .Order()
                .ToList();

            return categories;
        }
            //Här läser vi från filen
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            // 
            using (StreamReader reader = new StreamReader("..\\..\\..\\gaming_products.json"))
            {
                //Läs upp alla rader i textfilen som en sträng
                string productsJSON = reader.ReadToEnd();

                //Skapa en lista från en JSON sträng
                //Vi gör en typkonvertering av strängen till en lista med produktobjekt
                products = JsonSerializer.Deserialize<List<Product>>(productsJSON);
            }

            return products;


        }

    }
}
