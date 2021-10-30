using LoanCalculatorSystem.Core.Repositories;
using LoanCalculatorSystem.Core.Services;
using LoanCalculatorSystem.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculatorSystem.Service.Services
{
   public class Service<TEntity> : IService<TEntity> where TEntity : class
    {

        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<TEntity> _repository;

        public Service(IUnitOfWork unitOfWork, IRepository<TEntity> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
        public Task<TEntity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
