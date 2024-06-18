using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApi.DAL.DataAccess;
using TasksApi.DAL.Interfaces;
using TasksApi.Models.Entities;

namespace TasksApi.DAL.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        MessionsDbContext context { get; }

        public UsersRepository(MessionsDbContext _context)
        {
            context = _context;
        }


        public List<User> GetUsersList()
        {
            try
            {
                return context.Users.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
