using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PregledPlus.Models
{
    public class Vozilo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id{ get; set; }
        [Required]
        [StringLength(maximumLength:17,MinimumLength =17)]
        public string broj_sasije { get; set; }
        [Required]
        public string reg_oznaka { get; set; }
        [Required]
        public string tip { get;set; }
        [Required]
        public string marka { get; set; }
        [Required]
        public string model { get; set; }
        [Required]
        public DateTime godiste { get; set; }
        [Required]
        public int konjska_snaga { get; set; }  


    }
}
