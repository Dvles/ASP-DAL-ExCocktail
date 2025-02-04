using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC.Controllers
{
	public class DemoController : Controller
	{
		public IActionResult Index()
		{
			HttpContext.Session.SetInt32("CountVisitedPage", 0);
			return View();
		}

		public IActionResult PlusOne()
		{
			int count = HttpContext.Session.GetInt32("CountVisitedPage")?? 0;
			count++;
			HttpContext.Session.SetInt32("CountVisitedPage", count);
			return View("Index");
		}
	}
}
