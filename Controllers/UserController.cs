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
            user1.reviewHours = 3.5;
            repository.Add(user1).Wait();

            User user2 = new User();
            user2.name = "Danny Osborne";
            user2.role = "Manager";
            user2.reviewHours = 2.0;
            repository.Add(user2).Wait();

            User user3 = new User();
            user3.name = "Mary Mercer";
            user3.role = "Reviewee";
            user3.reviewHours = 5.5;
            repository.Add(user3).Wait();

            User user4 = new User();
            user4.name = "Terrence Schubert";
            user4.role = "Reviewer";
            user4.reviewHours = 0;
            repository.Add(user4).Wait();

            User user5 = new User();
            user5.name = "Marie Leon";
            user5.role = "Admin";
            user5.reviewHours = 0;
            repository.Add(user5).Wait();
        }
    }
}