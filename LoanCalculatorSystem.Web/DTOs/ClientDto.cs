using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanCalculatorSystem.Web.DTOs
{
    public class ClientDto
    {
        public string CLientUniqueID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TelephoneNr { get; set; }
    }
}
