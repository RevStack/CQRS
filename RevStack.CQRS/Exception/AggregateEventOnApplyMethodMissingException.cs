﻿

namespace RevStack.CQRS.Exception
{
    public class AggregateEventOnApplyMethodMissingException : System.Exception
    {
        public AggregateEventOnApplyMethodMissingException(string msg) : base(msg)
        {

        }
    }
}
