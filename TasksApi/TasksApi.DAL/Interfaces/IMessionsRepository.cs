using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApi.Models.Entities;

namespace TasksApi.DAL.Interfaces
{
    public interface IMessionsRepository
    {
        public bool AddMession(Mession mession);

        public List<Mession> GetAllMession();
        public List<Mession> OutOfTimeMession();

        public List<User> GetOpenMession();

    }
}
