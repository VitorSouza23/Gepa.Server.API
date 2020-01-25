namespace Gepa.Server.Entity.Validator.Abstractions
{
    public interface IEntityValidatorRuller<Tin>
    {
        bool CheckIfEntityIsValid(Tin entity);
    }
}
