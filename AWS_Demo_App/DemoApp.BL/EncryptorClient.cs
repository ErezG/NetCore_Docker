using DemoApp.BL.Configurations;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Cache;
using System.Net.Http;
using System.Threading.Tasks;

namespace DemoApp.BL
{
    public static class EncryptorClient
    {
        public static async Task<EncryptorResponse> Encrypt(string input)
        {
            EncryptorResponse responseContent = null;

            try
            {
                string path = $"Demo/Encrypt?input={input}";
                HttpResponseMessage response = null;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://" + CTConfig.Services.EncryptorDomain, UriKind.Absolute);
                    response = await client.GetAsync(path);
                }

                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    responseContent = JsonConvert.DeserializeObject<EncryptorResponse>(responseString);
                }
                else
                {
                    //log
                }
            }
            catch (Exception ex)
            {
                //log
            }

            return responseContent;
        }

        public class EncryptorResponse
        {
            public string Key { get; set; }
            public string Name { get; set; }
            public int RandomNumber { get; set; }
            public string Message { get; set; }
        }
    }
}
