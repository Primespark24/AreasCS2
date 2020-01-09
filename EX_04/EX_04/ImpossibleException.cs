using System;
// Property Owners, Mason Caird Brycen Martin
// Class 371-1

namespace EX_04
{
    class ImpossibleException : ApplicationException
    {
        // Excpetion Class
        public ImpossibleException() { }
        public ImpossibleException(string message) : base(message) { }
        public ImpossibleException(string message, System.Exception inner) : base(message, inner) { }
        protected ImpossibleException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
