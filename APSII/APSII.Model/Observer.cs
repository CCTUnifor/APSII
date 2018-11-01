using System;
using System.Reflection;
using PostSharp.Aspects;

namespace APSII.Model
{
    public class Subject
    {
        public static event Action<MethodExecutionArgs, object> Update;
        public static void Notify(MethodExecutionArgs args, object obj) => Update?.Invoke(args, obj);
    }
}
