using MacAddresses.Data.Services.DataServices;
using MacAddresses.Data.Services.ValidationServices;
using MacAddresses.Models.InputParamModels;
using MacAddresses.Models.ResponseModels;
using System.Web.Http;

namespace MacAddresses.Controllers
{
    public class MacApiController : ApiController
    {
        private IMacAddressService MacAddressService { get; set; }
        private IMacAddressValidationService MacAddressValidationService { get; set; }

        public MacApiController(IMacAddressService macAddressService, IMacAddressValidationService macAddressValidationService)
        {
            MacAddressService = macAddressService;
            MacAddressValidationService = macAddressValidationService;
        }

        [HttpPost]
        public AddMacsResponse AddMacs(AddMacsParams macs)
        {
            var response = new AddMacsResponse { IsSuccess = true };
            try
            {
                if (!MacAddressValidationService.ValidateMany(macs.Macs))
                {
                    response.Messages = new string[] { "Validation error" };
                    response.IsSuccess = false;
                } else
                {
                    response.AddedCount = MacAddressService.Add(macs.Macs);
                }
            }
            catch (System.Exception ex)
            {
                response.Messages = new string[] { "Error on AddMacs", ex.Message };
                response.IsSuccess = false;
            }
            return response;
        }
    }
}