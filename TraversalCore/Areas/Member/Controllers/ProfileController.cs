using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Member.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
