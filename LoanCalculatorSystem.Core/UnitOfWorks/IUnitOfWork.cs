using LoanCalculatorSystem.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculatorSystem.Core.UnitOfWorks
{
   public interface IUnitOfWork
    {
        IClientRepository Clients { get; }
        ILoanRepository Loans { get; }
        IInvoiceRepository Invoices { get; }
        Task CommitAsync();

        void Commit();
    }

}
