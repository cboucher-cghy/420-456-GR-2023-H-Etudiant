using System.ComponentModel.DataAnnotations;

namespace DemoLocation2000.ViewModels
{
    public class MarqueCreateVM
    {
        [MinLength(2)]
        [Required(ErrorMessage = "Ce champ doit être rempli!")]
        public string NomMarque { get; set; } = default!;
    }
}
