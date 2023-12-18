using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class Kontakt
    {
        public int KontaktId { get; set; }
        [Required(ErrorMessage="Wymagane podanie imienia")]
        public string Imie { get; set; }
        [Required(ErrorMessage="Wymagane podanie nazwiska")]
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public string NowePole { get; set; }
    }
}
