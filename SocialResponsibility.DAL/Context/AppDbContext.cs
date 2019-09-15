using Microsoft.AspNet.Identity.EntityFramework;
using SocialResponsibility.Model.Entities;
using System.Data.Entity;

namespace SocialResponsibility.DAL.Context
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext() : base("name=AppConnStr")
        {
        }

    }
}