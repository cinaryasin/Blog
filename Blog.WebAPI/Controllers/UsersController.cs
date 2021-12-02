using Blog.Business.Contracts;
using Core.Api;
using Core.Entities.User;
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
    public class UsersController : ControllerBase, ICoreCrudController<ActionResult, User>
    {
        IUserService userService;
        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpPost("Add")]
        public ActionResult Add(User entity)
        {
            var result = this.userService.Add(entity);
            return Ok(result.Message);

        }
        [HttpPost("Delete")]
        public ActionResult Delete(User entity)
        {
            var result = this.userService.Delete(entity);
            return Ok(result.Message);
        }
        [HttpGet("GetAll")]
        public ActionResult GetAll()
        {
            var result = this.userService.GetAll();
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }
        [HttpPost("GetById")]
        public ActionResult GetById(int id)
        {
            var result = this.userService.GetById(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);

            }
            return Ok(result.Data);
        }
        [HttpPost("Update")]
        public ActionResult Update(User entity)
        {
            var result = this.userService.Update(entity);
            return Ok(result.Message); 
        }
    }
}
