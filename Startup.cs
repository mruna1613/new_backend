using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using new_backend.Data;
using new_backend.Repository;
using System.Collections.Generic;
using new_backend.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Diagnostics;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using new_backend.Models;
using Microsoft.AspNetCore.Identity;

namespace new_backend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AttendanceContext>(options =>
    options.UseSqlServer(Configuration.GetConnectionString("LoginDetailsDB")));

            services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<AttendanceContext>()
                .AddDefaultTokenProviders();

            services.AddControllers();
            services.AddTransient<IcodeRepository, codeRepository>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddAutoMapper(typeof(Startup));    
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
        }
    }
}

