using LoanCalculatorSystem.Core.Models;
using LoanCalculatorSystem.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculatorSystem.Data.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public ClientRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Client>> GetClientsAsync()
        {
            return await _appDbContext.Clients.ToListAsync();
        }
    }

        
    
}
