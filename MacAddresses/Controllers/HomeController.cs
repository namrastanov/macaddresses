using MacAddresses.Data.Services.DataServices;
using MacAddresses.Data.Services.ValidationServices;
using MacAddresses.Models.InputParamModels;
using MacAddresses.Models.ResponseModels;
using System.Web.Mvc;

namespace MacAddresses.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}