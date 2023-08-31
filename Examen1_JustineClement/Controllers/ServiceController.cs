using Microsoft.AspNetCore.Mvc;
using Examen1_JustineClement.Models;

namespace Examen1_JustineClement.Controllers
{
    public class ServiceController : Controller
    {
		private List<ServiceModel> serviceList = ServiceModel.GetService();
		public ActionResult Services()
		{
			return View(serviceList);
		}

		public ActionResult Details(int id)
		{
			ServiceModel product = GetServiceByIdFromDataSource(id);

			if (product == null)
			{
				return NotFound();
			}
			return View(product);
		}

		private ServiceModel GetServiceByIdFromDataSource(int id)
		{
			ServiceModel product = serviceList.FirstOrDefault(f => f.Id == id);
			return product;
		}
	}
}
