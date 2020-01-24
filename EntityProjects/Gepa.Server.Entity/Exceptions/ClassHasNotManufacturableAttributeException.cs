using Gepa.Server.Entity.Attributes;
using System;
using System.Runtime.Serialization;

namespace Gepa.Server.Entity.Exceptions
{
    public class ClassHasNotManufacturableAttributeException : Exception
    {
        public static readonly string DEFAULT_ERROR_MESSAGE_FORMAT = $@"A classe {{0}} não possui nenhuma propriedade ou método com o atributo {nameof(ManufacturerAttribute)}";

        public ClassHasNotManufacturableAttributeException(string message) : base(message)
        {
        }

        public ClassHasNotManufacturableAttributeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public ClassHasNotManufacturableAttributeException()
        {
        }

        public ClassHasNotManufacturableAttributeException(Type classWithoutManufacturerAttribute) : base(string.Format(DEFAULT_ERROR_MESSAGE_FORMAT, classWithoutManufacturerAttribute.Name))
        {
        }

        protected ClassHasNotManufacturableAttributeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
