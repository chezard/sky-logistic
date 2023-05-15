using Logistic.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Logistic.ViewModels
{
    public class CreateAddressVM
    {
        public int Id { get; set; }
        public string TopGroup { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
