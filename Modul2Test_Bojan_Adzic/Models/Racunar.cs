using System.ComponentModel.DataAnnotations;

namespace Modul2Test_Bojan_Adzic.Models
{
    public class Racunar
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Obavezno polje za unos")]
        public string Naziv { get; set; }
        [Required(ErrorMessage = "Obavezno polje za unos")]
        [Range(1, 10, ErrorMessage = "Godina garancije mora biti od 1 do 10")]
        public int BrojGodinaGarancije { get; set; }
        [Required(ErrorMessage = "Obavezno polje za unos")]
        [Range(10000, 500000, ErrorMessage = "Cena mora biti u rasponu izmedju 10 000 i 500 000")]
        public int Cena { get; set; }
        [Required(ErrorMessage = "Obavezno polje za unos")]
        [StringLength(30, ErrorMessage = "Tip ne sme biti duzi od 30 karaktera")]
        public string Tip { get; set; }
        public bool StudentskiPopust { get; set; }
    }
}
