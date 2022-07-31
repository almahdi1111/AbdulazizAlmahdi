using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICartItemRepo
    {
        IEnumerable<CartItem> GetCartItems();
        CartItem GetCartItemByID(int CartItemId);
        void InsertCartItem(CartItem CartItem);
        void DeleteCartItem(int CartItemID);
        void UpdateCartItem(CartItem CartItem, int Id);
        void Save();
    }
}

