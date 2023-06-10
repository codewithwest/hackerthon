
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
namespace net_hack
{
    [Route("[controller]")]
    [ApiController]
    class UserController : ControllerBase
    {
        public UserController(UserUrlService UserService)
        {
            this.UserService = UserService;
        }
        public UserUrlService UserService { get; }
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return (IEnumerable<User>)UserService.GetUser();
        }

    }
}
