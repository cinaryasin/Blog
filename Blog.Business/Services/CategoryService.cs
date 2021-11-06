using Blog.Business.Contracts;
using Blog.DataAccess.Contracts;
using Blog.Entities.Models;
using Core.Constants;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;

namespace Blog.Business.Services
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IResult Add(Category entity)
        {
            _categoryRepository.Add(entity);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Category entity)
        {
            _categoryRepository.Delete(entity);
            return new SuccessResult(Messages.Deleted);
        }
        public IDataResult<List<Category>> GetAll()
        {
            var result = _categoryRepository.GetAll();
            if (result != null)
            {
                return new SuccessDataResult<List<Category>>(result, Messages.Listed);
            }
            return new ErrorDataResult<List<Category>>(Messages.DataNotFound);
        }

        public IDataResult<Category> GetById(int id)
        {
            var result = _categoryRepository.Get(x => x.Id == id);
            if (result != null)
            {
                return new SuccessDataResult<Category>(result, Messages.Listed);
            }
            return new ErrorDataResult<Category>(Messages.DataNotFound);
        }

        public IDataResult<Category> Update(Category entity)
        {
            entity.UpdateDate = DateTime.Now;
            _categoryRepository.Update(entity);
            
            return new SuccessDataResult<Category>(Messages.Updated);
        }
    }

}
