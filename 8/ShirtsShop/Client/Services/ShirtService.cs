using ShirtsShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using ShirtsShop.Configuration;




namespace ShirtsShop.Client.Services
{
    public class ShirtService : IShirtService
    {
        private readonly HttpClient _httpClient;
        private readonly BaseShirtEndpointSettings _shirtEndpointSettings;

        public ShirtService(HttpClient httpClient, AppSettings appSettings)
        {
            _httpClient = httpClient;
            _shirtEndpointSettings = appSettings.BaseShirtEndpoint;
        }

        public List<Size> Sizes { get; set; } = new List<Size>();
        public List<Shirt> Shirts { get; set; } = new List<Shirt>();

        public event Action OnChange;

        public async Task<List<Shirt>> GetShirts()
        {
            Shirts = await _httpClient.GetFromJsonAsync<List<Shirt>>($"{_shirtEndpointSettings.Base_url}{_shirtEndpointSettings.GetAllShirts}");
            return Shirts;
        }

        public async Task GetSizes()
        {
            Sizes = await _httpClient.GetFromJsonAsync<List<Size>>($"{_shirtEndpointSettings.Base_url}{_shirtEndpointSettings.GetAllSizes}");
        }

        public async Task<Shirt> GetShirt(int id)
        {
            return await _httpClient.GetFromJsonAsync<Shirt>($"{_shirtEndpointSettings.Base_url}{id}");
        }

        public async Task<List<Shirt>> CreateShirt(Shirt shirt)
        {
            var result = await _httpClient.PostAsJsonAsync($"{_shirtEndpointSettings.Base_url}", shirt);
            Shirts = await result.Content.ReadFromJsonAsync<List<Shirt>>();
            OnChange.Invoke();
            return Shirts;
        }

        public async Task<List<Shirt>> UpdateShirt(Shirt shirt, int id)
        {
            var result = await _httpClient.PutAsJsonAsync($"{_shirtEndpointSettings.Base_url}{id}", shirt);
            Shirts = await result.Content.ReadFromJsonAsync<List<Shirt>>();
            OnChange.Invoke();
            return Shirts;
        }

        public async Task<List<Shirt>> DeleteShirt(int id)
        {
            var result = await _httpClient.DeleteAsync($"{_shirtEndpointSettings.Base_url}{id}");
            Shirts = await result.Content.ReadFromJsonAsync<List<Shirt>>();
            OnChange.Invoke();
            return Shirts;
        }
    }
}