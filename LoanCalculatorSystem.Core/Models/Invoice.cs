using System;
using System.Collections.Generic;
using System.Text;

namespace LoanCalculatorSystem.Core.Models
{
   public class Invoice
    {
        public int Id { get; set; }
        public float Amount { get; set; }

        public DateTime DueDate { get; set; }
        public int InvoiceNr { get; set; }
        public int OrderNr { get; set; }

    }
}
