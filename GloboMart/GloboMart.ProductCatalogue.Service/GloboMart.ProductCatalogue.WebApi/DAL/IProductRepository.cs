using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloboMart.Models;

namespace GloboMart.DAL
{
    public interface IProductRepository : IDisposable
    {
        void InsertProduct(Product input);
        Product GetProductById(int id);
        IEnumerable<Product> GetProducts(string searchTerm);
        void Save();
    }
}
