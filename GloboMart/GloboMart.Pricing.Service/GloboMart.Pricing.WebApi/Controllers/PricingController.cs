using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using GloboMart.Models;
using Newtonsoft.Json;

namespace GloboMart.Controllers
{
    public class PricingController : ApiController
    {
        private string ProductServiceUrl;

        public PricingController()
        {
            ProductServiceUrl = ConfigurationManager.AppSettings["ProductServiceURL"].ToString();
        }

        public string GetProductPrice(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(ProductServiceUrl);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Product/GetProduct/" + id.ToString()).Result;
            if (response.IsSuccessStatusCode)
            {
                var product = response.Content.ReadAsAsync<Product>().Result;
                return product.Price.ToString();
            }
            else
            {
                return "NA";
            }

        }

    }
}
