﻿// ======================================
// Author: Ebenezer Monney
// Email:  info@ebenmonney.com
// Copyright (c) 2017 www.ebenmonney.com
// ======================================

using DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Core;
using DAL.Core.Interfaces;

namespace DAL
{
    public interface IDatabaseInitializer
    {
        Task Seed();
    }




    public class DatabaseInitializer : IDatabaseInitializer
    {
        private readonly ApplicationDbContext _context;
        private readonly IAccountManager _accountManager;
        private readonly ILogger _logger;

        public DatabaseInitializer(ApplicationDbContext context, IAccountManager accountManager, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager,
            ILogger<DatabaseInitializer> logger)
        {
            _accountManager = accountManager;
            _context = context;
            _logger = logger;
        }

        public async Task Seed()
        {
            await _context.Database.MigrateAsync().ConfigureAwait(false);

            if (!await _context.Users.AnyAsync())
            {
                const string adminRoleName = "administrator";
                const string userRoleName = "user";
                await ensureRole(adminRoleName, "Default administrator", ApplicationPermissions.GetAllPermissionValues());
                await ensureRole(userRoleName, "Default user", new string[] { });

                await createUser("admin", "tempP@ss123", "Inbuilt Administrator", "admin@ebenmonney.com", "+1 (123) 000-0000", new string[] { adminRoleName });
                await createUser("user", "tempP@ss123", "Inbuilt Standard User", "user@ebenmonney.com", "+1 (123) 000-0001", new string[] { userRoleName });
            }



            if (!await _context.Providers.AnyAsync() && !await _context.Patients.AnyAsync())
            {
                Patient pat_1 = new Patient
                {
                    Name = "Ebenezer Monney",
                    Email = "contact@ebenmonney.com",
                    Gender = Gender.Male,
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow
                };

                Patient pat_2 = new Patient
                {
                    Name = "Ben Ahmed Zohra",
                    Email = "zouzou678@gmail.com",
                    PhoneNumber = "+81123456789",
                    Address = "Some fictional Address, Street 123, Konoha",
                    City = "Rades",
                    Gender = Gender.Female,
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow
                };

                Patient pat_3 = new Patient
                {
                    Name = "John Doe",
                    Email = "johndoe@anonymous.com",
                    PhoneNumber = "+18585858",
                    Address = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio.
                    Praesent libero. Sed cursus ante dapibus diam. Sed nisi. Nulla quis sem at nibh elementum imperdiet",
                    City = "Lorem Ipsum",
                    Gender = Gender.Male,
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow
                };

                Patient pat_4 = new Patient
                {
                    Name = "Jane Doe",
                    Email = "Janedoe@anonymous.com",
                    PhoneNumber = "+18585858",
                    Address = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio.
                    Praesent libero. Sed cursus ante dapibus diam. Sed nisi. Nulla quis sem at nibh elementum imperdiet",
                    City = "Lorem Ipsum",
                    Gender = Gender.Male,
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow
                };



                Provider pro_1 = new Provider
                {
                    Name = "Jane Doe",
                    Email = "Janedoe@anonymous.com",
                    PhoneNumber = "+18585858",
                    Address = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio.
                    Praesent libero. Sed cursus ante dapibus diam. Sed nisi. Nulla quis sem at nibh elementum imperdiet",
                    City = "Lorem Ipsum",
                    Gender = Gender.Male,
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow
                };


                Provider pro_2 = new Provider
                {
                    Name = "Jane Doe",
                    Email = "Janedoe@anonymous.com",
                    PhoneNumber = "+18585858",
                    Address = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio.
                    Praesent libero. Sed cursus ante dapibus diam. Sed nisi. Nulla quis sem at nibh elementum imperdiet",
                    City = "Lorem Ipsum",
                    Gender = Gender.Male,
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow
                };

               


                _context.Patients.Add(pat_1);
                _context.Patients.Add(pat_2);
                _context.Patients.Add(pat_3);
                _context.Patients.Add(pat_4);

                _context.Providers.Add(pro_1);
                _context.Providers.Add(pro_2);

                
                await _context.SaveChangesAsync();
            }
        }



        private async Task ensureRole(string roleName, string description, string[] claims)
        {
            if ((await _accountManager.GetRoleByNameAsync(roleName)) == null)
            {
                ApplicationRole applicationRole = new ApplicationRole(roleName, description);

                var result = await this._accountManager.CreateRoleAsync(applicationRole, claims);

                if (!result.Item1)
                    throw new Exception($"Seeding \"{description}\" role failed. Errors: {string.Join(Environment.NewLine, result.Item2)}");
            }
        }

        private async Task createUser(string userName, string password, string fullName, string email, string phoneNumber, string[] roles)
        {
            ApplicationUser applicationUser = new ApplicationUser
            {
                UserName = userName,
                FullName = fullName,
                Email = email,
                PhoneNumber = phoneNumber,
                EmailConfirmed = true,
                IsEnabled = true
            };

            var result = await _accountManager.CreateUserAsync(applicationUser, roles, password);

            if (!result.Item1)
                throw new Exception($"Seeding \"{userName}\" user failed. Errors: {string.Join(Environment.NewLine, result.Item2)}");
        }
    }
}
