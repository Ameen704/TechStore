using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TechStore.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
