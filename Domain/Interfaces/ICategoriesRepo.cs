using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICategories
    {
        IEnumerable<ProductsCategories> GetCategories();
        ProductsCategories GetCategoriesByID(int CategoriesId);
        void InsertCategories(ProductsCategories Categories);
        void DeleteCategories(int CategoriesID);
        void UpdateCategories(ProductsCategories Categories, int Id);
        void Save();

    }
}
