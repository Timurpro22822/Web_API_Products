using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class AccountService : IAccountService
    {
        private readonly IMapper mapper;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountService(IMapper mapper, 
                              UserManager<IdentityUser> userManager,
                              SignInManager<IdentityUser> signInManager)
        {
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public async Task Register(UserDTO user)
        {
            IdentityUser identityUser = mapper.Map<IdentityUser>(user);
            
            var result = await userManager.CreateAsync(identityUser, user.Password);

            if(!result.Succeeded)
            {
                var errors = result.Errors.Select(e => e.Description);
                var userResponse = new UserResponseDTO { Errors = errors };
            
                throw new Exception($"{userResponse}");
            }
        }

        public async Task Login(string email, string password)
        {
            var user = await userManager.FindByEmailAsync(email);

            if(user == null || !await userManager.CheckPasswordAsync(user, password))
            {
                throw new Exception("Invalid email or password!");
            }

            await signInManager.SignInAsync(user, true);
        }

        public async Task Logout()
        {
            await signInManager.SignOutAsync();
        }

    }
}
