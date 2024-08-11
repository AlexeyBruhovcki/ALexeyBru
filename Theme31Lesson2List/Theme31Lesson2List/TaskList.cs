using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Theme31Lesson2List
{
    internal class TaskList
    {
        private List<Task> tasks;

        public TaskList()
        {
            tasks = new List<Task>();
        }
        public void Addtask(Task task) => tasks.Add(task);
        public void RemoveTask(string name)
        {
            Task task = tasks.Find(p => p.GetName() == name)!;
            tasks.Remove(task);
        }
        public Task FindByName(string title) => tasks.Find(p => p.GetName() == title)!;
        public Task FindByDate(DateTime date) => tasks.Find(p => p.GetDate() == date)!;
        public Task FindByDesc(string description) => tasks.Find(p => p.GetDescription() == description)!;
        public List<Task> GetTasks() => tasks;
    }
}
