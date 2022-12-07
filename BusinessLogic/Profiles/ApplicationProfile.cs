using BusinessLogic.DTOs;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Profiles
{
    public class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Product, ProductDTO>()
                .ForMember(d => d.ColId, opt => opt.MapFrom(c => c.ColorId))
                .ForMember(d => d.ColName, opt => opt.MapFrom(c => c.Color.Name))
                .ForMember(d => d.CategId, opt => opt.MapFrom(c => c.CategoryId))
                .ForMember(d => d.CategName, opt => opt.MapFrom(c => c.Category.Name));

            CreateMap<ProductDTO, Product>()
                .ForMember(d => d.ColorId, opt => opt.MapFrom(c => c.ColId))
                .ForMember(d => d.CategoryId, opt => opt.MapFrom(c => c.CategId));

            CreateMap<UserDTO, IdentityUser>()
                .ForMember(d => d.UserName, opt => opt.MapFrom(s => s.Email))
                .ForMember(d => d.Id, opt => opt.Ignore());
        }
    }
}
