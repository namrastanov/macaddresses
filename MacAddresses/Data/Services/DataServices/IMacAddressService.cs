using MacAddresses.Data.Entities;
using System.Collections.Generic;

namespace MacAddresses.Data.Services.DataServices
{
    public interface IMacAddressService
    {
        int Add(IList<MacAddress> items);
        bool SaveToFile(MacAddress mac);
    }
}