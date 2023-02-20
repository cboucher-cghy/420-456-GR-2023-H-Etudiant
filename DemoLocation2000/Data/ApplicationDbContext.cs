using DemoLocation2000.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoLocation2000.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Voiture> Voitures { get; set; } = default!;

        public DbSet<Marque> Marques { get; set; } = default!;
        public DbSet<Modele> Modeles { get; set; } = default!;

        public DbSet<Proprietaire> Proprietaires { get; set; } = default!;
    }
}
