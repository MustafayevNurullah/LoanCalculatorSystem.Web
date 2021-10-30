using LoanCalculatorSystem.Core.Models;
using LoanCalculatorSystem.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanCalculatorSystem.Data.Repositories
{
   public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public InvoiceRepository(AppDbContext context) : base(context)
        {
        }

    }
}
