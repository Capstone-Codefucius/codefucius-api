using Microsoft.AspNetCore.Mvc;
using codefucius_api.Models;
using codefucius_api.Data.EFCore;

namespace codefucius_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : BaseController<Review, EfCoreReviewRepository> 
    {
        public ReviewsController(EfCoreReviewRepository repository) : base(repository)
        {
            if (repository.GetAll().Result.Count == 0)
            {
                CreateDummyReviews(repository);
            }
        }

        private void CreateDummyReviews(EfCoreReviewRepository repository)
        {
            Review review1 = new Review();
            review1.AuthorName = "Greg Mann";
            review1.Created = System.DateTime.Now;
            review1.Deadline = System.DateTime.Now;
            review1.Title = "Client software system";
            review1.Description = "Fixing bugs in legacy software.";
            review1.Status = "Completed";
            repository.Add(review1).Wait();

            Review review2 = new Review();
            review2.AuthorName = "Danny Osborne";
            review2.Created = System.DateTime.Now;
            review2.Deadline = System.DateTime.Now;
            review2.Title = "Create a database for client.";
            review2.Description = "Initializing MongoDB database.";
            review2.Status = "Awaiting";
            repository.Add(review2).Wait();

            Review review3 = new Review();
            review3.AuthorName = "Mary Mercer";
            review3.Created = System.DateTime.Now;
            review3.Deadline = System.DateTime.Now;
            review3.Title = "Internal apps";
            review3.Description = "Updating internal CRM codebase.";
            review3.Status = "In-progress";
            repository.Add(review3).Wait();

            Review review4 = new Review();
            review4.AuthorName = "Terrence Schubert";
            review4.Created = System.DateTime.Now;
            review4.Deadline = System.DateTime.Now;
            review4.Title = "Client website.";
            review4.Description = "Practice demo of website.";
            review4.Status = "Awaiting";
            repository.Add(review4).Wait();
        }
    }
}
