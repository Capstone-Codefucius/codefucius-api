using codefucius_api.Models;

namespace codefucius_api.Data.EFCore
{
    public class EfCoreReviewRepository : EfCoreRepository<Review, DataContext>
    {
        public EfCoreReviewRepository(DataContext context) : base(context)
        {
            
        }
    }
}