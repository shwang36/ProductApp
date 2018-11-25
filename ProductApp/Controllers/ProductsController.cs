using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace ProductApp.Controllers
{
    public class ProductsController : ApiController
    {

        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };


        public IEnumerable<Product> GetAllProducts()
        {
            if (products == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpGet]
        [ActionName("Thumbnail")]
        public IHttpActionResult Details(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpDelete]
        [ActionName("Thumbnail2")]
        public void Delete(int id)
        {

        }


        [HttpPut]
        [ActionName("Thumbnail2")]
        public void Put(int id, [FromBody]test json)
        {
            test b = json;
            Console.WriteLine("");
        }

        [HttpPost]
        [ActionName("Thumbnail2")]
        public void Post(int id, [FromBody]test json)
        {
            test b = json;

            string a = json.Category.ToString();
            //     test t = JsonConvert.DeserializeObject<test>(json);
            /*            JObject jo = JObject.Parse(json);

                        string l_type = jo["123"].ToString();
                        string param1 = jo["PARAM1"].ToString();
            */
            Console.WriteLine("");
        }

    }
}
