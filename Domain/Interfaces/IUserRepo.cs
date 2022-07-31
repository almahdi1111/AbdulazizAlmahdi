using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUserRepo
    {
        IEnumerable<Application_User> GetAll();
        Application_User GetByID(int UserId);
        void Insert(Application_User User);
        void Delete(int UserID);
        void Update(Application_User User);
        void Save();
    }
}
