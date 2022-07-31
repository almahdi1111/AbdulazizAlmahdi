using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repo
{
    public class ProductRepo : IProductsRepo, IDisposable
    {
        private AppDbContext _context;
        public ProductRepo (AppDbContext context)
        {
            _context = context;
        }

        public void DeleteProduct(int productID)
        {
            Product product = _context.products.Find(productID);
            if (product != null)
                _context.products.Remove(product);
            else
            {
              
            }
        }

        public Product GetProductByID(int productId)
        {
            return _context.products.Find(productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.products.ToList();
        }

        public void InsertProduct(Product product)
        {
            _context.products.Add(product);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
