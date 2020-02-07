using System;
using System.Runtime.Serialization;

namespace Gepa.Server.Common.DependencyInjection.Exceptions
{
    public class DependencyNotConfiguredException : Exception
    {
        private const string DEFAULT_EXCEPTION_MESSAGE = "Erro ao injetar depência do tipo [{0}]. A depência não foi configurada.";
        public DependencyNotConfiguredException(string message) : base(message)
        {
        }

        public DependencyNotConfiguredException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public DependencyNotConfiguredException()
        {
        }

        public DependencyNotConfiguredException(Type dependencyType) : base(string.Format(DEFAULT_EXCEPTION_MESSAGE, dependencyType.Name))
        {
        }

        protected DependencyNotConfiguredException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
