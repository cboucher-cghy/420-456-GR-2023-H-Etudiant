﻿namespace DemoLocation2000.Models
{
    public class Marque
    {
        public int Id { get; set; }
        public string Nom { get; set; } = default!;
        public ICollection<Modele> Modeles { get; set; } = default!;
    }
}
