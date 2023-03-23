using GroceryListBuilder.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroceryListBuilder.Controllers
{
    public class MealController : Controller
    {
        public IActionResult RecipeIndex(Meal mealName)
        {
            var api = APICall.APICall.GetMeal(mealName.StrMeal);
            return View(api);
        }
    }
}
