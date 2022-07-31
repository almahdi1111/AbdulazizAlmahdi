using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceProject.Controllers
{
    public class ProductsController : Controller
    {
        private AppDbContext _context;
        private IProductsRepo productsRepo;


        public ProductsController(IProductsRepo productsRepo, AppDbContext context)

        {
            this.productsRepo = new ProductRepo(_context);
            this.productsRepo = productsRepo;
            _context = context;

        }



        // GET: Products
        public IActionResult Index()
        {
            var appDbContext = productsRepo.GetAll();
            return View(appDbContext.ToList());
        }

        // GET: Products/Details/5
        public IActionResult Details(int id)
        {

            var product = productsRepo.GetByID(id);


            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,Code,Price,DiscountPercentage,CreatedAt,UserId,CategoriesId")] Product product)
        {
            if (ModelState.IsValid)
            {
                productsRepo.Insert(product);
                productsRepo.Save();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", product.UserId);
            return View(product);
        }

        // GET: Products/Edit/5
        public IActionResult Edit(int id)
        {


            var product = productsRepo.GetByID(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", product.UserId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Code,Price,DiscountPercentage,CreatedAt,UserId,CategoriesId")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    productsRepo.Update(product);
                    productsRepo.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", product.UserId);
            return View(product);
        }

        // GET: Products/Delete/5
        public IActionResult Delete(int id)
        {
          

            var product = productsRepo.GetByID(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public  IActionResult DeleteConfirmed(int id)
        {
            var product = productsRepo.GetByID(id);
            productsRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return (productsRepo.GetByID(id)!=null);
        }
    }
}
