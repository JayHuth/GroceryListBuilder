using Newtonsoft.Json.Linq;

namespace APICall
{
    class program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            var foodURL = $"https://www.themealdb.com/api/json/v1/1/search.php?s=Arrabiata";
            var response = client.GetStringAsync(foodURL).Result;

            JObject formattedResponse = JObject.Parse(response);
            Console.WriteLine();
            Console.WriteLine(formattedResponse["meals"][0]["strMeal"]);
            Console.WriteLine(formattedResponse["meals"][0]["strIngredient1"]);
            Console.WriteLine(formattedResponse["meals"][0]["strIngredient2"]);
            Console.WriteLine(formattedResponse["meals"][0]["strIngredient3"]);
            Console.WriteLine(formattedResponse["meals"][0]["strIngredient4"]);
        }
    }
}