using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTask.Models
{
    public  class TaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PrevisionDate { get; set; }
        public bool IsCompleted { get; set; }
        public List<SubTaskModel> SubTasks { get; set; } = new List<SubTaskModel>();
    }
}
