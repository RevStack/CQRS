using System;


namespace RevStack.CQRS.Message
{
    public class Message : IMessage
    {
        public Guid Id { get; }
        public string Name { get; protected set; }
    }
}
