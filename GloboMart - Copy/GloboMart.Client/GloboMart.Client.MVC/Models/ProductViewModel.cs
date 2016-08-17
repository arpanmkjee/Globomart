using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace GloboMart.Client.MVC.Models
{
    public class ProductViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
    }

}