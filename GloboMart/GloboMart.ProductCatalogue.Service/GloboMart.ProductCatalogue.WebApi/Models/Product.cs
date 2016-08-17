using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloboMart.Contracts;

namespace GloboMart.Models
{
    public class Product : IProduct
    {
        [Key]
        public int ID { get; set; }


        public string Name { get; set; }


        public float Price { get; set; }
    }

    public class ProductsDTO
    {
        public List<Product> lstProducts { get; set; }
    }
}
