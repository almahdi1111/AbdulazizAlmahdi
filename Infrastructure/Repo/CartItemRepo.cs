using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Repo
{
    public class CartItemRepo : ICartItemRepo
    {
        public void DeleteCartItem(int CartItemID)
        {
            throw new NotImplementedException();
        }

        public CartItem GetCartItemByID(int CartItemId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CartItem> GetCartItems()
        {
            throw new NotImplementedException();
        }

        public void InsertCartItem(CartItem CartItem)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateCartItem(CartItem CartItem, int Id)
        {
            throw new NotImplementedException();
        }
    }
}
