using System.ComponentModel.DataAnnotations;

namespace Drippyz.Models
{
    public class CartProducts : Products
    {
        [Required(ErrorMessage = "Quantity is required")]
        public int Quantity { get; set; }
    }
}
