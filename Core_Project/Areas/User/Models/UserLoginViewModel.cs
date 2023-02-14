using System.ComponentModel.DataAnnotations;

namespace Core_Project.Areas.User.Models
{
    public class UserLoginViewModel
    {
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı adını girin.")]
        public string Username { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifreyi girin.")]
        public string Password { get; set; }
    }
}
