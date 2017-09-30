using Microsoft.AspNetCore.Mvc;
using XG.Controllers;
using XG.Business.Services.Interfaces;

namespace XG.Areas.Configuration.Controllers
{
    public class MatchesController: BaseConfigurationController
	{
		private IMatchService _matchService;
		public MatchesController(IMatchService matchService)
		{
			this._matchService = matchService;
		}

        public IActionResult Index()
        {
          return View();
        }
  }
}
