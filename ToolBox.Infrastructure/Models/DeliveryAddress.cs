using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ToolBox.Infrastructure.Constants.ValidationConstants;
namespace ToolBox.Infrastructure.Models
{
    public class DeliveryAddress
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string DeliveryType { get; set; } = string.Empty;

        [Required]
        [StringLength(MaxCityLength)]
        public string City { get; set; } = string.Empty;

        [Required]
        [StringLength(MaxStreetLength)]
        public string Street { get; set; } = string.Empty;

        [Required]
        [StringLength(PostalCodeLength)]
        public string PostalCode { get; set; } = string.Empty;

        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

    }
}

