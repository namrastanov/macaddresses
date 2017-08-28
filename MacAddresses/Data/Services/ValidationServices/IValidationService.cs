using MacAddresses.Data.Entities;

namespace MacAddresses.Data.Services.ValidationServices
{
    public interface IValidationService
    {
        bool Validate(IEntity entity);
    }
}