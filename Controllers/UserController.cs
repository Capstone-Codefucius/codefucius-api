using Microsoft.AspNetCore.Mvc;
using codefucius_api.Models;
using codefucius_api.Data.EFCore;

namespace codefucius_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController<User, EfCoreUserRepository>
    {
        public UserController(EfCoreUserRepository repository) : base(repository)
        {
            if (repository.GetAll().Result.Count == 0)
            {
                CreateDummyUsers(repository);
            }
        }

        private void CreateDummyUsers(EfCoreUserRepository repository)
        {
            User user1 = new User();
            user1.name = "Greg Mann";
            user1.role = "Reviewee";
            repository.Add(user1).Wait();

            User user2 = new User();
            user2.name = "Darwin Fish";
            user2.role = "Reviewer";
            repository.Add(user2).Wait();

            User user3 = new User();
            user3.name = "Bilbo Baggins";
            user3.role = "Reviewee";
            repository.Add(user3).Wait();

            User user4 = new User();
            user4.name = "Man dude";
            user4.role = "Reviewer";
            repository.Add(user4).Wait();
        }
    }
}