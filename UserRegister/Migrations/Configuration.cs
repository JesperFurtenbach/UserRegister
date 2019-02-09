namespace UserRegister.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using UserRegister.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<UserRegister.Models.ApplicationDbContext>
    {

        private List<ApplicationUser> Users = new List<ApplicationUser>();

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "UserRegister.Models.ApplicationDbContext";
        }

        protected override void Seed(UserRegister.Models.ApplicationDbContext context)
        {
            Users.AddRange(new List<ApplicationUser>
            {
                new ApplicationUser
                {
                    Email = "jons.markand@userlist.se",
                    UserName = "Jöns Markand",
                    FirstName = "Jöns",
                    LastName = "Markand",
                    Street = "Fake Street",
                    Postcode = "123",
                    City = "Årstaberg",
                    Country = "Sweden",
                    PhoneNumber = "555-587-547"
                }
                
            });
        }
    }
}
