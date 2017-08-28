using MacAddresses.Helpers;
using MacAddresses.Data.Entities;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace MacAddresses.Data.Services.ValidationServices
{
    public class MacAddressValidationService : Disposable, IMacAddressValidationService
    {
        private const string _pattern = @"^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$";
        public bool Validate(MacAddress mac)
        {
            Regex r = new Regex(_pattern, RegexOptions.IgnoreCase);
            Match m = r.Match(mac.Value);
            return m.Success;
        }

        public bool ValidateMany(IList<MacAddress> macs)
        {
            foreach(var mac in macs)
            {
                if (!Validate(mac)) return false;
            }
            return true;
        }
    }
}