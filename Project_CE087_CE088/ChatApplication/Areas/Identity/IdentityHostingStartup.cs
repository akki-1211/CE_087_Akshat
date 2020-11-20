using System;
using ChatApplication.Areas.Identity.Data;
using ChatApplication.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(ChatApplication.Areas.Identity.IdentityHostingStartup))]
namespace ChatApplication.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ChatApplicationDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ChatApplicationDBContextConnection")));

                services.AddDefaultIdentity<ChatApplicationUser>(options =>
                {
                    options.Password.RequireDigit = options.Password.RequireLowercase
                    = options.Password.RequireNonAlphanumeric
                    = options.Password.RequireUppercase
                    = false;
                })
                    .AddEntityFrameworkStores<ChatApplicationDBContext>();
            });
            
        }
    }
}