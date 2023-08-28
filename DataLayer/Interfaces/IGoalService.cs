using Models;

namespace DataLayer.Interfaces
{
    internal interface IGoalService : IService<Goal>
    {
        void Update(Goal obj);
    }
}
