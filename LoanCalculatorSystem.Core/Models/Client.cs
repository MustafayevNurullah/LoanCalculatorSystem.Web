using System;
using System.Collections.Generic;
using System.Text;

namespace LoanCalculatorSystem.Core.Models
{
   public class Client
    {
        public int Id { get; set; }
        public string CLientUniqueID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TelephoneNr { get; set; }
        

        public List<Loan> Loans { get; set; }


        public Client()
        {
            Loans = new List<Loan>();
        }

    }
}
