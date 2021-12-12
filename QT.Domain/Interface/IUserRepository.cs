using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Domain.Model;

namespace QT.Domain.Interface
{
    public interface IUserRepository
    {
        IQueryable<User> GetAllUsers();
        User GetUserDetails(int userId);

        int AddUser(User user);
        User GetUser(int userId);
        void UpdateUser(User user);
    }
}
