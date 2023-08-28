using Models;

namespace DataLayer.Interfaces
{
    internal interface IUserService : IService<User>
    {
        void Update(User obj);

    }
}
