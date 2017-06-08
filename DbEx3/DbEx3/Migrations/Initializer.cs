using System;
using DbEx3.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Linq;
using Project.Common;
using System.Data.Entity.Migrations;

namespace DbEx3.Migrations
{
    internal class Initializer
    {
        internal static void SeedRoles(ApplicationDbContext context)
        {
            string[] roles =
            {
                "Administator",
                "Manager",
                "Editor",
                "Buyer",
                "Business",
                "Seller",
                "Subscriber",
                "Guest",
                "Student"
            };

            foreach(var role in roles)
            {
                var roleStore = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

                if(context.Roles.Any(r =>r.Name == role))
                {
                    roleStore.Create(new IdentityRole(role));
                }
            }
        }

        internal static void SeedUser(ApplicationDbContext context)
        {
            string userName = "KIni";
            string role = "Owner";
            var userRole = new IdentityRole { Id = new CustomId().ToString(), Name = role };
            context.Roles.Add(userRole);

            var hasher = new PasswordHasher();

            var user = new ApplicationUser
            {
                UserName = userName,
                PasswordHash = hasher.HashPassword("1"),
                Email = "pici@domain.com",
                EmailConfirmed = true,
                SecurityStamp = new CustomId().ToString()
            };

            user.Roles.Add(new IdentityUserRole { RoleId = userRole.Id, UserId = user.Id});
            context.Users.AddOrUpdate(user);
        }
    }
}