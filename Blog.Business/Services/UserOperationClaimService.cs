using Blog.Business.Contracts;
using Blog.DataAccess.Contracts;
using Core.Constants;
using Core.Entities.User;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;

namespace Blog.Business.Services
{
    public class UserOperationClaimService : IUserOperationClaimService
    {
        IUserOperationClaimRepository userOperationClaimRepository;

        public UserOperationClaimService(IUserOperationClaimRepository userOperationClaimRepository)
        {
            this.userOperationClaimRepository = userOperationClaimRepository;
        }

        public IResult Add(UserOperationClaim entity)
        {
            this.userOperationClaimRepository.Add(entity);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(UserOperationClaim entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserOperationClaim>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<UserOperationClaim> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<UserOperationClaim> Update(UserOperationClaim entity)
        {
            throw new NotImplementedException();
        }
    }
}
