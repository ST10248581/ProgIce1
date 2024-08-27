using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGBICEOne
{
    public static class Inventory
    {
        public static List<Product> Products { get; set; } = new List<Product>();


        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }


        public static string ProcessSale(dynamic product, int quantitySold)
        {
            
                if (product.StockQuantity >= quantitySold)
                {
                    product.StockQuantity -= quantitySold;

                return $"{quantitySold} units of {product.Name} sold. \n Remaining Stock: {product.StockQuantity}";
                }
                else
                {
                    return $"Insufficient stock for {product.Name}. Available stock: {product.StockQuantity}";
                }
        }

        public static string GenerateInventorySummary()
        {
            var summaryReport = Products.Select(p => new
            {
                p.Name,
                p.Category,
                p.StockQuantity
            }).ToList();

            var stringBuilder = new StringBuilder($"Inventory Summary Report:{Environment.NewLine}------------------------------------------------{Environment.NewLine}");

            foreach (var item in summaryReport)
            {
                stringBuilder.AppendLine($"{item.Name}");
                stringBuilder.AppendLine("------------------------------------------------");
                stringBuilder.AppendLine($"Category: {item.Category}");
                stringBuilder.AppendLine($"Stock: {item.StockQuantity}");
                stringBuilder.AppendLine("------------------------------------------------");
            }

            return stringBuilder.ToString();
        }
    }
}
