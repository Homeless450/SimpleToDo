using DataLayer.Data;
using DataLayer.Interfaces;
using Models;

namespace DataLayer.Services
{
    internal class GoalService : Service<Goal>, IGoalService
    {
        private ApplicationDbContext _db;
        public GoalService(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Goal goal)
        {
            _db.Update(goal);
        }
    }
}
