using Microsoft.AspNetCore.Identity;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace database2.Data
{

    public class SampleData
    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider)
        {
            //var serviceScope = serviceProvider.GetService<IservicescopeFactory>().CreateScope();
            var dbContext = serviceProvider.GetService<ApplicationDbContext>();
            var userManager = serviceProvider.GetService<UserManager<IdentityUser>>();
            var roleManager = serviceProvider.GetService<RoleManager<IdentityRole>>();

            string[] roles = new string[] { "Administrator", "User" };

            foreach (var role in roles)
            {
                var isExist = await roleManager.RoleExistsAsync(role);
                if (!isExist)
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            var adminUser = new IdentityUser
            {
                Email = "luis206639-st@rmutsb.ac.th",
                UserName = "luis206639-st@rmutsb.ac.th",
                SecurityStamp = Guid.NewGuid().ToString()
            };
            var currentUser = await userManager.FindByEmailAsync(adminUser.Email);
            if (currentUser == null)
            {
                await userManager.CreateAsync(adminUser, "Secret123!");
                currentUser = await userManager.FindByEmailAsync(adminUser.Email);

            }
            var isAdmin = await userManager.IsInRoleAsync(currentUser, "Administrator");
            if (!isAdmin)
            {
                await userManager.AddToRolesAsync(currentUser, roles);
            }

            var containSampleBook = await dbContext.Books.AnyAsync(b => b.Name == "Sample Book");
            if (!containSampleBook)
            {
                dbContext.Books.Add(new Models.Book
                {
                    Name = "Simple Book",
                    Price = 100m

                });
            }
            await dbContext.SaveChangesAsync();
        }
    }
}
