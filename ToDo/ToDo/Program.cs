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
                string[] text = File.ReadAllLines("ToDoList.txt");

                if (text.Length == 0)
                {
                    Console.WriteLine("No todos for today! :)");
                }
                else
                {
                    List<string> list = new List<string>();

                    for (int i = 0; i < text.Count(); i++)
                    {
                        list.Add(text[i]);
                        Console.WriteLine(" " + (i + 1) + " - " + list[i]);
                    }
                }

            }

            else if (args.Contains("-a"))
            {
                try
                {
                    using (StreamWriter writer = File.AppendText("ToDoList.txt"))
                    {
                        writer.WriteLine("{ } " + args[1]);
                    }
                }

                catch
                {
                    Console.WriteLine("Unable to add: no task provided");
                }                              
            }

            else if (args.Contains("-r"))
            {
                try
                {
                    var file = new List<string>(File.ReadAllLines("ToDoList.txt"));
                    file.RemoveAt(Convert.ToInt32(args[1])-1);
                    File.WriteAllLines("ToDoList.txt", file);
                }

                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Unable to add: no task provided");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Unable to remove: index is out of bound");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to remove: index is not a number");
                }
            }

            else if (args.Contains("-c"))
            {
                var file = File.ReadAllLines("ToDoList.txt");
                string temp = file[Convert.ToInt32(args[1]) - 1].Substring(4);
                file[Convert.ToInt32(args[1]) - 1] = "{X} " + temp;
                File.WriteAllLines("ToDoList.txt", file);
            }

            else
            {
                Console.WriteLine("Unsupported argument");
                Console.WriteLine();
                Console.WriteLine("-l   Lists all the tasks \n" +
                                  "-a   Adds a new task \n" +
                                  "-r   Removes an task \n" +
                                  "-c   Completes an task");                         
            }
            
         Console.ReadLine();
        }
    }
}
