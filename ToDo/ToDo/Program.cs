using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Command Line Todo application \n" +
                              "=============================");
            Console.WriteLine();
            Console.WriteLine("Command line arguments: \n" +
                              "-l   Lists all the tasks \n" +
                              "-a   Adds a new task \n" +
                              "-r   Removes an task \n" +
                              "-c   Completes an task");

            Console.ReadLine();
        }
    }
}
