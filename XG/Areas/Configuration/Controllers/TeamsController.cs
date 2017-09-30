using XG.Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace XG.Areas.Configuration.Controllers
{
    public class TeamsController: BaseConfigurationController
    {
        private ITeamService _teamService;
        public TeamsController(ITeamService teamService)
        {
            this._teamService = teamService;
		}

		public IActionResult Index()
		{
			return View();
		}
    }
}
