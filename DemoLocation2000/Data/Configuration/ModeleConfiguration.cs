using DemoLocation2000.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoLocation2000.Data.Configuration
{
    public class ModeleConfiguration : IEntityTypeConfiguration<Modele>
    {
        public void Configure(EntityTypeBuilder<Modele> builder)
        {
            builder.HasData(new Modele()
            {
                Id = 1,
                Nom = "Edge"
            }, new()
            {
                Id = 2,
                Nom = "Focus"
            });
        }
    }
}
