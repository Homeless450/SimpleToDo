using DataLayer.Data;
using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Goal = new GoalService(_db);
            User = new UserService(_db);
        }

        public IGoalService Goal { get; private set; }
        public IUserService User { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
