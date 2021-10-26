using System.ComponentModel.DataAnnotations;

namespace Texnicum.ViewModels.Account
{
    public class LoginViewModel
    {
        //Данные
        [Required(ErrorMessage = "Введите E-mail")]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
