using Blog.Business.Contracts;
using Blog.DataAccess.Contracts;
using Blog.Entities.Models;
using Core.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using Core.Utilities.Uploads.FileHelper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Blog.Business.Services
{
    public class ImageService : IImageService
    {
        IImageRepository _imageRepository;

        public ImageService(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public IResult Add(Image entity)
        {
            _imageRepository.Add(entity);
            return new SuccessResult(Messages.Added);
        }

        //Image Add IFormfile
        public IResult Add(IFormFile file, Image image)
        {
            var result = BusinessRules.Run(
               CheckIfImageExtensionValid(file));

            if (result != null)
            {
                return result;
            }


            image.ImagePath = FileHelper.Add(file, @"/Images\");
            image.UpdateDate = DateTime.Now;
            _imageRepository.Add(image);
            return new SuccessResult(Messages.Added);
        }

        //Image AddCollective IFormfile
        public IResult AddCollective(IFormFile[] files, Image image)
        {
            //TODO : i => i.Id == image.Id  Id'Ler Blog id ye dönüşecek ve image/blog tabloları birbirine bağlanacak
            List<Image> gelAll = _imageRepository.GetAll(i => i.Id == image.Id);
            var result = (gelAll.Count() >= 5);

            if (!result)
            {
                
                foreach (var file in files)
                {
                    image = new Image { Id = image.Id };
                     Add(file, image);
                }
                return new SuccessResult(Messages.Added);

            }

            return new ErrorResult(Messages.InvalidExtension);
        }
        //Image GetById List IFormfile
        public IDataResult<List<Image>> GetImagesById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Image entity)
        {
            _imageRepository.Delete(entity);
            return new SuccessResult(Messages.Deleted);
        }
        public IDataResult<List<Image>> GetAll()
        {
            var result = _imageRepository.GetAll();
            if (result != null)
            {
                return new SuccessDataResult<List<Image>>(result, Messages.Listed);
            }
            return new ErrorDataResult<List<Image>>(Messages.DataNotFound);
        }

        public IDataResult<Image> GetById(int id)
        {
            var result = _imageRepository.Get(x => x.Id == id);
            if (result != null)
            {
                return new SuccessDataResult<Image>(result, Messages.Listed);
            }
            return new ErrorDataResult<Image>(Messages.DataNotFound);
        }

        

        public IDataResult<Image> Update(Image entity)
        {
            entity.UpdateDate = DateTime.Now;
            _imageRepository.Update(entity);

            return new SuccessDataResult<Image>(Messages.Updated);
        }



        private IResult CheckIfImageExtensionValid(IFormFile file)
        {
            string[] validImageFileTypes = { ".JPG", ".JPEG", ".PNG", ".TIF", ".TIFF", ".GIF", ".BMP", ".ICO", ".WEBP" };
            var result = validImageFileTypes.Any(t => t == Path.GetExtension(file.FileName).ToUpper());
            if (!result)
            {
                return new ErrorResult(Messages.InvalidExtension);
            }
            return new SuccessResult();
        }
    }

}
