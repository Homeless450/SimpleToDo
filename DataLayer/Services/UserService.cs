using DataLayer.Data;
using DataLayer.Interfaces;
using Models;

namespace DataLayer.Services
{
    internal class UserService : Service<User>, IUserService
    {
        private ApplicationDbContext _db;
        public UserService(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(User user)
        {
            _db.Update(user);
        }
    }
}
