using System.Collections.Generic;
using System.Threading.Tasks;
using Orleans;

namespace HrGrainInterfaces
{
    public interface IManager : IGrain
    {
        Task<IEmployee> AsEmployee();
        Task<List<IEmployee>> GetDirectReports();
        Task AddDirectReport(IEmployee employee);
    }
}