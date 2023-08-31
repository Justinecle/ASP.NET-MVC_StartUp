using Microsoft.AspNetCore.Mvc;
using Examen1_JustineClement.Models;

namespace Examen1_JustineClement.Controllers
{
    public class NousJoindreController : Controller
    {
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(NousJoindreModel applicant)
		{
            if (ModelState.IsValid)
			{
				return RedirectToAction("Confirmation");
			}

			return View(applicant);
		}

        public IActionResult Confirmation()
        {
            return View();
        }
    }
}

