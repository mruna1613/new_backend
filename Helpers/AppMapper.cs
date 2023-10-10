using AutoMapper;
using new_backend.Data;
using new_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace new_backend.Helpers
{
    public class AppMapper : Profile
    {
        public AppMapper() 
        {
            CreateMap<loginDetails, Validation>();
        }
    }
}
