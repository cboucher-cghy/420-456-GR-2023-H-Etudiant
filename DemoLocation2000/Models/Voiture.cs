namespace DemoLocation2000.Models
{
    public class Voiture
    {
        public string Nom { get; set; } = default!;
        public int Id { get; set; }
        public Marque? MarqueVoiture { get; set; } = default!;
        //[ForeignKey(nameof(MarqueVoiture))]
        //public int? MarqueDuVehiculeId { get; set; }
        public int? MarqueId { get; set; } = default!;
        public int Annee { get; set; }
    }
}
