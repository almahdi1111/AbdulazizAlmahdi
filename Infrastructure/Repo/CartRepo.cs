using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repo
{
    public class CartRepo : ICartRepo
    {
        public void Deletecart(int cartID)
        {
            throw new NotImplementedException();
        }

        public Cart GetcartByID(int cartId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cart> Getcarts()
        {
            throw new NotImplementedException();
        }

        public void Insertcart(Cart cart)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Updatecart(Cart cart, int Id)
        {
            throw new NotImplementedException();
        }
    }
}
