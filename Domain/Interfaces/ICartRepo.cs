using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICartRepo
    {
        IEnumerable<Cart> GetAll();
        Cart GetByID(int cartId);
        void Insert(Cart cart);
        void Delete(int cartID);
        void Update(Cart cart);
        void Save();
    }
}
