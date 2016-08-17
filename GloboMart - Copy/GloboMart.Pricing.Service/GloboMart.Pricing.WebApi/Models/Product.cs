using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloboMart.Contracts;

namespace GloboMart.Models
{
    public class Product : IProduct
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
    }
}
