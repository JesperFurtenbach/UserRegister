using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace UserRegister.Models
{
    public class ApplicationUser : IdentityUser
    {

        [Display(Name = "Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Full name")]
        public string FullName { get { return FirstName + " " + LastName; } }

        public string Street { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }

        public string Country { get; set; }

        [DataType(DataType.PhoneNumber)]
        public override string PhoneNumber { get; set; }


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}