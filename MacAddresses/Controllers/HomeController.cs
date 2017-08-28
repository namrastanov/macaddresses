using MacAddresses.Models.InputParamModels;
using MacAddresses.Models.ResponseModels;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MacAddresses.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public AddMacsResponse AddMacs(AddMacsParams macs)
        {
            var response = new AddMacsResponse { IsSuccess = true };
            try
            {
                response.AddedCount = macs.Macs.Count;
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
