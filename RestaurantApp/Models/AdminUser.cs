namespace RestaurantApp.Models
{
    public class AdminUser : User
    {
        public ICollection<User> UserList { get; set; }
        public ICollection<Product> ProductList { get; set; }
        public AdminUser()
        {
            UserList = new List<User>();
            ProductList = new List<Product>();
        }
    }
}
