using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }

        public string ImagePath { get; set; }

        public int ColId { get; set; }

        public int CategId { get; set; }

        public string? ColName { get; set; }

        public string? CategName { get; set; }

    }
}
