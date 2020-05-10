namespace TotoStatistics.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using TotoStatistics.Models;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public ApplicationDbContext()
        {
        }

        public DbSet<Toto> Toto { get; set; }

        public DbSet<SixOutOfForty_nine> SixOutOfFortyNine { get; set; }

        public DbSet<SixOutOfForty_two> SixOutOfFortyTwo { get; set; }

        public DbSet<FiveOutOfTthirty_five> FiveOutOfTthirtyFive { get; set; }

        public DbSet<Statistics> Statistics { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=SUPER-HP\\SQLEXPRESS;Database=TotoStatistics;Trusted_Connection=True;");
            }
        }
    }
}
