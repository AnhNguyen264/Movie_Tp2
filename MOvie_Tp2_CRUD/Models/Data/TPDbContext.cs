using Microsoft.EntityFrameworkCore;

namespace TP2.Models.Data
{
    public class TPDbContext:DbContext
    {
        public TPDbContext(DbContextOptions<TPDbContext> options) : base(options)
        {
        }

        public DbSet<Enfant> Enfants { get; set; }
        public DbSet<Parent> Parents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.SetEntityRelationships();
            modelBuilder.GenerateData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
