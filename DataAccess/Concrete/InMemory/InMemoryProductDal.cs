using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>{new Product{CategoryId=1,ProductId=1,ProductName="Kalem",UnitPrice=150,UnitsInStock=100, },
            new Product { CategoryId = 2, ProductId = 2, ProductName = "Silgi", UnitPrice = 50, UnitsInStock = 200, },
            new Product { CategoryId = 2, ProductId = 3, ProductName = "Defter", UnitPrice = 70, UnitsInStock = 100, },
            new Product { CategoryId = 3, ProductId = 4, ProductName = "Klavye", UnitPrice = 550, UnitsInStock = 10, },
            new Product { CategoryId = 4, ProductId = 5, ProductName = "Fare", UnitPrice = 250, UnitsInStock = 20, }
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            if (productToDelete != null)
            {
                _products.Remove(productToDelete);
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            if (productToUpdate != null)
            {
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.UnitsInStock = product.UnitsInStock;
                productToUpdate.CategoryId = product.CategoryId;

            }
        }
    }
}
