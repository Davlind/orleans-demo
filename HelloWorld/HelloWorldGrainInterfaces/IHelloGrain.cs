using System.Threading.Tasks;
using Orleans;

namespace HelloWorldGrainInterfaces
{
    /// <summary>
    /// Grain interface IHelloGrain
    /// </summary>
    public interface IHelloGrain : IGrainWithIntegerKey
    {
        
    }
}
