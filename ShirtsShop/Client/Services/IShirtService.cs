using ShirtsShop.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ShirtsShop.Client.Services
{
    public interface IShirtService
    {
        event Action OnChange;
        List<Size> Sizes { get; set; }
        List<Shirt> Shirts { get; set; }
        Task<List<Shirt>> GetShirts();
        Task<Shirt> GetShirt(int id);
        Task GetSizes();
        Task<List<Shirt>> CreateShirt(Shirt shirt);
        Task<List<Shirt>> UpdateShirt(Shirt shirt, int id);
        Task<List<Shirt>> DeleteShirt(int id);

    }
}
