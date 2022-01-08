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
            return _context.Users.Include(b => b.Address).FirstOrDefault(i => i.Id == userId);
           
        }

        public int AddUser(User user)
        {

            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;
        }

        public User GetUser(int userId)
        {
            return _context.Users.FirstOrDefault(p => p.Id == userId);
        }
        public void UpdateUser(User user)
        {
            _context.Attach(user);
            _context.Entry(user).Property("FirstName").IsModified = true;
            _context.Entry(user).Property("LastName").IsModified = true;
            _context.Entry(user).Property("DateOfBirth").IsModified = true;
            _context.Entry(user).Property("Gender").IsModified = true;
            _context.Entry(user).Property("Weight").IsModified = true;
     
            _context.SaveChanges();
        }
    }
}
