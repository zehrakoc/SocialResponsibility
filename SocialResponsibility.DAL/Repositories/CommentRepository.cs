using SocialResponsibility.DAL.Context;
using SocialResponsibility.Model.Abstraction;
using SocialResponsibility.Model.Entities;

namespace SocialResponsibility.DAL.Repositories
{
    public class CommentRepository : Repository <Comment> , ICommentRepository
    {
        public CommentRepository( AppDbContext context) : base (context)
        {
        }
    }
}
