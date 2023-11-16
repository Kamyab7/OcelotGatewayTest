using BlogServiceAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogServiceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly BlogService _blogService;

        public BlogController(BlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet(Name = "GetBlogs")]
        public IEnumerable<Blog> Get()
        {
            return _blogService.GetBlogs();
        }
    }
}
