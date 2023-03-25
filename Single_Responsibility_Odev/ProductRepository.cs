using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Odev
{
    public class ProductRepository
    {
        public void AddProduct(Product product)
        {
            Console.WriteLine($"{product.ProductId} numaralı {product.ProductName} isimli ürün oluşturuldu.");
        }
    }
}
