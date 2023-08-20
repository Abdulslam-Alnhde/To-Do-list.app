using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_list_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to the ToDo list app ");
            List<string> tasklist = new List<string>();
            string option = "";



            while (option != "e")
            {
             
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 1 to add a task to the list.");
                Console.WriteLine("Enter 2 to view the list.");
                Console.WriteLine("Enter 3 to remove a task from the list.");
                Console.WriteLine("Enter e to exit the program.");
                

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Pleas enter the name of the task to add to the list.");
                    string task = Console.ReadLine();
                    tasklist.Add(task);
                    Console.WriteLine("Task is added to the list.");
                }


                else if (option == "2")
                {
                    Console.WriteLine("current tasks in the list :");
                    for (int i = 0; i < tasklist.Count; i++)
                    {
                        Console.WriteLine(tasklist[i]);
                    }
                }



                else if (option == "3")
                {
                    for (int i = 0; i < tasklist.Count; i++)
                    {
                        Console.WriteLine(i + ":" + tasklist[i]);
                    }
                    Console.WriteLine("Pleas enter the number of the task to remove it from the list .");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    tasklist.RemoveAt(taskNumber);
                }


                else if (option == "e")
                {
                    Console.WriteLine("Exiting programing ");
                }

                else
                {
                    Console.WriteLine("Invalid option, please try again.");
                }

            }
            Console.WriteLine("Thank you for used the program");
            Console.ReadKey();
        }
    }
}
