using BlogServiceAPI.Models;

namespace BlogServiceAPI
{
    public class BlogService
    {
        public static IEnumerable<Blog> Blogs = new List<Blog>()
        {
            new Blog()
            {
                Id=Guid.NewGuid().ToString(),
                Title=".NET 8",
                Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            },
            new Blog()
            {
                Id=Guid.NewGuid().ToString(),
                Title="Entity Framework",
                Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            }
        };

        public IEnumerable<Blog> GetBlogs() => Blogs;
    }
}
