using MacAddresses.Data.Entities;
using System.Collections.Generic;

namespace MacAddresses.Data.Services.ValidationServices
{
    public interface IMacAddressValidationService
    {
        bool Validate(MacAddress entity);
        bool ValidateMany(IList<MacAddress> macs);
    }
}