using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutoPro.Models
{
    public class Marque
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Provide Make")]
        public string NomMarque { get; set; }
    }
}