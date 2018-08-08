﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SPA.PhoneBook.Configuration;
using SPA.PhoneBook.Web;

namespace SPA.PhoneBook.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PhoneBookDbContextFactory : IDesignTimeDbContextFactory<PhoneBookDbContext>
    {
        public PhoneBookDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PhoneBookDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PhoneBookDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PhoneBookConsts.ConnectionStringName));

            return new PhoneBookDbContext(builder.Options);
        }
    }
}
