using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voter_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            DateTime dob;
            Console.WriteLine("Enter voter name : " );
            name = Console.ReadLine();
            Console.WriteLine("Enter voter dob : ");
            dob = Convert.ToDateTime(Console.ReadLine());

            DateTime today = DateTime.Today;
            String diff = (today-dob).TotalDays.ToString();
            int totalDays = Convert.ToInt32(diff);
            int year = totalDays / 365;
            string age = year + "Years ";
            Console.WriteLine(age);

            int a = System.Convert.ToInt32(age);
            Console.WriteLine(a);

            if (a >= 18)

            {
                Console.WriteLine("Eligible for voting");
            }
            else
            {
                Console.WriteLine("Not Eligible for voting");

            }
            Console.ReadKey();

          






        }
    }
}
