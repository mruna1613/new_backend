using new_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace new_backend.Repository
{
    public interface IAccountRepository
    {
        Task<Microsoft.AspNetCore.Identity.IdentityResult> SignupAsync(SignUpModel signUpModel);
    }
}
