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
            if(repository.GetAll().Result.Count == 0)
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
            review1.Title = "Test 1";
            review1.Description = "This is a test";
            review1.Status = "Completed";
            repository.Add(review1).Wait();

            Review review2 = new Review();
            review2.AuthorName = "Darwin Fish";
            review2.Created = System.DateTime.Now;
            review2.Deadline = System.DateTime.Now;
            review2.Title = "Test 2";
            review2.Description = "Another test!";
            review2.Status = "Awaiting";
            repository.Add(review2).Wait();

            Review review3 = new Review();
            review3.AuthorName = "Bilbo Baggins";
            review3.Created = System.DateTime.Now;
            review3.Deadline = System.DateTime.Now;
            review3.Title = "Test 3";
            review3.Description = "More test! I'm sad";
            review3.Status = "In-progress";
            repository.Add(review3).Wait();

            Review review4 = new Review();
            review4.AuthorName = "Man dude";
            review4.Created = System.DateTime.Now;
            review4.Deadline = System.DateTime.Now;
            review4.Title = "Test 4";
            review4.Description = "Please stop!";
            review4.Status = "Awaiting";
            repository.Add(review4).Wait();
        }
    }
}
