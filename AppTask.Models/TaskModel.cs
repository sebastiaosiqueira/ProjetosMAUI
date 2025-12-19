using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTask.Models
{
    public  class TaskModel :INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PrevisionDate { get; set; }

        private bool _isCompleted;
        public bool IsCompleted
        {
            get { return _isCompleted; }
            set
            {
                _isCompleted = value; OnPropertyChanged(nameof(IsCompleted));
            }
        }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; } = DateTime.Now;
        public List<SubTaskModel> SubTasks { get; set; } = new List<SubTaskModel>();

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
              PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
