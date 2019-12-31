using System;
using Contracts.User;
using Microsoft.AspNetCore.Mvc;
using Urfu.Learn.Backend.Services;
using Urfu.Learn.Contracts.User;

namespace Urfu.Learn.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet("{userId}", Name = "Get")]
        public User Get(Guid userId)
        {
            var user = userService.Get(userId).GetAwaiter().GetResult();
            return user;
        }

        // POST: api/User
        [HttpPost]
        public void Save([FromBody] User user)
        {
            userService.Save(user).GetAwaiter().GetResult();
        }
    }
}