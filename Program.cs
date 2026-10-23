
/*
DSA Activity 6.1 - [Lastname, Firstname]
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> jobs = new List<string>();
        int choice;
        int finished = 0;

        Console.WriteLine("Welcome to my JOB SCHEDULING");

        do
        {
            Console.WriteLine("\nChoose what you want to do?");
            Console.WriteLine("1 - NEW JOB");
            Console.WriteLine("2 - FINISH JOB");
            Console.WriteLine("3 - SEARCH JOB");
            Console.WriteLine("4 - CURRENT JOB");
            Console.WriteLine("5 - DISPLAY ALL JOBS");
            Console.WriteLine("6 - COUNT JOBS");
            Console.WriteLine("7 - EXIT");
            Console.Write("Enter code: ");

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("\nEnter new job: ");
                string job = Console.ReadLine();

                jobs.Add(job);
                Console.WriteLine("New job has been added!");
            }
            else if (choice == 2)
            {
                if (jobs.Count > 0)
                {
                    jobs.RemoveAt(0);
                    finished++;

                    Console.WriteLine("\nThe current job has been marked FINISH.");
                    Console.WriteLine("Total number of finished job: " + finished);
                }
                else
                {
                    Console.WriteLine("\nNo JOB on the list.");
                }
            }
            else if (choice == 3)
            {
                Console.Write("\nEnter job to search: ");
                string search = Console.ReadLine();

                if (jobs.Contains(search))
                    Console.WriteLine("Job found!");
                else
                    Console.WriteLine("Job not found.");
            }
            else if (choice == 4)
            {
                if (jobs.Count > 0)
                    Console.WriteLine("\nCurrent job: " + jobs[0]);
                else
                    Console.WriteLine("\nNo JOB on the list.");
            }
            else if (choice == 5)
            {
                if (jobs.Count > 0)
                {
                    Console.WriteLine("\nList of Jobs:");

                    foreach (string job in jobs)
                    {
                        Console.WriteLine(job);
                    }
                }
                else
                {
                    Console.WriteLine("\nNo JOB on the list.");
                }
            }
            else if (choice == 6)
            {
                Console.WriteLine("\nTotal number of jobs: " + jobs.Count);
            }
            else if (choice == 7)
            {
                Console.WriteLine("\nExiting program...");
            }
            else
            {
                Console.WriteLine("\nInvalid code. Please try again.");
            }

        } while (choice != 7);
    }
}
