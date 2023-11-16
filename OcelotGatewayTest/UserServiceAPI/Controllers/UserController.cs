using Microsoft.AspNetCore.Mvc;
using UserServiceAPI.Models;

namespace UserServiceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet(Name = "GetUsers")]
        public IEnumerable<User> Get()
        {
            return _userService.GetUsers();
        }
    }
}
