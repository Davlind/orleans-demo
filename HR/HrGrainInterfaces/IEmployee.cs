using System.Threading.Tasks;
using Orleans;

namespace HrGrainInterfaces
{
    /// <summary>
    /// Grain interface IGrain1
    /// </summary>
    public interface IEmployee : IGrain
    {
        Task<int> GetLevel();
        Task Promote(int newLevel);
        Task<IManager> GetManager();
        Task SetManager(IManager manager);
        Task Greeting(IEmployee from, string message);
    }
}
