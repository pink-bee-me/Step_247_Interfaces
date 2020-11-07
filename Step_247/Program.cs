using System;

namespace Step_247
{
        class Program
        {
            static void Main(string[] args)
            {
            // var employee = new Employee();
           IQuittable employee = new Employee();
            employee.Quit();
            Console.ReadLine();
                 }

        }
    }
