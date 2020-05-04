using System;
using System.Collections.Generic;
using System.Globalization;

namespace TaskListLab
{
    class Program
    {
        static void Main(string[] args)
        {
                List<string> menu = new List<string>() { "List Task", "Add Task", "Delete Task", "Mark Complete","Edit Task", "Specific User Tasks", "Quit" };
            List<Task> tasks = new List<Task>();
            Task defualt = new Task("Josh Forner", "Finish Project", "5/1/2020");
            Task defualt1 = new Task("Josh Forner", "Wash Car", "5/2/2020");
            Task defualt2 = new Task("Sam Forner", "Go back to work", "6/1/2020");
            Task defualt3 = new Task("Super Long Name Dude Guy", "Get a shorter name", "9/1/2025");
            tasks.Add(defualt);
            tasks.Add(defualt1);
            tasks.Add(defualt2);
            tasks.Add(defualt3);
            while (true)
            {
                Console.WriteLine("Main Menu");
                Task.ListMenu(menu);
                string choice = Task.UserChoice();
                if (choice == "1")
                {
                    Console.WriteLine();
                    Task.ListTasks(tasks);
                }
                if (choice == "2")
                {
                    Console.WriteLine();
                    Task.AddTask(tasks);
                }
                if (choice == "3")
                {
                    Console.WriteLine();
                    Task.DeleteTask(tasks);
                }
                if (choice == "4")
                {
                    Console.WriteLine();
                    Task.MarkComplete(tasks);
                }
                if (choice == "5")
                {
                    Console.WriteLine();
                    Task.EditTask(tasks);
                }
                if (choice == "6")
                {
                    Console.WriteLine();
                    Task.PrintUserTasks(tasks);
                }
                if (choice == "7")
                {
                    Console.WriteLine();
                    Console.WriteLine("Goodbye!");
                    break;
                }
                
            }
        }

        
    }
}
