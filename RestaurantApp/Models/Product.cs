using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RestaurantApp.Models
{
    public class Product : Entity
    {
        [Required]
        [StringLength(20, ErrorMessage = "O nome do produto deve ter até 20 caracteres.")]
        public string Name { get; set; }
        
        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [StringLength(100)]
        public string? Image { get; set; }
        
        public decimal? Evaluation { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Muito Longo! Escreva até 50 caracteres.")]
        public string BriefDescription { get; set; }
        
        [StringLength(500)]
        public string? LongDescription { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "0:dd-MM-yyyy", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        public Product()
        {
            Image = String.Empty;
            Name = String.Empty;
            BriefDescription = String.Empty;
        }
    }
}
