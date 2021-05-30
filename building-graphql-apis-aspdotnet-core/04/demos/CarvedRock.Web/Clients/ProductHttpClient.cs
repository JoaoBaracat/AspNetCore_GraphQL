using System.Net.Http;
using System.Threading.Tasks;
using CarvedRock.Web.Models;
using Newtonsoft.Json;

namespace CarvedRock.Web.HttpClients
{
    public class ProductHttpClient
    {
        private readonly HttpClient _httpClient;

        public ProductHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Response<ProductsContainer>> GetProducts()
        {
            var response = await _httpClient.GetAsync(@"?query= 
            { products 
                { id name price rating photoFileName } 
            }");

            var responseAleases = await _httpClient.GetAsync(@"?query= 
            { results: products 
                { id name price rating photo: photoFileName } 
            }");    // adding the "photo:" and "results:" before the item it sets an alias


            var stringResult = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Response<ProductsContainer>>(stringResult);
        }
    }
}
