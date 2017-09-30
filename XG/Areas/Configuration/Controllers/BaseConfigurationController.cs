using XG.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace XG.Areas.Configuration.Controllers
{
	[Area("Configuration")]
	[Route("Configuration/[controller]")]
    public class BaseConfigurationController: BaseController
    {
        public BaseConfigurationController()
        {
        }
    }
}
