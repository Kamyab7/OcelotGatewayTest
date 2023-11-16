using UserServiceAPI.Models;

namespace UserServiceAPI
{
    public class UserService
    {
        private static IEnumerable<User> Users = new List<User>()
        {
            new User(){ Id=Guid.NewGuid().ToString(), UserName="Kamyab7"},
            new User(){ Id=Guid.NewGuid().ToString(), UserName="Sogand123"},
        };

        public IEnumerable<User> GetUsers() => Users;
    }
}
