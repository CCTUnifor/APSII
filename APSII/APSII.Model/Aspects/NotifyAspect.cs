using PostSharp.Aspects;
using PostSharp.Serialization;

namespace APSII.Model.Aspects
{
    [PSerializable]
    public class NotifyAspect : OnMethodBoundaryAspect
    {
        public override void OnExit(MethodExecutionArgs args)
        {
            Subject.Notify(args, args.Instance);
            base.OnExit(args);
        }
    }
}