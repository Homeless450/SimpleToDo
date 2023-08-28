using Models;

namespace DataLayer.Interfaces
{
    public interface IGoalService : IService<Goal>
    {
        void Update(Goal obj);
    }
}
