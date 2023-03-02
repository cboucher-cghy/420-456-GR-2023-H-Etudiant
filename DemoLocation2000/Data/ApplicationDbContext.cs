using DemoLocation2000.Data.Configuration;
using DemoLocation2000.Models;
using Microsoft.EntityFrameworkCore;
using DemoLocation2000.ViewModels;

namespace DemoLocation2000.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ModeleConfiguration());

            //modelBuilder.Entity<Modele>().HasData(new Modele()
            //{
            //    Id = 2,
            //    Nom = "Focus"
            //});
        }

        public DbSet<Voiture> Voitures { get; set; } = default!;

        public DbSet<Marque> Marques { get; set; } = default!;
        public DbSet<Modele> Modeles { get; set; } = default!;

        public DbSet<Proprietaire> Proprietaires { get; set; } = default!;

        public DbSet<DemoLocation2000.ViewModels.MarqueIndexVM> MarqueIndexVM { get; set; }
    }
}
