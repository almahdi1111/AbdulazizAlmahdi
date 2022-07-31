using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Data;
using Domain.Interfaces;
using Infrastructure.Repo;

namespace EcommerceProject.Controllers
{
    public class CategoriesController : Controller
    {
        private AppDbContext _context;
        private ICategoriesRepo categoriesRepo;


        public CategoriesController(ICategoriesRepo categoriesRepo, AppDbContext context)

        {
            this.categoriesRepo = new CategoriesRepo(_context);
            this.categoriesRepo = categoriesRepo;
            _context = context;

        }



        // GET: ProductsCategoriess
        public IActionResult Index()
        {
            var appDbContext = categoriesRepo.GetAll();
            return View(appDbContext.ToList());
        }

        // GET: ProductsCategoriess/Details/5
        public IActionResult Details(int id)
        {

            var categorie = categoriesRepo.GetByID(id);


            if (categorie == null)
            {
                return NotFound();
            }

            return View(categorie);
        }

        // GET: ProductsCategoriess/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name");
            return View();
        }

        // POST: ProductsCategoriess/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,Code,Price,DiscountPercentage,CreatedAt,UserId,CategoriesId")] ProductsCategories categorie)
        {
            if (ModelState.IsValid)
            {
                categoriesRepo.Insert(categorie);
                categoriesRepo.Save();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", categorie.UserId);
            return View(categorie);
        }

        // GET: ProductsCategoriess/Edit/5
        public IActionResult Edit(int id)
        {


            var categorie = categoriesRepo.GetByID(id);
            if (categorie == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", categorie.UserId);
            return View(categorie);
        }

        // POST: ProductsCategoriess/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Code,Price,DiscountPercentage,CreatedAt,UserId,CategoriesId")] ProductsCategories categorie)
        {
            if (id != categorie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    categoriesRepo.Update(categorie);
                    categoriesRepo.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductsCategoriesExists(categorie.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", categorie.UserId);
            return View(categorie);
        }

        // GET: ProductsCategoriess/Delete/5
        public IActionResult Delete(int id)
        {


            var categorie = categoriesRepo.GetByID(id);

            if (categorie == null)
            {
                return NotFound();
            }

            return View(categorie);
        }

        // POST: ProductsCategoriess/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var categorie = categoriesRepo.GetByID(id);
            categoriesRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool ProductsCategoriesExists(int id)
        {
            return (categoriesRepo.GetByID(id) != null);
        }
    }
}
