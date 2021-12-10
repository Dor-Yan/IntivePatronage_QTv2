using Microsoft.EntityFrameworkCore;
using QT.Domain.Interface;
using QT.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IntivePatronageContext _context;
        public UserRepository(IntivePatronageContext context)
        {
            _context = context;
        }

        public IQueryable<User> GetAllUsers()
        {
            return _context.Users;
        }

        public User GetUserDetails (int userId)
        {
            var user = _context.Users.Include(b => b.Address).FirstOrDefault(i => i.Id == userId);
            return user;
        }
    }
}
