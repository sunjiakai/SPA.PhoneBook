using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SPA.PhoneBook.Authorization.Roles;
using SPA.PhoneBook.Authorization.Users;
using SPA.PhoneBook.MultiTenancy;
using SPA.PhoneBook.PhoneBook.Persons;
using SPA.PhoneBook.PhoneBook.PhoneNumbers;

namespace SPA.PhoneBook.EntityFrameworkCore
{
    public class PhoneBookDbContext : AbpZeroDbContext<Tenant, Role, User, PhoneBookDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PhoneBookDbContext(DbContextOptions<PhoneBookDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<PhoneNumber> Phonenumbers { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Person>().ToTable("Person", "PB");
        //    modelBuilder.Entity<PhoneNumber>().ToTable("PhoneNumber", "PB");
        //    base.OnModelCreating(modelBuilder);
        //}

    }
}
