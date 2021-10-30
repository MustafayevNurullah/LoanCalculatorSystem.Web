using LoanCalculatorSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculatorSystem.Core.Services
{
    public  interface ILoanService : IService<Loan>
    {

        Task<Loan> GetLoansAsync();
        List<Loan> CalculatedLoanAsync(int amount, int month, int rate, DateTime date);

    }
}
