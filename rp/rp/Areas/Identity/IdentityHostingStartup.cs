using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using rp.Areas.Identity.Data;
using rp.Data;

[assembly: HostingStartup(typeof(rp.Areas.Identity.IdentityHostingStartup))]
namespace rp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<rpContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("rpContextConnection")));

                services.AddDefaultIdentity<rpUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequiredUniqueChars = 0;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;

                })
                     .AddEntityFrameworkStores<rpContext>();
            });
        }
    }
}