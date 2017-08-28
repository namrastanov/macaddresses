using MacAddresses.Data.Entities;
using System.Collections.Generic;

namespace MacAddresses.Models.InputParamModels
{
    public class AddMacsParams
    {
        public IList<MacAddress> Macs { get; set; }
    }
}