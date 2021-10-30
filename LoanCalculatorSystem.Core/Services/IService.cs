using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculatorSystem.Core.Services
{
   public interface IService<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(int id);
    }
}
