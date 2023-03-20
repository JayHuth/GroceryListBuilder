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

            instance.StrPhoto = formattedResponse["meals"][0]["strMealThumb"].ToString();

            instance.StrIngredient1 = formattedResponse["meals"][0]["strIngredient1"].ToString();
            instance.StrIngredient2 = formattedResponse["meals"][0]["strIngredient2"].ToString();
            instance.StrIngredient3 = formattedResponse["meals"][0]["strIngredient3"].ToString();
            instance.StrIngredient4 = formattedResponse["meals"][0]["strIngredient4"].ToString();
            instance.StrIngredient5 = formattedResponse["meals"][0]["strIngredient5"].ToString();
            instance.StrIngredient6 = formattedResponse["meals"][0]["strIngredient6"].ToString();
            instance.StrIngredient7 = formattedResponse["meals"][0]["strIngredient7"].ToString();
            instance.StrIngredient8 = formattedResponse["meals"][0]["strIngredient8"].ToString();
            instance.StrIngredient9 = formattedResponse["meals"][0]["strIngredient9"].ToString();
            instance.StrIngredient10 = formattedResponse["meals"][0]["strIngredient10"].ToString();

            return instance;
        }
    }
}