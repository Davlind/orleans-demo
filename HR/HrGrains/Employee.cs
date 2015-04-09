using System.Threading.Tasks;
using HrGrainInterfaces;
using Orleans;

namespace HrGrains
{
    public class Employee : Grain, IEmployee
    {
        public Task<int> GetLevel()
        {
            return Task.FromResult(_level);
        }

        public Task Promote(int newLevel)
        {
            _level = newLevel;
            return TaskDone.Done;
        }

        public Task<IManager> GetManager()
        {
            return Task.FromResult(_manager);
        }

        public Task SetManager(IManager manager)
        {
            _manager = manager;
            return TaskDone.Done;
        }

        private int _level;
        private IManager _manager;
    }
}
