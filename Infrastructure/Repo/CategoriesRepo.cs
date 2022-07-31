using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repo
{
    public class CategoriesRepo : ICategoriesRepo
    {
        public void DeleteCategories(int CategoriesID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductsCategories> GetCategories()
        {
            throw new NotImplementedException();
        }

        public ProductsCategories GetCategoriesByID(int CategoriesId)
        {
            throw new NotImplementedException();
        }

        public void InsertCategories(ProductsCategories Categories)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateCategories(ProductsCategories Categories, int Id)
        {
            throw new NotImplementedException();
        }
    }
}
