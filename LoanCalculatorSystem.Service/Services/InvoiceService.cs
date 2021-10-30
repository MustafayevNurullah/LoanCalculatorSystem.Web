using LoanCalculatorSystem.Core.Models;
using LoanCalculatorSystem.Core.Repositories;
using LoanCalculatorSystem.Core.Services;
using LoanCalculatorSystem.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanCalculatorSystem.Service.Services
{
   public class InvoiceService  : Service<Invoice>, IInvoiceService
    {
        public InvoiceService(IUnitOfWork unitOfWork, IRepository<Invoice> repository) : base(unitOfWork, repository)
        {
        }
    }
}
