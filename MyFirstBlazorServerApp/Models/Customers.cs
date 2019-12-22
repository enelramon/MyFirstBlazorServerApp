using System;
using System.ComponentModel.DataAnnotations;

namespace MyFirstBlazorServerApp.Models
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }


        [Required(ErrorMessage ="Name is required")]
        [StringLength(100, ErrorMessage ="Name is too long.")]
        public string Names { get; set; }

        [Required(ErrorMessage = "eMail is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "LastDate is required")]
        public DateTime LastDate { get; set; } = DateTime.Now;

        [Range(0,100000,ErrorMessage ="Amount must be between 1 and 100,000")]
        public decimal Amount { get; set; }
                    
    }
}
