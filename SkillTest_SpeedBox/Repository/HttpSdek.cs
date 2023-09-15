using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SkillTest_SpeedBox.Interface;
using SkillTest_SpeedBox.Models;
using System.Net.Http;
using System.Text.Json.Nodes;

namespace SkillTest_SpeedBox.Repository
{
    public class HttpSdek : IHttpSdek
    {
        public async Task<object> CalculetPrice(Order item)
        {
            HttpClient client = new HttpClient();

            HttpContent content = JsonContent.Create(item);

            var result = await client.PostAsync(@"http://api.cdek.ru/calculator/calculate_tarifflist.php", content);

            var resultObj = await result.Content.ReadFromJsonAsync<ResultCal>();

            if(resultObj.result != null)
            {
                return resultObj.result.price;
            }
            else
            {
                return JsonObject.Parse(await result.Content.ReadAsStringAsync());
            }
            

        }
    }
}
