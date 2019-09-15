using System;

namespace SocialResponsibility.Model.Abstraction
{
   public interface IUnitOfWork : IDisposable
    {
        IAppUserRepository Users { get; }
        IAppRoleRepository Roles { get; }
        IProjectParticipantRepository ProjectParticipants { get; }
        IProjectRepository Projects { get; }
        ICommentRepository Comments { get; }
        ICategoryRepository Categories { get; }
    
        int Save();
    }
}
