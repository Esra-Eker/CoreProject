using System.ComponentModel.DataAnnotations;

namespace Core_Project.Areas.User.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını girin.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifrreyi girin.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar girin.")]
        [Compare("Password",ErrorMessage = "Şifreler uyumlu değil.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen mail girin.")]
        public string Mail { get; set; }
    }
}
