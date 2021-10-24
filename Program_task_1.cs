using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string emailId;
             string mobileNumber;
             string address;
             int sal;
           DateTime doj;

            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Enter your emailId");
            emailId = Console.ReadLine();

            Console.WriteLine("Enter your mobileNumber");
            mobileNumber = Console.ReadLine();

            Console.WriteLine("Enter your address");
            address = Console.ReadLine();

            Console.WriteLine("Enter your doj");
            doj = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter your sal");
            sal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Employee details are : ");

            DateTime today = DateTime.Today;
            String exp = (today -doj).TotalDays.ToString();
            int totalDays = Convert.ToInt32(exp);
            int year = totalDays / 365;
            int remainingDays = totalDays % 365;
            int month = remainingDays / 30;
            remainingDays = remainingDays % 30;
    string  Text = year + "years " + month + "months and " + remainingDays + "days";  

            Console.WriteLine("Experience of " + name + " is: " + Text);

            long annualSal = sal * 12;
            Console.Write("Annual salary is: " + "$ " + annualSal);
            Console.ReadLine();  
            

        }
    }
}
