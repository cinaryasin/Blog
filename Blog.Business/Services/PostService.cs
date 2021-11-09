using Blog.Business.Contracts;
using Blog.DataAccess.Contracts;
using Blog.Entities.Models;
using Core.Constants;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Services
{
    public class PostService : IPostService
    {
        IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public IResult Add(Post entity)
        {
            _postRepository.Add(entity);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Post entity)
        {
            _postRepository.Delete(entity);
            return new SuccessResult(Messages.Deleted);
        }
        public IDataResult<List<Post>> GetAll()
        {
            var result = _postRepository.GetAll();
            if (result != null)
            {
                return new SuccessDataResult<List<Post>>(result, Messages.Listed);
            }
            return new ErrorDataResult<List<Post>>(Messages.DataNotFound);
        }

        public IDataResult<Post> GetById(int id)
        {
            var result = _postRepository.Get(x => x.Id == id);
            if (result != null)
            {
                return new SuccessDataResult<Post>(result, Messages.Listed);
            }
            return new ErrorDataResult<Post>(Messages.DataNotFound);
        }

        public IDataResult<Post> Update(Post entity)
        {
            entity.UpdateDate = DateTime.Now;
            _postRepository.Update(entity);

            return new SuccessDataResult<Post>(Messages.Updated);
        }
    }
}
