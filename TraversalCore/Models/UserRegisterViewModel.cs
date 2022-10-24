using System.ComponentModel.DataAnnotations;

namespace TraversalCore.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="LÜTFEN ADINIZI GİRİNİZ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "LÜTFEN SOYADINIZI GİRİNİZ")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "LÜTFEN KULLANICI ADINIZI GİRİNİZ")]
        public string Username { get; set; }
        [Required(ErrorMessage = "LÜTFEN MAİL ADRESİNİ GİRİNİZ")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "LÜTFEN ŞİFREYİ GİRİNİZ")]
        public string Password { get; set; }

        [Required(ErrorMessage = "LÜTFEN ŞİFREYİ TEKRAR GİRİNİZ")]
        [Compare("Password",ErrorMessage ="ŞİFRELER UYUMLU DEĞİL")]
        public string ConfirmPassword { get; set; }
    }
}
