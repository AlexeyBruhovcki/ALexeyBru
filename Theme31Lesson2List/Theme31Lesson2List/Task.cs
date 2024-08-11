using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme31Lesson2List
{
    internal class Task
    {
        private string? name;
        private DateTime date;
        private string? description;

        public Task(string? name, DateTime date, string? description)
        {
            this.name = name;
            this.date = date;
            this.description = description;
        }
        public string? GetName() => name;
        public DateTime GetDate() => date;
        public string? GetDescription() => description;
        public void SetName(string? name) => this.name = name;
        public void SetDate(DateTime date) => this.date = date;
        public void SetDescription(string? description) => this.description = description;
    }
}
