using MacAddresses.Helpers;

namespace MacAddresses.Data.Entities
{
    public class MacAddress: Disposable, IEntity
    {
        public string Value { get; set; }
    }
}