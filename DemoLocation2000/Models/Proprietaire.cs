using System.ComponentModel.DataAnnotations.Schema;

namespace DemoLocation2000.Models
{
    public class Proprietaire
    {
        public int Id { get; set; }

        public string Prenom { get; set; } = default!;

        public string Nom { get; set; } = default!;

        [NotMapped]
        public string NomComplet => string.Join(" ", Prenom, Nom);

        public ICollection<Voiture> Autos { get; set; } = default!;
    }
}
