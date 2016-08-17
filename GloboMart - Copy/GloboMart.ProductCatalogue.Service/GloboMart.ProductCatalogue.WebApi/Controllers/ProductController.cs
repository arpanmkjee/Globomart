using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using GloboMart.DAL;
using GloboMart.Models;

namespace GloboMart.Controllers
{
    public class ProductController : ApiController
    {
        private IProductRepository productRepository;

        public ProductController()
        {
            this.productRepository = new ProductRepository(new ProductCatalogueContext());
        }

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        // GET: api/Product/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult GetProduct(int id)
        {
            Product product = productRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // POST: api/Product
        [ResponseType(typeof(Product))]
        public IHttpActionResult PostProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            productRepository.InsertProduct(product);
            productRepository.Save();

            return Ok();
        }

        // GET: api/Product/Search/str
        [HttpGet]
        [ActionName("Search")]
        [ResponseType(typeof(ProductsDTO))]
        public IHttpActionResult Search(string id)
        {
            ProductsDTO products = new ProductsDTO { lstProducts = productRepository.GetProducts(id).ToList() };
            if (products == null)
            {
                return NotFound();
            }

            return Ok(products);
        }
    }
}
