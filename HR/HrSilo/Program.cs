/*
Project Orleans Cloud Service SDK ver. 1.0
 
Copyright (c) Microsoft Corporation
 
All rights reserved.
 
MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and 
associated documentation files (the ""Software""), to deal in the Software without restriction,
including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO
THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS
OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using HrGrainInterfaces;

namespace HrSilo
{
    /// <summary>
    /// Orleans test silo host
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            // The Orleans silo environment is initialized in its own app domain in order to more
            // closely emulate the distributed situation, when the client and the server cannot
            // pass data via shared memory.
            AppDomain hostDomain = AppDomain.CreateDomain("OrleansHost", null, new AppDomainSetup
            {
                AppDomainInitializer = InitSilo,
                AppDomainInitializerArguments = args,
            });

            Orleans.GrainClient.Initialize("DevTestClientConfiguration.xml");

            var ids = new[] { 
        "42783519-d64e-44c9-9c29-399e3afaa625", 
        "d694a4e0-1bc3-4c3f-a1ad-ba95103622bc", 
        "9a72b0c6-33df-49db-ac05-14316edd332d", 
        "6526a751-b9ac-4881-9bfb-836ecce2ca9f", 
        "ae4b106f-3c96-464a-b48d-3583ed584b17", 
        "b715c40f-d8d2-424d-9618-76afbc0a2a0a", 
        "5ad92744-a0b1-487b-a9e7-e6b91e9a9826", 
        "e23a55af-217c-4d76-8221-c2b447bf04c8", 
        "2eef0ac5-540f-4421-b9a9-79d89400f7ab" 
    };

            var e0 = EmployeeFactory.GetGrain(Guid.Parse(ids[0]));
            var e1 = EmployeeFactory.GetGrain(Guid.Parse(ids[1]));
            var e2 = EmployeeFactory.GetGrain(Guid.Parse(ids[2]));
            var e3 = EmployeeFactory.GetGrain(Guid.Parse(ids[3]));
            var e4 = EmployeeFactory.GetGrain(Guid.Parse(ids[4]));

            var m0 = ManagerFactory.GetGrain(Guid.Parse(ids[5]));
            var m1 = ManagerFactory.GetGrain(Guid.Parse(ids[6]));
            var m0e = m0.AsEmployee().Result;
            var m1e = m1.AsEmployee().Result;

            m0e.Promote(10);
            m1e.Promote(11);

            m0.AddDirectReport(e0).Wait();
            m0.AddDirectReport(e1).Wait();
            m0.AddDirectReport(e2).Wait();

            m1.AddDirectReport(m0e).Wait();
            m1.AddDirectReport(e3).Wait();

            m1.AddDirectReport(e4).Wait();

            Console.WriteLine("Orleans Silo is running.\nPress Enter to terminate...");
            Console.ReadLine();

            hostDomain.DoCallBack(ShutdownSilo);
        }

        static void InitSilo(string[] args)
        {
            hostWrapper = new OrleansHostWrapper(args);

            if (!hostWrapper.Run())
            {
                Console.Error.WriteLine("Failed to initialize Orleans silo");
            }
        }

        static void ShutdownSilo()
        {
            if (hostWrapper != null)
            {
                hostWrapper.Dispose();
                GC.SuppressFinalize(hostWrapper);
            }
        }

        private static OrleansHostWrapper hostWrapper;
    }
}
