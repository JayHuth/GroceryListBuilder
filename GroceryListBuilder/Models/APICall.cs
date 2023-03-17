using GroceryListBuilder.Models;
using Newtonsoft.Json.Linq;

namespace APICall
{
    class APICall
    {
        public static Meal GetMeal()
        {
            var client = new HttpClient();

            var foodURL = $"https://www.themealdb.com/api/json/v1/1/search.php?s=Arrabiata";
            var response = client.GetStringAsync(foodURL).Result;

            JObject formattedResponse = JObject.Parse(response);
            var instance = new Meal();
            instance.StrMeal = formattedResponse["meals"][0]["strMeal"].ToString();
            instance.StrInstructions = formattedResponse["meals"][0]["strInstructions"].ToString();
            return instance;
        }
    }
}