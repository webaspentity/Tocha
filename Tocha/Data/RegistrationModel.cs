using System.ComponentModel.DataAnnotations;

namespace Tocha.Data;

public class RegistrationModel
{
    [Required(ErrorMessage = "Укажите номер телефона")]
    public string? Telephone { get; set; }

    [Required(ErrorMessage = "Укажите адрес электронной почты")]
    [DataType(DataType.EmailAddress)]
    [EmailAddress(ErrorMessage = "Неверный формат электронной почты")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Укажите пароль")]
    public string? Password { get; set; }
}
