using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Task
    {

        public string Title { get; set; }
        public Person Assignee { get; set; }
        public List<Report> Reports { get; set; }
        public TaskStatus Status { get; set; }

        public Task(string title, Person assignee)
        {
            Title = title;
            Assignee = assignee;
            Reports = new List<Report>();
            Status = TaskStatus.Open;
        }

        public void Take(Person person)
        {
            Assignee = person;
            Status = TaskStatus.InProgress;
        }

        public void AddReport(Report report)
        {
            Reports.Add(report);
        }

    }
}
