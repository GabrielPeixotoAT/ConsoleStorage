using ConsoleStorage.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStorage.Services.Product
{
    public class ProductService
    {
        ApplicationData context;

        public ProductService(ApplicationData context)
        {
            this.context = context;
        }

        public bool Add(Models.Product.Product product)
        {
            if (context.Products.FirstOrDefault(p => p.ProductID == product.ProductID) != null)
                return false;

            context.Products.Add(product);
            context.SaveChanges();

            return true;
        }
    }
}
