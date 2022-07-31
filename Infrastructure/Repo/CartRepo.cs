using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repo
{
    public class CartRepo : ICartRepo
    {
        private AppDbContext _context;
        public CartRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Delete(int cartID)
        {
            Cart cart = _context.carts.Find(cartID);
            if (cart != null)
                _context.carts.Remove(cart);
            else
            {

            }
        }

        public Cart GetByID(int cartId)
        {
            return _context.carts.Find(cartId);
         }

        public IEnumerable<Cart> GetAll()
        {
           return _context.carts.ToList();
        }

        public void Insert(Cart cart)
        {
            _context.carts.Add(cart);
        }

        public void Save()
        {
            _context.SaveChanges(); 
        }

        public void Update(Cart cart)
        {
            _context.Entry(cart).State = EntityState.Modified;
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
