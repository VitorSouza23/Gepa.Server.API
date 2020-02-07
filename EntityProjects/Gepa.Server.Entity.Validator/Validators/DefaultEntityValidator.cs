using Gepa.Server.Entity.Validator.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace Gepa.Server.Entity.Validator.Validators
{
    public class DefaultEntityValidator<Tin> : IEntityValidator<Tin>
    {
        public bool CheckEntity(Tin entity, IEnumerable<ValidationRule<Tin>> validationRules)
        {
            return !validationRules.Any(validationRule => validationRule(entity) == false);
        }
    }
}
