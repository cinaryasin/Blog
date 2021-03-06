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
    public class UserService : IUserService
    {
        IUserRepository _userRepository;
        IUserOperationClaimService _userOperationClaimService;

        public UserService(IUserRepository userRepository, IUserOperationClaimService userOperationClaimService)
        {
            _userRepository = userRepository;
            _userOperationClaimService = userOperationClaimService;
        }

        public IResult Add(User entity)
        {
            
            var resultId = GetById(entity.Id);
            var resultName = GetByName(entity.UserName);

            if (resultId.Success && resultName.Success)
            {
                return new ErrorDataResult<User>(Messages.UserAlreadyExists);
            }
            
            _userRepository.Add(entity);
            UserOperationClaim userOperationClaim = new UserOperationClaim() { OperationClaimId = 2, UserId = entity.Id };
            _userOperationClaimService.Add(userOperationClaim);
            return new SuccessResult(Messages.Added);

        }

        public IResult Delete(User entity)
        {
            var result = GetById(entity.Id);

            if (result.Success)
            {
                _userRepository.Delete(entity);

                return new SuccessDataResult<User>(Messages.Deleted);
            }

            return new ErrorDataResult<User>(Messages.UserNotFound);
        }

        public IDataResult<List<User>> GetAll()
        {
            var result = _userRepository.GetAll();
            if (result != null)
            {
                return new SuccessDataResult<List<User>>(result,Messages.Listed);
            }
            return new ErrorDataResult<List<User>>(Messages.DataNotFound);
        }

        public IDataResult<User> GetByEmail(string email)
        {
            var result = _userRepository.Get(x => x.Email == email);
            if (result != null)
            {
                return new SuccessDataResult<User>(result, Messages.Listed);
            }
            return new ErrorDataResult<User>(Messages.UserNotFound);
        }

        public IDataResult<User> GetById(int id)
        {
            var result = _userRepository.Get(x => x.Id == id);
            if (result != null)
            {
                return new SuccessDataResult<User>(result, Messages.Listed);
            }
            return new ErrorDataResult<User>(Messages.UserNotFound);
        }


        public IDataResult<User> GetByName(string name)
        {
            var result = _userRepository.Get(x => x.FirstName == name);
            if (result != null)
            {
                return new SuccessDataResult<User>(result, Messages.Listed);
            }
            return new ErrorDataResult<User>(Messages.UserNotFound);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userRepository.GetClaims(user);
        }

        public IDataResult<User> Update(User entity)
        {
            var result = GetById(entity.Id);

            if (result.Success)
            {
                _userRepository.Update(entity);

                return new SuccessDataResult<User>(Messages.Updated);
            }

            return new ErrorDataResult<User>(Messages.UserNotFound);

        }
    }
}
