using LoanCalculatorSystem.Core.Models;
using LoanCalculatorSystem.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculatorSystem.Core.Services
{
   public interface IClientService:  IService<Client>
    {
       Task<List<Client>> GetClientsAsync();
    }
}
