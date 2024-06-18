using Microsoft.EntityFrameworkCore;
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
    public class MessionsRepository : IMessionsRepository
    {
        MessionsDbContext context { get; }

        public MessionsRepository(MessionsDbContext _context)
        {
            context = _context;
        }
        public bool AddMession(Mession mession)
        {
            try
            {
                Mession messionExsit = context.Messions.Where(m => m.TaskId == mession.TaskId).AsNoTracking().FirstOrDefault();
                if (messionExsit != null)
                {
                    context.Messions.Update(mession);
                }
                else
                    context.Messions.Add(mession);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mession> GetAllMession()
        {
            try
            {
                return context.Messions.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<User> GetOpenMession()
        {
            try
            {
                return context.Users.Where(u => u.Messions.Count() > 0).Include(m => m.Messions.Where(m => !m.IsCompleted)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mession> OutOfTimeMession()
        {
            try
            {
                List<Mession> list = context.Messions.Where(m => m.TargetDate < DateTime.Now && !m.IsCompleted).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
