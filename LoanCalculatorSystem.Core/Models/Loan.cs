using ImageMagick;
using NBitcoin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LoanCalculatorSystem.Core.Models
{
    public class Loan
    {

        public int Id { get; set; }
        public float Amount { get; set; }
        public float InterestRate { get; set; }
        public int LoanPeriod { get; set; }
        public DateTime PayoutDate { get; set; }
        public Invoice Invoice { get; set; }
        public Client Client { get; set; }
        
       
        public int ClietnId { get; set; }

    }
}
