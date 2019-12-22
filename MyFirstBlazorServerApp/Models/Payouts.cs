using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlazorServerApp.Models
{
    public class Payouts
    {
        [Key]
        public int PayoutId { get; set; }
        public DateTime PayDate { get; set; }
        public int InvoiceId { get; set; }
        public decimal Amount { get; set; }
    }
}
