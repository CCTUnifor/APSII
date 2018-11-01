using System;
using PostSharp.Aspects;
using PostSharp.Serialization;

namespace APSII.Model.Aspects
{
    [PSerializable]
    public class LogAspect : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine($"Antes de chamar {args.Method.DeclaringType.FullName}.{args.Method.Name}({string.Join(", ", args.Arguments)})!");
            base.OnEntry(args);
        }


        public override void OnExit(MethodExecutionArgs args)
        {
            Console.WriteLine($"Depois de chamar {args.Method.DeclaringType.FullName}.{args.Method.Name}({string.Join(", ", args.Arguments)})!");
            base.OnExit(args);
        }
    }
}