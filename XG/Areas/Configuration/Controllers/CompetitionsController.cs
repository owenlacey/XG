using Microsoft.AspNetCore.Mvc;
using XG.Controllers;
using XG.Business.Services.Interfaces;
namespace XG.Areas.Configuration.Controllers
{
  public class CompetitionsController: BaseConfigurationController
  {
        private ICompetitionService _competititionService;
        public CompetitionsController(ICompetitionService competitionService)
        {
            this._competititionService = competitionService;
        }

        public IActionResult Index()
        {
          return View();
        }
  }
}
