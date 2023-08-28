using Models;

namespace DataLayer.Interfaces
{
    public interface IUserService : IService<User>
    {
        void Update(User obj);

    }
}
