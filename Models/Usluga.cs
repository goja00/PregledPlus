using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PregledPlus.Models
{
    public class Usluga
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }
        [Required]
        public string naziv{ get; set; }
        [Required]
        public string opis { get; set; }
        [Required]
        public int cena { get; set; }
    }
}