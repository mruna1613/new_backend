using new_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace new_backend.Repository
{
    public interface IcodeRepository
    {
        Task<List<Validation>> GetAllValidationsAsync();
        Task<Validation> GetValidationsByIdAsync(int loginDetaisId);
        Task<int> AddValidationsAsync(Validation validation);
        Task UpdateValidationsByIdAsync(int loginDetaisId, Validation validation);
        Task DeleteValidationsAsync(int loginDetailsId);
    }
}
