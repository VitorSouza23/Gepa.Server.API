using System;
using System.Runtime.Serialization;

namespace Gepa.Server.Entity.Validator.Exceptions
{
    public class RuleNotValidException : Exception
    {
        private const string _DEFAULT_EXCEPTION_MESSAGE = "Uma regra de validação não foi atendida!";
        public RuleNotValidException(string message) : base(message)
        {
        }

        public RuleNotValidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public RuleNotValidException() : base(_DEFAULT_EXCEPTION_MESSAGE)
        {
        }

        protected RuleNotValidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
