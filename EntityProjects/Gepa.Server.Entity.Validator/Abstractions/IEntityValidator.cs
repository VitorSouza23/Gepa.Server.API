using System.Collections.Generic;

namespace Gepa.Server.Entity.Validator.Abstractions
{
    public delegate bool ValidationRule<Tin>(Tin entity);
    public interface IEntityValidator<Tin>
    {
        bool CheckEntity(Tin entity, IEnumerable<ValidationRule<Tin>> validationRules);
    }
}
