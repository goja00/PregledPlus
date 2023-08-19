using Microsoft.AspNetCore.Mvc;
using PregledPlus.Models;
using System.Diagnostics;

namespace PregledPlus.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}
        
        public IActionResult Index()
		{
			return View();
		}
		[Route("zakazivanje-termina")]
		public IActionResult zakazivanje_termina()
		{
			return View("Zakazivanje");
		}
        [Route("kontakt")]
        public IActionResult Kontakt()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}