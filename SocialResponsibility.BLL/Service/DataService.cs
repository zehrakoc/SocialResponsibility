using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SocialResponsibility.DAL.Context;
using SocialResponsibility.DAL.Repositories;
using SocialResponsibility.Model.Abstraction;
using SocialResponsibility.Model.Entities;
using System;

namespace SocialResponsibility.BLL.Service
{
    public class DataService : IdentityDbContext, IService, IDisposable
    {
        private AppDbContext context;
        private IUnitOfWork unitOfWork;
        public RoleStore<AppRole> roleStore;
        public RoleManager<AppRole> roleManager;
        public UserStore<AppUser> userStore;
        public UserManager<AppUser> userManager;

        public DataService()
        {
            context = new AppDbContext();
            roleStore = new RoleStore<AppRole>(context);
            roleManager = new RoleManager<AppRole>(roleStore);
            userStore = new UserStore<AppUser>(context);
            userManager = new UserManager<AppUser>(userStore);
        }

        public IUnitOfWork UnitOfWork
        {
            get
            {
                if (unitOfWork == null)
                    unitOfWork = new UnitOfWork();
                return unitOfWork;
            }
        }

        

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
