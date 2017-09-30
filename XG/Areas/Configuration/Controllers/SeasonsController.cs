using Microsoft.AspNetCore.Mvc;
using XG.Controllers;
using XG.Business.Services.Interfaces;

namespace XG.Areas.Configuration.Controllers
{
    public class SeasonsController: BaseConfigurationController
    {
        private ISeasonService _seasonService;
        public SeasonsController(ISeasonService seasonService)
        {
            this._seasonService = seasonService;
        }

        public IActionResult Index()
        {
          return View();
        }
    }
}
