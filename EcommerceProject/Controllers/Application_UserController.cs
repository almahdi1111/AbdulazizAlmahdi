using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Data;
using Domain.Interfaces;
using Infrastructure.Repo;

namespace EcommerceProject.Controllers
{
    public class Application_UserController : Controller
    {
        private readonly AppDbContext _context;
        private IUserRepo userRepo;


        public Application_UserController(IUserRepo userRepo, AppDbContext context)

        {
            this.userRepo = new UserRepo(_context);
            this.userRepo = userRepo;
            _context = context;

        }


        // GET: Application_Users
        public IActionResult Index()
        {
            var appDbContext = userRepo.GetAll();
            return View(appDbContext.ToList());
        }

        // GET: Application_Users/Details/5
        public IActionResult Details(int id)
        {
          

            var user = userRepo.GetByID(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Application_Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Application_Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,Code,Price,DiscountPercentage,CreatedAt,UserId,CategoriesId")] Application_User user)
        {
            if (ModelState.IsValid)
            {
                userRepo.Insert(user);
                userRepo.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Application_Users/Edit/5
        public IActionResult Edit(int id)
        {


            var user = userRepo.GetByID(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Application_Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Code,Price,DiscountPercentage,CreatedAt,UserId,CategoriesId")] Application_User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    userRepo.Update(user);
                    userRepo.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Application_UserExists(user.Id))
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
            return View(user);
        }

        // GET: Application_Users/Delete/5
        public IActionResult Delete(int id)
        {


            var user = userRepo.GetByID(id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Application_Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var user = userRepo.GetByID(id);
            userRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool Application_UserExists(int id)
        {
            return (userRepo.GetByID(id) != null);
        }
    }
}
