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
        IEnumerable<Cart> Getcarts();
        Cart GetcartByID(int cartId);
        void Insertcart(Cart cart);
        void Deletecart(int cartID);
        void Updatecart(Cart cart, int Id);
        void Save();
    }
}
