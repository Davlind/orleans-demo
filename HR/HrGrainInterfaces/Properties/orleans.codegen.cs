//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace HrGrainInterfaces
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;
    using System.Collections.Generic;
    using Orleans;
    using Orleans.Runtime;
    using System.Collections;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class EmployeeFactory
    {
        

                        public static HrGrainInterfaces.IEmployee GetGrain(long primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(HrGrainInterfaces.IEmployee), 364124001, primaryKey));
                        }

                        public static HrGrainInterfaces.IEmployee GetGrain(long primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(HrGrainInterfaces.IEmployee), 364124001, primaryKey, grainClassNamePrefix));
                        }

                        public static HrGrainInterfaces.IEmployee GetGrain(System.Guid primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(HrGrainInterfaces.IEmployee), 364124001, primaryKey));
                        }

                        public static HrGrainInterfaces.IEmployee GetGrain(System.Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(HrGrainInterfaces.IEmployee), 364124001, primaryKey, grainClassNamePrefix));
                        }

            public static HrGrainInterfaces.IEmployee Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return EmployeeReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("HrGrainInterfaces.HrGrainInterfaces.IEmployee")]
        internal class EmployeeReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, HrGrainInterfaces.IEmployee
        {
            

            public static HrGrainInterfaces.IEmployee Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (HrGrainInterfaces.IEmployee) global::Orleans.Runtime.GrainReference.CastInternal(typeof(HrGrainInterfaces.IEmployee), (global::Orleans.Runtime.GrainReference gr) => { return new EmployeeReference(gr);}, grainRef, 364124001);
            }
            
            protected internal EmployeeReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal EmployeeReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return 364124001;
                }
            }
            
            protected override string InterfaceName
            {
                get
                {
                    return "HrGrainInterfaces.HrGrainInterfaces.IEmployee";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                EmployeeReference input = ((EmployeeReference)(original));
                return ((EmployeeReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                EmployeeReference input = ((EmployeeReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return EmployeeReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return (interfaceId == this.InterfaceId);
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return EmployeeMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task<int> HrGrainInterfaces.IEmployee.GetLevel()
            {

                return base.InvokeMethodAsync<System.Int32>(312402437, new object[] {} );
            }
            
            System.Threading.Tasks.Task HrGrainInterfaces.IEmployee.Promote(int @newLevel)
            {

                return base.InvokeMethodAsync<object>(-1461035780, new object[] {@newLevel} );
            }
            
            System.Threading.Tasks.Task<HrGrainInterfaces.IManager> HrGrainInterfaces.IEmployee.GetManager()
            {

                return base.InvokeMethodAsync<HrGrainInterfaces.IManager>(940043127, new object[] {} );
            }
            
            System.Threading.Tasks.Task HrGrainInterfaces.IEmployee.SetManager(HrGrainInterfaces.IManager @manager)
            {

                return base.InvokeMethodAsync<object>(-159913581, new object[] {@manager is global::Orleans.Grain ? HrGrainInterfaces.ManagerFactory.Cast(@manager.AsReference()) : @manager} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("HrGrainInterfaces.HrGrainInterfaces.IEmployee", 364124001)]
    internal class EmployeeMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return 364124001;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 364124001:  // IEmployee
                        switch (methodId)
                        {
                            case 312402437: 
                                return ((IEmployee)grain).GetLevel().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case -1461035780: 
                                return ((IEmployee)grain).Promote((Int32)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            case 940043127: 
                                return ((IEmployee)grain).GetManager().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case -159913581: 
                                return ((IEmployee)grain).SetManager((IManager)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }
            catch(Exception ex)
            {
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case 364124001:  // IEmployee
                    switch (methodId)
                    {
                        case 312402437:
                            return "GetLevel";
                    case -1461035780:
                            return "Promote";
                    case 940043127:
                            return "GetManager";
                    case -159913581:
                            return "SetManager";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class ManagerFactory
    {
        

                        public static HrGrainInterfaces.IManager GetGrain(long primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(HrGrainInterfaces.IManager), -943489796, primaryKey));
                        }

                        public static HrGrainInterfaces.IManager GetGrain(long primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(HrGrainInterfaces.IManager), -943489796, primaryKey, grainClassNamePrefix));
                        }

                        public static HrGrainInterfaces.IManager GetGrain(System.Guid primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(HrGrainInterfaces.IManager), -943489796, primaryKey));
                        }

                        public static HrGrainInterfaces.IManager GetGrain(System.Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(HrGrainInterfaces.IManager), -943489796, primaryKey, grainClassNamePrefix));
                        }

            public static HrGrainInterfaces.IManager Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return ManagerReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("HrGrainInterfaces.HrGrainInterfaces.IManager")]
        internal class ManagerReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, HrGrainInterfaces.IManager
        {
            

            public static HrGrainInterfaces.IManager Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (HrGrainInterfaces.IManager) global::Orleans.Runtime.GrainReference.CastInternal(typeof(HrGrainInterfaces.IManager), (global::Orleans.Runtime.GrainReference gr) => { return new ManagerReference(gr);}, grainRef, -943489796);
            }
            
            protected internal ManagerReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal ManagerReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return -943489796;
                }
            }
            
            protected override string InterfaceName
            {
                get
                {
                    return "HrGrainInterfaces.HrGrainInterfaces.IManager";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                ManagerReference input = ((ManagerReference)(original));
                return ((ManagerReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                ManagerReference input = ((ManagerReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return ManagerReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return (interfaceId == this.InterfaceId);
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return ManagerMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task<HrGrainInterfaces.IEmployee> HrGrainInterfaces.IManager.AsEmployee()
            {

                return base.InvokeMethodAsync<HrGrainInterfaces.IEmployee>(-1701259070, new object[] {} );
            }
            
            System.Threading.Tasks.Task<System.Collections.Generic.List<HrGrainInterfaces.IEmployee>> HrGrainInterfaces.IManager.GetDirectReports()
            {

                return base.InvokeMethodAsync<System.Collections.Generic.List<HrGrainInterfaces.IEmployee>>(-675836216, new object[] {} );
            }
            
            System.Threading.Tasks.Task HrGrainInterfaces.IManager.AddDirectReport(HrGrainInterfaces.IEmployee @employee)
            {

                return base.InvokeMethodAsync<object>(-1731443267, new object[] {@employee is global::Orleans.Grain ? HrGrainInterfaces.EmployeeFactory.Cast(@employee.AsReference()) : @employee} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("HrGrainInterfaces.HrGrainInterfaces.IManager", -943489796)]
    internal class ManagerMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return -943489796;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -943489796:  // IManager
                        switch (methodId)
                        {
                            case -1701259070: 
                                return ((IManager)grain).AsEmployee().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case -675836216: 
                                return ((IManager)grain).GetDirectReports().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case -1731443267: 
                                return ((IManager)grain).AddDirectReport((IEmployee)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }
            catch(Exception ex)
            {
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case -943489796:  // IManager
                    switch (methodId)
                    {
                        case -1701259070:
                            return "AsEmployee";
                    case -675836216:
                            return "GetDirectReports";
                    case -1731443267:
                            return "AddDirectReport";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
