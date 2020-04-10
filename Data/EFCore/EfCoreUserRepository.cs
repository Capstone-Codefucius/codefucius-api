using codefucius_api.Models;

namespace codefucius_api.Data.EFCore
{
    public class EfCoreUserRepository : EfCoreRepository<User, DataContext>
    {
        public EfCoreUserRepository(DataContext context) : base(context)
        {

        }
    }
}