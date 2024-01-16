using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW2._4._1
{
    internal class Store
    {
        List<Product> products = new List<Product>();
        string Seller;

        public Store(string seller)
        {
            Seller = seller;
            if (string.IsNullOrEmpty(Seller))
            {
                throw new InvalidOperationException("Seller cannot be empty");
            }
        }

        public void Add(Product product)
        {
            if (products.Exists(t => t.Name == product.Name))
            {
                throw new InvalidOperationException("Store has already have this product");
            }
            else
            {
                products.Add(product);
            }
        }

        public void Sell(string name, float pay)
        {
            Product product = products.Find(t => t.Name == name);
            if (product == null)
            {
                throw new InvalidOperationException("Product hasn't been found");
            }
            if (pay < product.Price)
            {
                throw new InvalidOperationException("Insufficient funds");
            }
            else
            {
                products.Remove(product);
            }
        }
    }
}
