using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloboMart.Models;

namespace GloboMart.DAL
{
    public class UnitOfWork : IDisposable
    {
        private ProductCatalogueContext context = new ProductCatalogueContext();
        private GenericRepository<Product> productRepository;

        public GenericRepository<Product> ProductRepository
        {
            get
            {

                if (this.productRepository == null)
                {
                    this.productRepository = new GenericRepository<Product>(context);
                }
                return productRepository;
            }
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
