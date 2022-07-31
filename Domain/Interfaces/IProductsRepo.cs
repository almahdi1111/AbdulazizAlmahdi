using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IProductsRepo
    {
        IEnumerable<Product> GetAll();
        Product GetByID(int productId);
        void Insert(Product product);
        void Delete(int productID);
        void Update(Product product);
        void Save();
    }
}
