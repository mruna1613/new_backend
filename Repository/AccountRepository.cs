using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using new_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace new_backend.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly Microsoft.AspNetCore.Identity.UserManager<AppUser> _userManager;

        public AccountRepository(Microsoft.AspNetCore.Identity.UserManager<AppUser> userManager) 
        {
           _userManager = userManager;
        }

        public async Task<Microsoft.AspNetCore.Identity.IdentityResult> SignupAsync(SignUpModel signUpModel)
        {
            var user = new AppUser()
            {
                Name = signUpModel.Name,
                Email = signUpModel.EMail
            };

            return await _userManager.CreateAsync(user, signUpModel.password);
        }
    }
}
