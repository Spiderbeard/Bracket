using System.Collections.Generic;
using Capstone.Models;

namespace Capstone.DAO
{
    public interface IUserDAO
    {
        User GetUserByUsername(string username);
        User GetUserByEmail(string email);
        User AddUser(string username, string password, string role,string email);
    }
}
