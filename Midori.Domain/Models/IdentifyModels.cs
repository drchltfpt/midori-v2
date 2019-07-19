using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Midori.Domain.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class MidoriUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<MidoriUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class MidoriDbContext : IdentityDbContext<MidoriUser>
    {
        public DbSet<About> About { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<ContentTag> ContentTags { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Footer> Footer { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuType> MenuTypes { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public MidoriDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static MidoriDbContext Create()
        {
            return new MidoriDbContext();
        }
    }
}

