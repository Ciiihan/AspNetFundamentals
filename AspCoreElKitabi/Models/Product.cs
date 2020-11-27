using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreElKitabi.Models
{
    public class Product
    {
        public string Name { get; set; }
        public Decimal? Price { get; set; }
        public static Product [] GetProducts()
        {
            Product bilgisayar = new Product
            {
                Name="Bilgisayar" , Price=6500M
            };
            Product monitor = new Product
            {
                Name = "Monitor",
                Price = 3500M
            };
            return new Product[] { bilgisayar, monitor, null };
        }
    }

}
