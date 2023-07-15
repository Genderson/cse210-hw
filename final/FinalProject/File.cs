
using Newtonsoft.Json;

namespace FinalProject
{
    public class File
    {
        public void SaveToFile(string fileName, List<Product> products)
        {            
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (var product in products)
                {                    
                    outputFile.WriteLine(product.FormatTextToFile());
                }                
            }
        }

        public List<Product> LoadFromFile(string fileName)
        {
            List<Product> products = new List<Product>();
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (var line in lines)
            {
                var product = ProductFactory.CreateProduct(line.Split("|"));
                products.Add(product);
            }
            
            return products;
        }
    }
}