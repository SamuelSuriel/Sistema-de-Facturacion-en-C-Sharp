using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionLaMelma
{
    public class Almacen
    {
        public class Product
        {
            public string name { get; set; }
            public string price { get; set; }
            public int productId { get; set; }
            //public int stock { get; set; }

            public Product(string name, string price, int productId)
            {
                this.name = name;
                this.price = price;
                this.productId = productId;
                //this.stock = stock;
            }
        }
    }
}
