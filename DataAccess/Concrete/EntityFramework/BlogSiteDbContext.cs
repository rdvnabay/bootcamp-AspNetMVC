using Entities.Concrete;
using System.Data.Entity;

namespace DataAccess.Concrete.EntityFramework
{
    public class BlogSiteDbContext:DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}