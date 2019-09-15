using SocialResponsibility.DAL.Context;
using SocialResponsibility.Model.Abstraction;
using SocialResponsibility.Model.Entities;

namespace SocialResponsibility.DAL.Repositories
{
    public class AppRoleRepository : Repository<AppRole>, IAppRoleRepository
    {
        public AppRoleRepository(AppDbContext context) : base (context)
        {   
        }
    }
}
