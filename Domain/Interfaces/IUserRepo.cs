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
        IEnumerable<Application_User> GetUsers();
        Application_User GetUserByID(int UserId);
        void InsertUser(Application_User User);
        void DeleteUser(int UserID);
        void UpdateUser(Application_User User, int Id);
        void Save();
    }
}
