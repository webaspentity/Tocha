using System.ComponentModel.DataAnnotations;

namespace Tocha.Data;

public class ConnectionModel
{
    [Required(ErrorMessage = "Введите адрес электронной почты")]
    [EmailAddress(ErrorMessage = "Неверный адрес электронной почты")]
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }
}
