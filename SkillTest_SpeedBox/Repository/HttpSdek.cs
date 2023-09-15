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

        public async Task<int> GetCodeSity(string fias)
        {
            HttpClient client = new HttpClient();

            var result = await client.GetAsync(@"http://integration.cdek.ru/v1/location/cities/json?fiasGuid="+fias);

            var resultObj = await result.Content.ReadAsStringAsync();

            var sity = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(resultObj);

            if (sity.Count == 0)
                return -1;
            
            return int.Parse(sity[0]["cityCode"]);
        }
    }
}
