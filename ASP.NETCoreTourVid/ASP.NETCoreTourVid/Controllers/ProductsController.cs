using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreTourVid.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
