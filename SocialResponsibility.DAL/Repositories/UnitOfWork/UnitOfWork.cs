using SocialResponsibility.DAL.Context;
using SocialResponsibility.Model.Abstraction;
using System;

namespace SocialResponsibility.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext context = new AppDbContext();
        private IAppUserRepository _users;
        private IAppRoleRepository _roles;
        private IProjectRepository _projects;
        private IProjectParticipantRepository _projectParticipants;
        private ICategoryRepository _categories;
        private ICommentRepository _comments;

        public IAppUserRepository Users
        {
            get
            {
                if (_users == null)
                    _users = new AppUserRepository(context);

                return _users;
            }
        }
        public IAppRoleRepository Roles
        {
            get
            {
                if (_roles == null)
                    _roles = new AppRoleRepository(context);

                return _roles;
            }
        }
        public IProjectRepository Projects
        {
            get
            {
                if (_projects == null)
                    _projects = new ProjectRepository(context);

                return _projects;
            }

        }
        public IProjectParticipantRepository ProjectParticipants
        {
            get
            {
                if (_projectParticipants == null)
                    _projectParticipants = new ProjectParticipantRepository (context);

                return _projectParticipants;
            }
        }
        public ICategoryRepository Categories
        {
            get
            {
                if (_categories == null)
                    _categories = new CategoryRepository (context);

                return _categories;
            }
        }
        public ICommentRepository Comments
        {
            get
            {
                if (_comments == null)
                    _comments = new CommentRepository(context);

                return _comments;
            }
        }

      

        public int Save()
        {
            return context.SaveChanges();
        }

        private bool disposed = false;
        private void Dispose(bool disposing)
        {
            if (!disposed)
                if (disposing)
                    context.Dispose();
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
