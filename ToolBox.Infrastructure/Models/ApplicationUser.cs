using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static ToolBox.Infrastructure.Constants.ValidationConstants;

namespace ToolBox.Infrastructure.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(MaxApplicationUserFirstNameLength)]
        [Comment("ApplicationUser's first name")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(MaxApplicationUserLastNameLength)]
        [Comment("ApplicationUser's last name")]
        public string LastName { get; set; } = string.Empty;

        public ICollection<Order> Orders = new HashSet<Order>();

        public ICollection<DeliveryAddress> DeliveryAddresses = new HashSet<DeliveryAddress>();

    }
}
