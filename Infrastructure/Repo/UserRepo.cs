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
    public class UserRepo : IUserRepo
    {
        private AppDbContext _context;
        public UserRepo(AppDbContext context)
        {
            _context = context;
        } 

        public void Delete(int UserID)
        {
            Application_User User = _context.Users.Find(UserID);
            if (User != null)
                _context.Users.Remove(User);
            else
            {

            }
        }

        public Application_User GetByID(int UserId)
        {
            return _context.Users.Find(UserId);
        }

        public IEnumerable<Application_User> GetAll()
        {
            return _context.Users.ToList();
        }

        public void Insert(Application_User User)
        {
            _context.Users.Add(User);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Application_User User)
        {
            _context.Entry(User).State = EntityState.Modified;
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
