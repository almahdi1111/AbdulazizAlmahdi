using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repo
{
    public class CartItemRepo : ICartItemRepo
    {
        private AppDbContext _context;
        public CartItemRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Delete(int CartItemID)
        {
            CartItem cartitem = _context.cartItems.Find(CartItemID);
            if (cartitem != null)
                _context.cartItems.Remove(cartitem);
        }

        public CartItem GetByID(int CartItemId)
        {
            return _context.cartItems.Find(CartItemId);
        }

        public IEnumerable<CartItem> GetAll()
        {
            return _context.cartItems.ToList();
        }

        public void Insert(CartItem CartItem)
        {
            _context.cartItems.Add(CartItem);
        }

      
        public void Update(CartItem CartItem)
        {
            _context.Entry(CartItem).State = EntityState.Modified;

        }

   

      
        public void Save()
        {
            _context.SaveChanges();
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
