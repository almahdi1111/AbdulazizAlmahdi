using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repo
{
    public class CategoriesRepo : ICategoriesRepo
    {
        AppDbContext _context;

        public CategoriesRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Delete(int CategoriesID)
        {
            ProductsCategories categories = _context.categories.Find(CategoriesID);
            if (categories != null)
                _context.categories.Remove(categories);


        }

        public IEnumerable<ProductsCategories> GetAll()
        {
            return _context.categories.ToList();
        }

        public ProductsCategories GetByID(int CategoriesId)
        {
            return _context.categories.Find(CategoriesId);
        }

        public void Insert(ProductsCategories Categories)
        {
            _context.Add(Categories);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(ProductsCategories Categories)
        {
            _context.Entry(Categories).State = EntityState.Modified;
        }
    }
}
