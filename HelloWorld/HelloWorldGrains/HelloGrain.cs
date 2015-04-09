using System.Threading.Tasks;
using HelloWorldGrainInterfaces;
using Orleans;

namespace HelloWorldGrains
{
    /// <summary>
    /// Grain implementation class HelloGrain.
    /// </summary>
    public class HelloGrain : Grain, IHelloGrain
    {
        
    }
}
