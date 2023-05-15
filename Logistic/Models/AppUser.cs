using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Logistic.Models
{
    public class AppUser:IdentityUser
    {
        [Required]
        public string Fullname { get; set; }

        
    }
}
