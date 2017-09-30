using Microsoft.AspNetCore.Mvc;
using XG.Controllers;

namespace XG.Areas.Configuration.Controllers
{
  public class MatchesController: BaseConfigurationController
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
