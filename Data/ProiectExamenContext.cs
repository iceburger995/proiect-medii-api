using Microsoft.EntityFrameworkCore;
using ProiectExamen.Entities;
using Microsoft.Extensions.Configuration;

namespace ProiectExamen.Data
{
    public class ProiectExamenContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public ProiectExamenContext (DbContextOptions<ProiectExamenContext> options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("ProiectExamenContext"));
        }

        public DbSet<User> Users { get; set; }
    }
}
