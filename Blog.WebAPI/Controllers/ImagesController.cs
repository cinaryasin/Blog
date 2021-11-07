using Blog.Business.Contracts;
using Blog.Entities.Models;
using Core.Api;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase, ICoreCrudController<ActionResult, Image>
    {
        IImageService _imageService;

        public ImagesController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpPost("Add")]
        public ActionResult Add(Image entity)
        {
            throw new NotImplementedException();
        }
        [HttpPost("AddImage")]
        public IActionResult Add([FromForm] IFormFile[] files, [FromForm] Image image)
        {

            var result = _imageService.AddCollective(files,image);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);


        }
        [HttpPost("Delete")]
        public ActionResult Delete(Image entity)
        {
            throw new NotImplementedException();
        }
        [HttpPost("GetAll")]
        public ActionResult GetAll()
        {
            throw new NotImplementedException();
        }
        [HttpPost("GetById")]
        public ActionResult GetById(int id)
        {
            throw new NotImplementedException();
        }
        [HttpPost("Update")]
        public ActionResult Update(Image entity)
        {
            throw new NotImplementedException();
        }
    }
}
