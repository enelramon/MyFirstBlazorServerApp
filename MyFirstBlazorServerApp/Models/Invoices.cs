using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlazorServerApp.Models
{
    public class Invoices
    {
        [Key]
        public int InvoiceId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }

    }
}
