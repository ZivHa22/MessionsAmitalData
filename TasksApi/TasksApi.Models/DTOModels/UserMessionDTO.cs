using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApi.Models.Entities;

namespace TasksApi.Models.DTOModels
{
    public class UserMessionDTO
    {
        public User user { get; set; }

        public List<Mession> messions { get; set; }
    }
}
