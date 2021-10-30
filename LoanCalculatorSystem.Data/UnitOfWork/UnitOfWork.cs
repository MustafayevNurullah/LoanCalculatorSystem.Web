using LoanCalculatorSystem.Core.Repositories;
using LoanCalculatorSystem.Core.UnitOfWorks;
using LoanCalculatorSystem.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculatorSystem.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

       
        public IClientRepository Clients => new ClientRepository(_context);

        public ILoanRepository Loans => new LoanRepository(_context);

        public IInvoiceRepository Invoices => new InvoiceRepository(_context);

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

       
    }
}
