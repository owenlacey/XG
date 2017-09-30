using Microsoft.AspNetCore.Mvc;

namespace XG.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
		    {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
