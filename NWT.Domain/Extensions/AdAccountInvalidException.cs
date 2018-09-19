using System;
using System.Runtime.Serialization;

namespace NWT.Domain.Exceptions
{
    [Serializable]
    public class AdAccountInvalidException : Exception
    {
        public AdAccountInvalidException()
        {
        }

        public AdAccountInvalidException(string adAccount) : base($"AD Account '{adAccount}' is invalid")
        {
        }

        public AdAccountInvalidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AdAccountInvalidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}