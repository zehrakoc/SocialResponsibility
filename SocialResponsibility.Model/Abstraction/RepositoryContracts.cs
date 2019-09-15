using SocialResponsibility.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SocialResponsibility.Model.Abstraction
{

    public interface IAppUserRepository : IRepository<AppUser>
    {
    }
    public interface IAppRoleRepository : IRepository<AppRole>
    {
    }
    public interface IProjectParticipantRepository : IRepository<ProjectParticipant>
    {
    }
    public interface IProjectRepository : IRepository<Project>
    {
         List<Project> FilterByAll(params Expression<Func<Project, bool>>[] expressions);

    }
    public interface ICommentRepository : IRepository<Comment>
    {
    }
    public interface ICategoryRepository : IRepository<Category> { }
}
