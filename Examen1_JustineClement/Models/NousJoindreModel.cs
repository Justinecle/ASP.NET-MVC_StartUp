using System.ComponentModel.DataAnnotations;

namespace Examen1_JustineClement.Models
{
    public class NousJoindreModel
    {
        [Required(ErrorMessage = "Le nom est obligatoire")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "L'adresse e-mail est obligatoire")]
        [EmailAddress(ErrorMessage = "Veuillez entrer une adresse e-mail valide")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le numéro de téléphone est obligatoire")]
        [RegularExpression(@"^\d{10}$",
            ErrorMessage = "Veuillez entrer un numéro de téléphone valide")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Le message est obligatoire")]
        public string Message { get; set; }
    }
}
