using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Report
    {

        public string Title { get; set; }
        public string Text { get; set; }
        public Person Author { get; set; }
        public ReportStatus Status { get; set; }

        public Report(string title, string text, Person author)
        {
            Title = title;
            Text = text;
            Author = author;
            Status = ReportStatus.Pending;
        }

    }
}
