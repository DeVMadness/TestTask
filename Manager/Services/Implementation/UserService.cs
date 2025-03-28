using Manager.Services.Abstraction;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Provider.Repositories.Abstraction;
using Provider.Repositories.Implementation;

namespace Manager.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void CreateUser(string name)
        {
            _userRepository.CreateUser(name);
        }

        public void DeleteUser(int userID)
        {
            _userRepository.DeleteUser(userID);
        }

        public User GetUserByID(int userID)
        {
            return _userRepository.GetUserByID(userID);
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetUsers();
        }

        public void UpdateUser(int userID, string name)
        {
            _userRepository.UpdateUser(userID, name);
        }
    }
}
