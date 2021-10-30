using LoanCalculatorSystem.Core.Models;
using LoanCalculatorSystem.Core.Repositories;
using LoanCalculatorSystem.Core.Services;
using LoanCalculatorSystem.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculatorSystem.Service.Services
{
    public class LoanService : Service<Loan>, ILoanService
    {

        public LoanService(IUnitOfWork unitOfWork, IRepository<Loan> repository) : base(unitOfWork, repository)
        {
        }

        

        public List<Loan> CalculatedLoanAsync(int amount, int month, int rate, DateTime date)
        {
            


            return null;
        }

        public Task<Loan> GetLoansAsync()
        {
            throw new NotImplementedException();
        }
    }
}
