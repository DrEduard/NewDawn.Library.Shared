using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using NewDawn.Core.Models.Entities;

namespace NewDawn.Core.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
        [Required]
        private string SpecialIdentificationNumber { get; set; }
        [Required]
        private string FirstName { get; set; }
        [Required]
        private string LastName { get; set; }
        [Required]
        private string Address { get; set; }
        [Required]
        private string City { get; set; }
        [Required]
        private Country Country { get; set; }
      
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

        DbSet<Class> Class { get; set; }
        DbSet<Country> Country { get; set; }
        DbSet<Document> Document { get; set; }
        DbSet<Field> Field { get; set; }
        DbSet<GradeSystem> GradeSystem { get; set; }
        DbSet<Institution> Institution { get; set; }
        DbSet<InstProfAssoc> InstProfAssoc { get; set; }
        DbSet<InstStudAssoc> InstStudAssoc { get; set; }
        DbSet<ProfClassAssoc> ProfClassAssoc { get; set; }
        DbSet<Semester> Semester { get; set; }
        DbSet<StudClassSemAssoc> StudClassSemAssoc { get; set; }

    }
}