using Microsoft.AspNetCore.Mvc;
using XG.Controllers;

namespace XG.Areas.Configuration.Controllers
{
  public class SeasonsController: BaseConfigurationController
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
