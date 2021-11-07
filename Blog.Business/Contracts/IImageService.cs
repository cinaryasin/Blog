using Blog.Entities.Models;
using Core.Business;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Blog.Business.Contracts
{
    public interface IImageService : ICrudService<Image>
    {

        IDataResult<List<Image>> GetImagesById(int id);
        IResult Add(IFormFile file, Image image);
        IResult AddCollective(IFormFile[] files, Image image);


    }
}
