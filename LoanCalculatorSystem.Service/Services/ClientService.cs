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
    public class ClientService : Service<Client>, IClientService
    {
        public ClientService(IUnitOfWork unitOfWork, IRepository<Client> repository) : base(unitOfWork, repository)
        {
        }

        public async  Task<List<Client>> GetClientsAsync()
        {
            
            return await _unitOfWork.Clients.GetClientsAsync();
        }
    }
}
