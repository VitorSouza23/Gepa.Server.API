using Gepa.Server.Entity.Exceptions;
using System;
using System.Linq;

namespace Gepa.Server.Entity.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class ManufacturableAttribute : Attribute
    {
        public ManufacturableAttribute(Type classForAnalysis)
        {
            CheckIfTheClassHasManufacturerAttribute(classForAnalysis);
        }

        private void CheckIfTheClassHasManufacturerAttribute(Type classForAnalysis)
        {
            object[] attrubutes = classForAnalysis.GetCustomAttributes(inherit: true);
            bool classHasManufacturerAttribute = attrubutes.Any(customAttribute => customAttribute.GetType() == typeof(ManufacturerAttribute));
            if (classHasManufacturerAttribute == false)
            {
                throw new ClassHasNotManufacturableAttributeException(classForAnalysis);
            }
        }
    }
}
