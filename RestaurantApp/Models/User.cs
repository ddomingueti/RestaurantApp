using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RestaurantApp.Models
{
    public abstract class User : Entity
    {
        [MinLength(8)] 
        [MaxLength(20)]
        [Required(ErrorMessage = "É necessário uma senha que tenha entre 8 e 20 caracteres.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "As senhas devem ser iguais.")]
        [NotMapped]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Formato inválido de email.")]
        public string Email { get; set; } = string.Empty;

        [MinLength(8)]
        [MaxLength(20)]
        [Required(ErrorMessage = "É necessário escolher um nome de usuário entre 8 e 20 caracteres.")]
        public string UserName { get; set; } = string.Empty;

    }
}
