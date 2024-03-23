using System.Runtime.Serialization;

namespace Zad3.Exceptions
{
    public class OverfillException : System.Exception
    {
        public OverfillException()
        {
        }

        protected OverfillException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public OverfillException(string? message) : base(message)
        {
        }

        public OverfillException(string? message, System.Exception? innerException) : base(message, innerException)
        {
        }
    }
}