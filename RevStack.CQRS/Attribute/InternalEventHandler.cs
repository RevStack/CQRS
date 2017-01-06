using System;


namespace RevStack.CQRS.Attribute
{
    [AttributeUsage(AttributeTargets.Method, Inherited = true)]
    public class InternalEventHandler : System.Attribute
    {
    }
}
