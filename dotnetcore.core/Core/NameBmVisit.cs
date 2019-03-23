using dotnetcore.core.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetcore.core.Core
{
    public class UserVisit : IUserVisit
    {
        private UserContext _context;

        public UserVisit(UserContext context)// 用户访问 
        {
            _context = context;
        }

        public List<User> GetUserAll()
        {
            return _context.Users.ToList();
        }

    }
}
