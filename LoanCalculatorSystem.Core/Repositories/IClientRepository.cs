﻿using LoanCalculatorSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculatorSystem.Core.Repositories
{
   public interface IClientRepository:IRepository<Client>
    {
       Task<List<Client>> GetClientsAsync();


    }
}
