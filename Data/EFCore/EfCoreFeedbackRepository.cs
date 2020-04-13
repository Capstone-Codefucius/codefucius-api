using codefucius_api.Models;

namespace codefucius_api.Data.EFCore
{
    public class EfCoreFeedbackRepository : EfCoreRepository<Feedback, DataContext>
    {
        public EfCoreFeedbackRepository(DataContext context) : base(context)
        {
            
        }
    }
}
