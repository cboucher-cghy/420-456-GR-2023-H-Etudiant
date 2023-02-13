namespace DemoLocation2000.Models
{
    public class Voiture
    {
        public string Nom { get; set; } = default!;
        public int Id { get; set; }
        public Marque? Marque { get; set; } = default!;
        public int MarqueId { get; set; }
        public int Annee { get; set; }
    }
}
