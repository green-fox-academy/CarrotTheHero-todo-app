using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Command Line Todo application \n" +
                                  "=============================");
                Console.WriteLine();
                Console.WriteLine("Command line arguments: \n" +
                                  "-l   Lists all the tasks \n" +
                                  "-a   Adds a new task \n" +
                                  "-r   Removes an task \n" +
                                  "-c   Completes an task");
            }
            else if (args.Contains("-l"))
            {
                string text = File.ReadAllText("ToDoList.txt");
                Console.WriteLine(text);
            }

            Console.ReadLine();
        }
    }
}
