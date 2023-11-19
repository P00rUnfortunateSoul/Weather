using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirtsShop.Configuration
{
    public class BaseShirtEndpointSettings
    {
        public string Base_url { get; set; }
        public string GetAllShirts { get; set; }
        public string GetAllSizes { get; set; }
    }
}