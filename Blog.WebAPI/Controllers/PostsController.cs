using Blog.Business.Contracts;
using Blog.Entities.Models;
using Core.Api;
using Microsoft.AspNetCore.Mvc;


namespace Blog.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase, ICoreCrudController<ActionResult, Post>
    {
        IPostService _postService;

        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpPost("Add")]
        public ActionResult Add(Post entity)
        {
            var result = _postService.Add(entity);
            return Ok(result.Message);
        }

        [HttpPost("Delete")]
        public ActionResult Delete(Post entity)
        {
            var result = _postService.Delete(entity);
            return Ok(result.Message);
        }

        [HttpGet("GetAll")]
        public ActionResult GetAll()
        {
            var result = _postService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("GetById")]
        public ActionResult GetById(int id)
        {
            var result = _postService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("Update")]
        public ActionResult Update(Post entity)
        {
            var result = _postService.Update(entity);
            return Ok(result.Message);
        }
    }
}
