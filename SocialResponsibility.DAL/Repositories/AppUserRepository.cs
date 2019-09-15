using SocialResponsibility.DAL.Context;
using SocialResponsibility.Model.Abstraction;
using SocialResponsibility.Model.Entities;

namespace SocialResponsibility.DAL.Repositories
{
    public class AppUserRepository : Repository <AppUser>, IAppUserRepository
    {
        public AppUserRepository(AppDbContext context) : base (context)
        {
        }
    }
}
