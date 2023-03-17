using Microsoft.AspNetCore.Mvc;

namespace GroceryListBuilder.Controllers
{
    public class MealController : Controller
    {
        public IActionResult Index()
        {
            var api = APICall.APICall.GetMeal();
            return View(api);
        }
    }
}
