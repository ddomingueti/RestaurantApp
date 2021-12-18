using System.ComponentModel.DataAnnotations;
namespace RestaurantApp.Models
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
