using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace TaskListLab
{
    class Task
    {
        // Fields
        private string name;
        private string tdescription;
        private string duedate;
        private bool complete;

        //Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string TDescription
        {
            get
            {
                return tdescription;
            }
            set
            {
                tdescription = value;
            }
        }
        public string DueDate
        {
            get
            {
                return duedate;
            }
            set
            {
                duedate = value;
            }
        }
        public bool Complete
        {
            get
            {
                return complete;
            }
            set
            {
                complete = value;
            }
        }


        //Constructors
        public Task()
        {
            name = "Default";
        }
        public Task(string _name, string _tdescription, string _duedate, bool _complete)
        {
            name = _name;
            tdescription = _tdescription;
            duedate = _duedate;
            complete = _complete;
        }
        public Task(string _name, string _tdescription, string _duedate)
        {
            name = _name;
            tdescription = _tdescription;
            duedate = _duedate;
        }



        //Methods
        public static void ListMenu(List<string> menu)
        {
            int i = 1;
            foreach (string item in menu)
            {
                Console.WriteLine($"{i}. {item}");
                i++;
            }
        }

        public static string UserChoice()
        {
            string input = "";
            while (true)
            {
                Console.Write("What would you like to do? ");
                input = Console.ReadLine().Trim();
                if (input == "1")
                {
                    break;
                }
                if (input == "2")
                {
                    break;
                }
                if (input == "3")
                {
                    break;
                }
                if (input == "4")
                {
                    break;
                }
                if (input == "5")
                {
                    break;
                }
                if (input == "6")
                {
                    break;
                }
                if (input == "7")
                {
                    break;
                }
                Console.WriteLine("Enter one of the menu numbers");
            }
            return input;
        }

        public static List<Task> AddTask(List<Task> tasks)
        {
            DateTime due;
            Console.WriteLine("ADD TASK");
            Console.Write("Team member name: ");
            string name = Console.ReadLine();
            Console.Write("Task description: ");
            string description = Console.ReadLine();
            Console.Write("When is it due: ");
            while (!DateTime.TryParse(Console.ReadLine(), out due))
            {
                Console.WriteLine("Enter a valid date mm/dd/yy");
                Console.Write("When is it due: ");
            }
            string due1 = due.ToShortDateString();
            Task thing = new Task(name, description, due1);
            tasks.Add(thing);
            Console.WriteLine("Task Entered!");
            Console.WriteLine();
            return tasks;
        }

        public static void ListTasks(List<Task> tasks)
        {
            int i = 1;
            foreach (Task task in tasks)
            {
                Console.WriteLine($"{i}. {task.Name,-25}|Due on {task.DueDate,-10} |Completion status: {task.Complete} | Description = {task.TDescription}.");
                i++;
            }
            Console.WriteLine();
        }


        public static List<Task> DeleteTask(List<Task> tasks)
        {
            Task.ListTasks(tasks);
            Console.Write("Which task do you want to delete? ");
            int choice = 0;
            string answer = "";
            while (true)
            {
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    if (choice <= 0 || choice > tasks.Count)
                    {
                        throw new Exception("Enter a number in range ");
                    }
                }
                catch (FormatException)
                {
                    Console.Write("That is not a number! Enter a number in range: ");
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
                if (choice <= tasks.Count && choice > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{choice}. {tasks[choice - 1].Name,-25}|Due on {tasks[choice - 1].DueDate,-10} |Completion status: {tasks[choice - 1].Complete} | Description = {tasks[choice - 1].TDescription}.");
                    Console.WriteLine();
                    while (true)
                    {
                        Console.Write("Are you sure you wish to delete? y/n ");
                        answer = Console.ReadLine();
                        if (answer == "y")
                        {
                            tasks.RemoveAt(choice - 1);
                            Console.WriteLine($"Task {choice} deleted!");
                            Console.WriteLine();
                            break;
                        }
                        if (answer == "n")
                        {
                            Console.WriteLine($"Task {choice} not changed");
                            Console.WriteLine();
                            break;
                        }
                        Console.WriteLine("Enter y or n!");
                    }
                    break;
                }
            }
            return tasks;
        }

        public static List<Task> MarkComplete(List<Task> tasks)
        {
            Task.ListTasks(tasks);
            Console.Write("Which task do you want to mark complete? ");
            int choice = 0;
            string answer = "";
            while (true)
            {
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    if (choice <= 0 || choice > tasks.Count)
                    {
                        throw new Exception("Enter a number in range ");
                    }
                }
                catch (FormatException)
                {
                    Console.Write("That is not a number! Enter a number in range: ");
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
                if (choice <= tasks.Count && choice > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{choice}. {tasks[choice - 1].Name,-25}|Due on {tasks[choice - 1].DueDate,-10} |Completion status: {tasks[choice - 1].Complete} | Description = {tasks[choice - 1].TDescription}.");
                    Console.WriteLine();
                    while (true)
                    {
                        Console.Write("Are you sure you wish to mark complete? y/n ");
                        answer = Console.ReadLine();
                        if (answer == "y")
                        {
                            tasks[choice - 1].Complete = true;
                            Console.WriteLine($"Task {choice} completed!");
                            Console.WriteLine();
                            break;
                        }
                        if (answer == "n")
                        {
                            Console.WriteLine($"Task {choice} not changed");
                            Console.WriteLine();
                            break;
                        }
                        Console.WriteLine("Enter y or n!");
                    }
                    break;
                }
            }
            return tasks;
        }

        public static List<Task> EditTask(List<Task> tasks)
        {
            Task.ListTasks(tasks);
            Console.Write("Which task do you want to edit? ");
            int choice = 0;
            string answer = "";
            bool var = true;
            while (true)
            {
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    if (choice <= 0 || choice > tasks.Count)
                    {
                        throw new Exception("Enter a number in range ");
                    }
                }
                catch (FormatException)
                {
                    Console.Write("That is not a number! Enter a number in range: ");
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
                if (choice <= tasks.Count && choice > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{choice}. {tasks[choice - 1].Name,-25}|Due on {tasks[choice - 1].DueDate,-10} |Completion status: {tasks[choice - 1].Complete} | Description = {tasks[choice - 1].TDescription}.");
                    Console.WriteLine();
                    while (true)
                    {
                        Console.Write("Are you sure you wish to edit? y/n ");
                        answer = Console.ReadLine();
                        if (answer == "y")
                        {
                            DateTime due;
                            Console.WriteLine("EDIT TASK");
                            Console.Write("Team member name: ");
                            string name = Console.ReadLine();
                            Console.Write("Task description: ");
                            string description = Console.ReadLine();
                            Console.Write("When is it due: ");
                            while (!DateTime.TryParse(Console.ReadLine(), out due))
                            {
                                Console.WriteLine("Enter a valid date mm/dd/yy");
                                Console.Write("When is it due: ");
                            }
                            string due1 = due.ToShortDateString();
                            Console.Write("Is it complete? true/false ");
                            while (!bool.TryParse(Console.ReadLine(), out var))
                            {
                                Console.WriteLine("Enter true or false ");
                                Console.Write("Is it complete? ");
                            }
                            tasks[choice - 1].Name = name;
                            tasks[choice - 1].DueDate = due1;
                            tasks[choice - 1].TDescription = description;
                            tasks[choice - 1].Complete = var;
                            Console.WriteLine($"Task {choice} edited!");
                            Console.WriteLine();
                            break;
                        }
                        if (answer == "n")
                        {
                            Console.WriteLine($"Task {choice} not changed");
                            Console.WriteLine();
                            break;
                        }
                        Console.WriteLine("Enter y or n! ");
                    }
                    break;
                }
            }
            return tasks;
        }

        public static void PrintUserTasks(List<Task> tasks)
        {
            Console.Write("What specific user's tasks would you like to see? Please enter full name ");
            string answer = Console.ReadLine().ToLower();
            int i = 1;
            try
            {

                foreach (Task task in tasks)
                {
                    if (answer == task.Name.ToLower())
                    {
                        Console.WriteLine($"{i}. {task.Name,-25}|Due on {task.DueDate,-10} |Completion status: {task.Complete} | Description = {task.TDescription}.");
                        i++;
                    }
                }
                if (i == 1)
                {
                    throw new Exception("User not found");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
        }

    }
}
