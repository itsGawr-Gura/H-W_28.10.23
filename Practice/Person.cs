using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    enum ProjectStatus { Draft, Active, Closed }
    enum TaskStatus { Open, InProgress, Completed }
    enum ReportStatus { Pending, Approved, Rejected }

    class Person
    {

        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

    }
}
