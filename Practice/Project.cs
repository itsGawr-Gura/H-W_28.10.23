using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Project
    {

        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public List<Task> Tasks { get; set; }
        public ProjectStatus Status { get; set; }

        public Project(string title)
        {
            Title = title;
            Tasks = new List<Task>();
            Status = ProjectStatus.Draft;
        }

        public void SetDeadline(DateTime deadline)
        {
            Deadline = deadline;
        }

        public void AddTask(string title, Person assignee)
        {
            Task task = new Task(title, assignee);
            Tasks.Add(task);
        }

        public void Start()
        {
            Status = ProjectStatus.Active;
        }

        public bool IsCompleted()
        {
            return Tasks.TrueForAll(t => t.Status == TaskStatus.Completed);
        }

    }
}
