using System;
using System.Collections.Generic;
using System.Text;

namespace Step_247
{
    public class Employee : IQuittable

    {
        public void Quit()
        {
            Console.WriteLine("The employee quit.");
        }
    }
} 

