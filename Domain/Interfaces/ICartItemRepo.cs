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
        IEnumerable<CartItem> GetAll();
        CartItem GetByID(int CartItemId);
        void Insert(CartItem CartItem);
        void Delete(int CartItemID);
        void Update(CartItem CartItem);
        void Save();
    }
}

