namespace oldCapitalWeb.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using oldCapitalWeb.Data.Models;

    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Article> Articles { get; init; } = null!;

        public DbSet<Message> Messages { get; init; } = null!;

        public DbSet<ContactUs> Contacts { get; init; } = null!;

        public DbSet<Artist> Artists { get; init; } = null!;

        public DbSet<FaQ> FaQs { get; init; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}