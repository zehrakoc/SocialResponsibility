using SocialResponsibility.DAL.Context;
using SocialResponsibility.Model.Abstraction;
using SocialResponsibility.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialResponsibility.DAL.Repositories
{
   public class CategoryRepository : Repository <Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        { }

    }
 }

