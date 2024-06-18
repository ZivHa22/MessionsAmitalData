using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApi.Models.Entities;

namespace TasksApi.DAL.Interfaces
{
    public interface IUsersRepository
    {
        public List<User> GetUsersList();
    }
}
