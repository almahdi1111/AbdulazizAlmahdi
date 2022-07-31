using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICategoriesRepo
    {
        IEnumerable<ProductsCategories> GetAll();
        ProductsCategories GetByID(int CategoriesId);
        void Insert(ProductsCategories Categories);
        void Delete(int CategoriesID);
        void Update(ProductsCategories Categories);
        void Save();

    }
}
