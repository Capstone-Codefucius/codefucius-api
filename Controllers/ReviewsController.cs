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
            System.Console.WriteLine(repository.GetAll().Result);

            if(repository.GetAll().Result.Count == 0)
            {
                CreateDummyReviews(repository);
            }
        }

        private void CreateDummyReviews(EfCoreReviewRepository repository)
        {
            Review review1 = new Review();
            review1.AuthorID = new System.Guid("c5608374-dde3-4f3a-94c1-a99c54ece4cb");
            review1.Created = System.DateTime.Now;
            review1.Deadline = System.DateTime.Now;
            review1.Title = "Test 1";
            review1.Description = "This is a test";
            review1.Status = "In-progress";
            repository.Add(review1).Wait();

            Review review2 = new Review();
            review2.AuthorID = new System.Guid("36ed6c92-4e80-44a2-97c2-9238235d22a7");
            review2.Created = System.DateTime.Now;
            review2.Deadline = System.DateTime.Now;
            review2.Title = "Test 2";
            review2.Description = "Another test!";
            review2.Status = "Awaiting";
            repository.Add(review2).Wait();

            Review review3 = new Review();
            review3.AuthorID = new System.Guid("650cfb89-e700-410a-896b-868d52d5ff94");
            review3.Created = System.DateTime.Now;
            review3.Deadline = System.DateTime.Now;
            review3.Title = "Test 3";
            review3.Description = "More test! I'm sad";
            review3.Status = "In-progress";
            repository.Add(review3).Wait();

            Review review4 = new Review();
            review4.AuthorID = new System.Guid("69cfbbe2-7bf5-4892-9493-61b73f52b731");
            review4.Created = System.DateTime.Now;
            review4.Deadline = System.DateTime.Now;
            review4.Title = "Test 4";
            review4.Description = "Please stop!";
            review4.Status = "Awaiting";
            repository.Add(review4).Wait();
        }
    }
}
