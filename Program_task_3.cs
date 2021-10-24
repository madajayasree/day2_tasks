using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace welcomeWorld
{
    class Program2
    {

        static void Main(string[] args)
        {
            string name = "jayasree";
            String emailId = "jayasree@gmail.com";
            long mobileNumber = 1234567895;
            int sal = 40000;
            string address = "Bengalore";
            
            Console.WriteLine("Press 1 to add details");
            Console.WriteLine("Press 2 to update details");
            Console.WriteLine("Press 3 to display details");
            string press = Console.ReadLine();

            switch (press)
            {
                case "1":
                    Console.WriteLine("adding details");
                    Console.WriteLine("Date of birth is: ");
                    String dob = Console.ReadLine();
                    Console.WriteLine("annual salary: ");
                    String annualSal = Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("update details");
                    Console.WriteLine("Enter name : ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter emailID : ");
                    emailId = Console.ReadLine();
                    Console.WriteLine("Enter mobileNumber : ");
                    mobileNumber = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter salary : ");
                    sal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter address : ");
                    address = Console.ReadLine();

                    break;
                case "3":
                    Console.WriteLine("Employee details are: ");
                    Console.WriteLine("Name is : " +name);
                    Console.WriteLine("emailId is : " + emailId);
                    Console.WriteLine("mobileNumber is : " + mobileNumber);
                    Console.WriteLine("annual sal is : " + sal*12);
                    Console.WriteLine("address is : " + address);
                    break;


            }
            Console.ReadKey();






        }
    }
}
