using System;
using System.Collections.Generic;

namespace Practice
{

    class Program
    {
        static void Main(string[] args)
        {

            Project project = new Project("Project 1");
            project.SetDeadline(DateTime.Now.AddDays(7));

            Person person1 = new Person("John");
            Person person2 = new Person("Mary");

            project.AddTask("Task 1", person1);
            project.AddTask("Task 2", person2);

            project.Start();

            project.Tasks[0].Take(person1);

            Report report = new Report("Report 1", "Text", person1);
            project.Tasks[0].AddReport(report);

            if (project.IsCompleted())
            {
                Console.WriteLine("Project completed!");
            }
            else
            {
                Console.WriteLine("Project in progress...");
            }
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

    }
   

}