using SocialResponsibility.DAL.Context;
using SocialResponsibility.Model.Abstraction;
using SocialResponsibility.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SocialResponsibility.DAL.Repositories
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(AppDbContext context) : base(context)
        {
        }
        public List<Project> FilterByAll(params Expression<Func<Project, bool>>[] expressions)
        {
            IQueryable<Project> filtered = dbSet;

            foreach (var expression in expressions)
                filtered = filtered.Where(expression);

            return filtered.ToList();
        }
    }
}
