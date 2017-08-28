using MacAddresses.Helpers;
using MacAddresses.Data.Entities;
using System.Text.RegularExpressions;

namespace MacAddresses.Data.Services.ValidationServices
{
    public class MacAddressValidationService : Disposable, IValidationService
    {
        private const string _pattern = @"^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$";
        public bool Validate(IEntity entity)
        {
            var macAddress = (MacAddress)entity;
            Regex r = new Regex(_pattern, RegexOptions.IgnoreCase);
            Match m = r.Match(macAddress.Value);
            return m.Success;
        }
    }
}