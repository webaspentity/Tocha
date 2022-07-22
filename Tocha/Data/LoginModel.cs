using System.ComponentModel.DataAnnotations;

namespace Tocha.Data;

public class LoginModel
{
    [Required(ErrorMessage = "Введите номер телефона")]
    public string? Telephone { get; set; }

    [Required(ErrorMessage = "Введите пароль")]
    public string? Password { get; set; }
}
