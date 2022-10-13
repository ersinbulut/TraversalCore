using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponents.Default
{
    public class _SubAbout:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

        }
    }
}
