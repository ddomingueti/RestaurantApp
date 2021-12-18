using System.ComponentModel.DataAnnotations;
namespace RestaurantApp.Models
{
    public class ClientUser : User
    {
        public ClientUser()
        {
            Address = string.Empty;
            FirstMidName = string.Empty;
            LastName = string.Empty;
            DocumentNumber = string.Empty;
            Requests = new List<Request>();
        }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(20)] 
        public string? AddressReference { get; set; }
        [StringLength(50)] public string FirstMidName { get; set; }
        [StringLength(50)] public string LastName { get; set; }
        
        [Display(Name = "Full name")] public string FullName { 
            get { return FirstMidName + " " + LastName; } 
        }

        [StringLength(11)] public string DocumentNumber { get; set; }

        [Required]
        [StringLength(11)] 
        public string PhoneNumber { get; set; }
        public ICollection<Request> Requests { get; set; }
    }
}
