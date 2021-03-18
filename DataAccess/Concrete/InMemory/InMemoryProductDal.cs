using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{ProductId=1,CategoryId=1,ProductName="Laptop",UnitPrice=15,UnitsInStock=15},
                new Product{ProductId=2,CategoryId=1,ProductName="Mouse",UnitPrice=145,UnitsInStock=105},
                new Product{ProductId=3,CategoryId=2,ProductName="Adapter",UnitPrice=175,UnitsInStock=105},
                new Product{ProductId=4,CategoryId=2,ProductName="Microfon",UnitPrice=165,UnitsInStock=25},
                new Product{ProductId=5,CategoryId=2,ProductName="Screen",UnitPrice=175,UnitsInStock=41}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }
        //LINQ - Language Integrated Query
        //Lambda
        public void Delete(Product product)
        {
       
       
           Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);
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

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //üRÜN ID BUL
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
