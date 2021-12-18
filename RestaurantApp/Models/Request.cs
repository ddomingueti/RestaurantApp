using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RestaurantApp.Models
{
    public class Request : Entity
    {
        [Required]
        public ICollection<Product> Products { get; set; }
        
        [Column(TypeName = "money")]
        public decimal TotalValue { get; set; }
        public PaymentStatus Status { get; set; }
        public string PaymentType { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        public Request()
        {
            Products = new List<Product>();
            PaymentType = String.Empty;
        }
    }

    public enum PaymentStatus
    {
        Open,
        Closed,
    }
}
