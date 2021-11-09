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
    public class CategoriesController : ControllerBase, ICoreCrudController<ActionResult, Category>
    {
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost("Add")]
        public ActionResult Add(Category entity)
        {
            var result = _categoryService.Add(entity);
            return Ok(result.Message);
        }

        [HttpPost("Delete")]
        public ActionResult Delete(Category entity)
        {
            var result = _categoryService.Delete(entity);
            return Ok(result.Message);
        }

        [HttpPost("GetAll")]
        public ActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("GetById")]
        public ActionResult GetById(int id)
        {
            var result = _categoryService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("Update")]
        public ActionResult Update(Category entity)
        {
            var result = _categoryService.Update(entity);
            return Ok(result.Message);
        }
    }
}
