using System;
using System.Reflection;
using PostSharp.Aspects;

namespace APSII.Model
{
    public class Subject
    {
        public static event Action<MethodExecutionArgs, object> UpdateEvent;
        public static void Notify(MethodExecutionArgs args, object obj) => UpdateEvent?.Invoke(args, obj);
    }
}
