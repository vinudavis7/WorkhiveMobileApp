//using GoogleGson;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
//using Org.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WorkHiveMobileApp.ViewModel;

namespace WorkHiveMobileApp.Services
{
    public class RestService 
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;

        public List<Jobs> Items { get; private set; }

        public RestService()
        {
            _client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public async Task<List<Jobs>> GetJobList()
        {
             Items = new List<Jobs>();
            string content = "";
            Uri uri = new Uri("https://c1056386.azurewebsites.net/api/Jobs");
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                     content = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject(content);
                    //var data = (JArray)JObject.Parse(content)["data"];
                    Items =   JsonConvert.DeserializeObject<List<Jobs>>(obj.ToString());
                }
            }
            catch (Exception ex)
            {
               // Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Items;
        }
        public async Task<Jobs> GetJobDetails(int id)
        {

            Jobs ob = new Jobs();
            string content = "";
            Uri uri = new Uri("https://c1056386.azurewebsites.net/api/Jobs/GetDetails/" + id);
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    content = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject(content);
                   
                   //var data = JObject.Parse(content)["data"];
                    ob = JsonConvert.DeserializeObject<Jobs>(obj.ToString());
                }
            }
            catch (Exception ex)
            {
                // Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return ob;
        }

    }
}
