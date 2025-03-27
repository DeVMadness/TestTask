using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Provider.Repositories.Abstraction
{
    public interface IUserRepository
    {
        void CreateUser(string name);
        User GetUserByID(int userID);
        IEnumerable<User> GetUsers();
        void UpdateUser(int userID, string name);
        void DeleteUser(int userID);
    }
}
