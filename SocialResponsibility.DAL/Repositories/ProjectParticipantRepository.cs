using SocialResponsibility.DAL.Context;
using SocialResponsibility.Model.Abstraction;
using SocialResponsibility.Model.Entities;

namespace SocialResponsibility.DAL.Repositories
{
    public class ProjectParticipantRepository : Repository<ProjectParticipant>, IProjectParticipantRepository
    {
        public ProjectParticipantRepository(AppDbContext context) : base(context)
        {
        }
        
    }
}
