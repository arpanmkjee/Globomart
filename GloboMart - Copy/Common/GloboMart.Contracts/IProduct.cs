using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Contracts
{
    public interface IProduct
    {
        int ID { get; set; }
        string Name { get; set; }
        float Price { get; set; }
    }
}
