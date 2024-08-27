using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGBICEOne
{
    public class Product
    {
        public Guid ProductID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public static Product operator +(Product product, int quantity)
        {
            product.StockQuantity += quantity;
            return product;
        }

        public static Product operator -(Product product, int quantity)
        {
            if (product.StockQuantity >= quantity && product.StockQuantity != 0)
            {
                product.StockQuantity -= quantity;
            }
            
            return product;
        }

    }

}
