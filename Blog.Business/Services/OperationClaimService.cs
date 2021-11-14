using Blog.Business.Contracts;
using Blog.DataAccess.Contracts;
using Core.Constants;
using Core.Entities.User;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Services
{
    public class OperationClaimService : IOperationClaimService
    {
        IOperationClaimRepository operationClaimRepository;

        public OperationClaimService(IOperationClaimRepository operationClaimRepository)
        {
            this.operationClaimRepository = operationClaimRepository;
            var operationClaim = new OperationClaim() { Id = 1, Name = "Admin", Status = true, UpdateDate = DateTime.Now };
            this.operationClaimRepository.Add(operationClaim);
        }

        public IResult Add(OperationClaim entity)
        {
            
            this.operationClaimRepository.Add(entity);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(OperationClaim entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<OperationClaim>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<OperationClaim> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<OperationClaim> Update(OperationClaim entity)
        {
            throw new NotImplementedException();
        }
    }
}
