using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApi.DAL.Interfaces;
using TasksApi.Models.Entities;

namespace TasksApi.BL
{
    public class TasksSevice
    {
        public readonly IUsersRepository usersRepository;
        public readonly IMessionsRepository messionsRepository;
        public TasksSevice(IUsersRepository _usersRepository, IMessionsRepository _messionsRepository)
        {
            usersRepository = _usersRepository;
            messionsRepository = _messionsRepository;
        }

        public List<User> GetUsersList()
        {
            return usersRepository.GetUsersList();
        }

        public bool AddMession(Mession mession)
        {
            return messionsRepository.AddMession(mession);
        }
        public List<Mession> GetAllMession()
        {
            return messionsRepository.GetAllMession();
        }
        public List<User> GetOpenMession()
        {
            return messionsRepository.GetOpenMession();
        }
        public List<Mession> OutOfTimeMession()
        {
            return messionsRepository.OutOfTimeMession();
        }
    }
}
