using Manager.Services.Abstraction;
using Manager.Services.Implementation;
using Model.Models;

namespace TestTaskWinForm.Controllers
{
    public class UserController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public void CreateUser(string name)
        {
            _userService.CreateUser(name);
        }

        public User GetUserByID(int userID)
        {
            return _userService.GetUserByID(userID);
        }

        public IEnumerable<User> GetUsers()
        {
            return _userService.GetUsers();
        }

        public void UpdateUser(int userID, string name)
        {
            _userService.UpdateUser(userID, name);
        }

        public void DeleteUser(int userID)
        {
            _userService.DeleteUser(userID);
        }
    }
}
