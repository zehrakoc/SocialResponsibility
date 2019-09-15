using SocialResponsibility.Model.Abstraction;

namespace SocialResponsibility.BLL
{
    public interface IService
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
