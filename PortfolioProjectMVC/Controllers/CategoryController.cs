using Microsoft.AspNetCore.Mvc;

namespace PortfolioProjectMVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
