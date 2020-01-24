using System;

namespace Gepa.Server.Entity.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Field)]
    internal class ManufacturerAttribute : Attribute
    {
    }
}
