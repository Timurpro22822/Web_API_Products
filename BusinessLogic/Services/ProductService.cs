using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using Data.Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductsDbContext context;
        private readonly IMapper mapper;

        public ProductService(ProductsDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public IEnumerable<ProductDTO> GetAll()
        {
            var products = context.Products
                .Include(x => x.Color)
                .Include(x => x.Category).ToList();

            return mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public ProductDTO? GetById(int id)
        {
            var product = context.Products.Find(id);

            if (product == null) return null;

            return mapper.Map<ProductDTO>(product);
        }
        public void Create(ProductDTO product)
        {
            context.Products.Add(mapper.Map<Product>(product));
            context.SaveChanges();
        }
        public void Edit(ProductDTO product)
        {
            var data = context.Products.AsNoTracking().FirstOrDefault(l => l.Id == product.Id);

            if (data == null) return;

            context.Products.Update(mapper.Map<Product>(product));
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = context.Products.Find(id);

            if(product == null) return;

            context.Products.Remove(product);
            context.SaveChanges();
        }


    }
}
