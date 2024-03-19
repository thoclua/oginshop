﻿using Microsoft.AspNetCore.Identity;

namespace oginshop_doan4.Data
{

    public class DbSeedRole
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public DbSeedRole(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
       public async Task RoleData()
        {
             await _roleManager.CreateAsync(new IdentityRole { Name = "ADMIN", NormalizedName = "ADMIN"});
             

        }
    }
}
