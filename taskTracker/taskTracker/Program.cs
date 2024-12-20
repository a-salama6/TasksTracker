namespace taskTracker
{
    internal class Program
    {
        static string[] Tasks = new string[100];
        static int taskIndex = 0;
        static void Main(string[] args)
        {
            //add Tasks
            //view tasks
            //compelete tasks
            //delete tasks
            //exit
            while (true)
            {
                Console.WriteLine("Welcome to TaskTracker");
                Console.WriteLine("-------------");
                Console.WriteLine();
                Console.WriteLine("What do you want ??😊😊😊");
                Console.WriteLine("choose 1 for add Task");
                Console.WriteLine("choose 2 for View Tasks");
                Console.WriteLine("choose 3 for Mark Task");
                Console.WriteLine("choose 4 for delete Task");
                Console.WriteLine("choose 5 for Exit");
                String input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        //add task
                        AddTasks();
                        break;
                    case "2":
                        ViewTasks()
                        ;
                        //View task
                        break;
                    case "3":
                        MarkTasks()
                        ;
                        //mark task
                        break;
                    case "4":
                        DeleteTasks()
                        ;
                        //delete task
                        break;
                    case "5":
                        Environment.Exit(0);
                        ;
                        //exit task
                        break;
                    default:
                        Console.WriteLine("Enter a vaild Number from 1 to 5");
                        break;
                }
            }

        }
        public static void AddTasks()
        {
            Console.WriteLine("Enter task's name ");
            string tasktitle=Console.ReadLine();
            Tasks[taskIndex] = tasktitle;
            taskIndex++;
        } 
        public static void ViewTasks()
        {
            Console.WriteLine("YOUR TASKS :");
            for (int i = 0; i < taskIndex; i++)
            {
                Console.WriteLine($"Task {i+1} is {Tasks[i]}");
            }
            Console.WriteLine("task added");
        }
        public static void MarkTasks()
        {
            Console.WriteLine("enter the index of your task compeleted:");
            int marked=int.Parse( Console.ReadLine());
            Tasks[marked-1] = $"Task {marked} is {Tasks[marked-1]} is compeleted";
        }
        public static void DeleteTasks()
        {
            Console.WriteLine("enter the index of your task want to delete:");
            int deleted=int.Parse( Console.ReadLine());
            Tasks[deleted - 1] = "task is deleted";
            Console.WriteLine("task deleted");
             
        }
    }
}                                                                            
