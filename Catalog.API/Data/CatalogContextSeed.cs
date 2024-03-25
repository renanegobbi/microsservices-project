using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }
        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "Small Spiral Notebook",
                    Description = "Spiral notebook with 100 sheets, small hardcover",
                    Image = "notebook.png",
                    Price = 7.65M,
                    Category = "School Supplies"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f6",
                    Name = "Small white eraser",
                    Description = "Small white pencil eraser",
                    Image = "rubber.png",
                    Price = 4.55M,
                    Category = "School Supplies"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f7",
                    Name = "Small plastic case",
                    Description = "Small blue plastic case",
                    Image = "case.png",
                    Price = 6.79M,
                    Category = "School Supplies"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f8",
                    Name = "Small Paper Clips",
                    Description = "Small paper clips 100 g",
                    Image = "clips.png",
                    Price = 3.25M,
                    Category = "Accessories"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f9",
                    Name = "Small plastic compass",
                    Description = "Small blue plastic compass",
                    Image = "compass.png",
                    Price = 8.99M,
                    Category = "Accessories"
                },
            };
        }
    }
}