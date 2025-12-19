using AppTask.Models;
using AppTask.Database;
using AppTask.Repositories;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace AppTask.Repositories
{
    public class TaskModelRepository : ITaskModelRepository
    {
        private AppTaskContext _db;
        public TaskModelRepository()
        {
            _db = new AppTaskContext();

        }

        public IList<TaskModel> GetAll()
        {
            return _db.Tasks.OrderBy(a => a.PrevisionDate).ToList();
        }
        public TaskModel GetById(int id)
        {
            return _db.Tasks.Include(a => a.SubTasks).FirstOrDefault(a=> a.Id ==id);

        }
        public void Add(TaskModel task)
        {
           _db.Tasks.Add(task);
            _db.SaveChanges();
        }
        public void Update(TaskModel task)
        {
            _db.Tasks.Update(task);
            _db.SaveChanges();


        }
        public void Delete(TaskModel task)
        {

            _db.Tasks.Remove(task);
            _db.SaveChanges();
        }
    }
}