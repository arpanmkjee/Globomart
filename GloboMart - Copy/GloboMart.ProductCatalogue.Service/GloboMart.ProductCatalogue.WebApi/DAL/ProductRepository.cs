using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloboMart.Models;

namespace GloboMart.DAL
{
    public class ProductRepository : IProductRepository, IDisposable
    {
        private ProductCatalogueContext context;

        public ProductRepository(ProductCatalogueContext context)
        {
            this.context = context;
        }

        public IEnumerable<Product> GetProducts(string searchTerm)
        {
            return context.Product.Where(t => t.Name.Contains(searchTerm)).ToList();
        }

        public Product GetProductById(int id)
        {
            return context.Product.Find(id);
        }

        public void InsertProduct(Product input)
        {
            context.Product.Add(input);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
