using System.Linq;
using System.Web.Mvc;
using IoCContainer.Core;
using IoCContainer.Models;

namespace IoCContainer.Controllers
{
	public class HomeController : Controller
	{
		
		public ActionResult Index()
		{
			
			var repo = ServiceLocator.Resolve<ICustomerRepository>();
			ViewData["customers"] = repo.GetCustomers();
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "So what's this all about?";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "How to contact me";

			return View();
		}

	}
}