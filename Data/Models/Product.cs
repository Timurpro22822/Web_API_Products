using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }

        public string ImagePath { get; set; }

        public int ColorId { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }

        public Color? Color { get; set; }


    }
}
