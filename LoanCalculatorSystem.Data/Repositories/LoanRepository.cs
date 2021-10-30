using LoanCalculatorSystem.Core.Models;
using LoanCalculatorSystem.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculatorSystem.Data.Repositories
{
    public class LoanRepository : Repository<Loan>, ILoanRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public LoanRepository(AppDbContext context) : base(context)
        {
        }

        public Task<Loan> GetLoansAsync()
        {
            throw new NotImplementedException();
        }
    }
}
