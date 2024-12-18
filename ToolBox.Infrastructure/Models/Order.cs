using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToolBox.Infrastructure.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public int DeliveryAddressId { get; set; }

        [ForeignKey(nameof(DeliveryAddressId))]
        public DeliveryAddress DeliveryAddress { get; set; } = null!;

        public ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
    }
}
