using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public static class MockData
    {
        public static List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Samsung QE55QN90BAUXUA Neo",
                    Description = "55″",
                    Year = 2022,
                    Price = 73999,
                    ColorId = 1,
                    CategoryId = 3,
                    ImagePath = @"https://www.pngall.com/wp-content/uploads/5/Samsung-TV-PNG-Image-HD.png"
                },
                new Product()
                {
                    Id = 2,
                    Name = "Samsung QE65Q70BAUXUA",
                    Description = "65″",
                    Year = 2022,
                    Price = 62999,
                    ColorId = 1,
                    CategoryId = 3,
                    ImagePath = @"https://www.pngall.com/wp-content/uploads/5/Samsung-TV-PNG-Image-HD.png"
                },
                new Product()
                {
                    Id = 3,
                    Name = "Samsung QE65Q60BAUXUA",
                    Description = "65″",
                    Year = 2022,
                    Price = 52199,
                    CategoryId = 3,
                    ColorId = 3,
                    ImagePath = @"https://www.pngall.com/wp-content/uploads/5/Samsung-TV-PNG-Image-HD.png"
                },
                new Product()
                {
                    Id = 4,
                    Name = "Samsung UE55BU8500UXUA",
                    Description = "55″",
                    Year = 2022,
                    Price = 28399,
                    ColorId = 2,
                    CategoryId = 3,
                    ImagePath = @"https://www.pngall.com/wp-content/uploads/5/Samsung-TV-PNG-Image-HD.png"
                }
            };
        }
        public static Product GetProductById(int id)
        {
            return GetProducts().FirstOrDefault(x => x.Id == id);
        }
        public static List<Category> GetCategories()
        {
            return new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Laptops"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Smartphones"
                },
                new Category()
                {
                    Id = 3,
                    Name = "TVs"
                },
            };
        }
        public static List<Color> GetColors()
        {
            return new List<Color>()
            {
                new Color()
                {
                    Id = 1,
                    Name = "White"
                },
                new Color()
                {
                    Id = 2,
                    Name = "Black"
                },
                new Color()
                {
                    Id = 3,
                    Name = "Gray"
                },
            };
        }
    }
}
