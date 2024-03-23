using System;
using System.Runtime.Serialization;

namespace Zad3.Exceptions
{
    public class HazardException: System.Exception
    {
        public HazardException()
        {
        }

        public HazardException(string message) : base(message)
        {
        }

        public HazardException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected HazardException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}