using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KimetsuNoYaiba
{
    public class ApiConsume
    {
        private readonly HttpClient _httpClient;

        public ApiConsume()
        {
            HttpClient httpClient = new HttpClient();
            _httpClient = httpClient;
        }

        public async Task<T> GetApiData<T> (string apiUrl)
        {
            try
            {
                var response = await _httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(responseContent);
                }
                return default(T);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            

           
        }
    }
}