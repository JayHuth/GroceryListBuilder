using Microsoft.AspNetCore.Mvc;

namespace GroceryListBuilder.Controllers
{
    public class Meal : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
