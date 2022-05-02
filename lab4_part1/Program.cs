using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_part1
{
    class Program
    {
        struct person
        {
            public string fName;
            public string mName;
            public string lName;
            public string street1;
            public string street2;
            public string city;
            public string state;
            public string zipCode;
            public string phone;
            public string email;
        }

        static void Main(string[] args)
        {


            person temp = new person();

            Console.Write("\nEnter person's first name: ");
            temp.fName = Console.ReadLine();

            Console.Write("\nEnter person's middle name (leave blank if not applicable): ");
            temp.mName = Console.ReadLine();

            Console.Write("\nEnter person's last name: ");
            temp.lName = Console.ReadLine();

            Console.Write("\nEnter person's address: ");
            temp.street1 = Console.ReadLine();

            Console.Write("\nEnter Address Line 2 (Ex. Apt #, Room, PO Box [leave blank if not applicable]): ");
            temp.street2 = Console.ReadLine();

            Console.Write("\nEnter person's city: ");
            temp.city = Console.ReadLine();

            Console.Write("\nEnter person's state: ");
            temp.state = Console.ReadLine();

            Console.Write("\nEnter person's zip code: ");
            temp.zipCode = Console.ReadLine();

            Console.Write("\nEnter person's phone number: ");
            temp.phone = Console.ReadLine();

            Console.Write("\nEnter person's email address: ");
            temp.email = Console.ReadLine();


            if (temp.mName == "")
            {
                temp.mName = "N/A";
            }

            if (temp.street2 == "")
            {
                temp.street2 = "N/A";
            }


            Console.Write("\n\tYou entered: ");
            Console.Write($"\n\t First Name: \t\t{temp.fName}");
            Console.Write($"\n\t Middle Name: \t\t{temp.mName}");
            Console.Write($"\n\t Last Name: \t\t{temp.lName}");
            Console.Write($"\n\t Address Line 1: \t{temp.street1}");
            Console.Write($"\n\t Address Line 2: \t{temp.street2}");
            Console.Write($"\n\t City: \t\t\t{temp.city}");
            Console.Write($"\n\t State: \t\t{temp.state}");
            Console.Write($"\n\t Zip Code: \t\t{temp.zipCode}");
            Console.Write($"\n\t Phone: \t\t{temp.phone}");
            Console.Write($"\n\t E-Mail: \t\t{temp.email}");


            BasicTools.Pause();

        }













    }
}
