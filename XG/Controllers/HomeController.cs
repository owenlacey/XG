using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XG.Business;
using XG.Business.Services.Interfaces;

namespace XG.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBaseService _baseService;

        public HomeController(IBaseService baseService)
        {
            this._baseService = baseService;
        }

        public IActionResult Index()
		{
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
