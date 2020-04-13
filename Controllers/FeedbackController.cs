using Microsoft.AspNetCore.Mvc;
using codefucius_api.Models;
using codefucius_api.Data.EFCore;

namespace codefucius_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : BaseController<Feedback, EfCoreFeedbackRepository> 
    {
        public FeedbackController(EfCoreFeedbackRepository repository) : base(repository)
        {

        }
    }
}
