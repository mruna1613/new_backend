using new_backend.Data;
using new_backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace new_backend.Repository
{
    public class codeRepository : IcodeRepository
    {
        private readonly AttendanceContext _context;
        private readonly IMapper _mapper;

        public codeRepository(AttendanceContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }

        //to get all items
        public async Task<List<Validation>> GetAllValidationsAsync()
        {
            var records =await _context.loginDetails.ToListAsync();

            return _mapper.Map<List<Validation>>(records);
        }

        //to get single item
        public async Task<Validation> GetValidationsByIdAsync(int loginDetaisId)
        {
            //var records = await _context.loginDetails.Where(x=> x.Id == loginDetaisId).Select(x => new Validation()
            //{
            //    Id = x.Id,
            //    Name = x.Name,
            //    password = x.password
            //}).FirstOrDefaultAsync();

            //return records;

            var login = await _context.loginDetails.FindAsync(loginDetaisId);
            return _mapper.Map<Validation>(login);
        }

        //to add new item
        public async Task<int> AddValidationsAsync(Validation validation)
        {
            var loginDetails = new loginDetails()
            {
                Name = validation.Name,
                password = validation.password
            };

            _context.loginDetails.Add(loginDetails);
            await _context.SaveChangesAsync();

            return loginDetails.Id;
        }

        //update the item
        public async Task UpdateValidationsByIdAsync(int loginDetaisId,Validation validation)
        {
            //var login = await _context.loginDetails.FindAsync(loginDetaisId);
            //if(login == null)
            //{
            //    login.Name = validation.Name;
            //    login.password = validation.password;
            //
            //    await _context.SaveChangesAsync();
            //}

            var loginDetails = new loginDetails()
            {
                Id = loginDetaisId,
                Name = validation.Name,
                password = validation.password
            };

            _context.loginDetails.Update(loginDetails);
            await _context.SaveChangesAsync();
        }

        //delete
        public async Task DeleteValidationsAsync(int loginDetailsId)
        {
            var login = new loginDetails() { Id = loginDetailsId };
           
            _context.loginDetails.Remove(login);

            await _context.SaveChangesAsync();

        }



    }
}
