using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_oquendo
{
    class Class2
    {
        public class person
        {
            private string fName;
            private string mName;
            private string lName;
            private string street1;
            private string street2;
            private string city;
            private string state;
            private string zipCode;
            private string phone;
            private string email;

            public string fname
            {
                get
                {
                    return fName;
                }

                set
                {
                    fName = value;
                }
            }

            public string mname
            {
                get
                {
                    return mName;
                }

                set
                {
                    mName = value;
                }
            }

            public string lname
            {
                get
                {
                    return lName;
                }

                set
                {
                    lName = value;
                }
            }

            public string Street1
            {
                get
                {
                    return street1;
                }

                set
                {
                    street1 = value;
                }
            }

            public string Street2
            {
                get
                {
                    return street2;
                }

                set
                {
                    street2 = value;
                }
            }

            public string City
            {
                get
                {
                    return city;
                }

                set
                {
                    city = value;
                }
            }

            public string State
            {
                get
                {
                    return state;
                }

                set
                {
                    state = value;
                }
            }

            public string Zipcode
            {
                get
                {
                    return zipCode;
                }

                set
                {
                    zipCode = value;
                }
            }

            public string Phone
            {
                get
                {
                    return phone;
                }

                set
                {
                    if (ValidationLibrary.IsItFilledIn(value, 10) == true)
                    {
                        phone = value;
                    }
                    else
                    {
                        phone = "Error; Enter 10=digit phone number ex. 3025559999";
                    }

                }
            }

            public string Email
            {
                get
                {
                    return email;
                }

                set
                {
                    if (ValidationLibrary.IsValidEmail(value))
                    {
                        email = value;
                    }
                    else
                    {
                        email = "INVALID";
                    }

                }
            }


        }

        static void Main(string[] args)
        {
            //bool blnResult = false;

            person temp = new person();

            Console.Write("\nEnter person's first name: ");
            temp.fname = Console.ReadLine();
            
            Console.Write("\nEnter person's middle name (leave blank if not applicable): ");
            temp.mname = Console.ReadLine();

            Console.Write("\nEnter person's last name: ");
            temp.lname = Console.ReadLine();

            Console.Write("\nEnter person's address: ");
            temp.Street1 = Console.ReadLine();

            Console.Write("\nEnter Address Line 2 (Ex. Apt #, Room, PO Box [leave blank if not applicable]): ");
            temp.Street2 = Console.ReadLine();

            Console.Write("\nEnter person's city: ");
            temp.City = Console.ReadLine();

            Console.Write("\nEnter person's state: ");
            temp.State = Console.ReadLine();

            Console.Write("\nEnter person's zip code: ");
            temp.Zipcode = Console.ReadLine();

            Console.Write("\nEnter person's phone number: ");
            temp.Phone = Console.ReadLine();

            Console.Write("\nEnter person's email address: ");
            temp.Email = Console.ReadLine();


            if (temp.mname == "")
            {
                temp.mname = "N/A";
            }

            if (temp.Street2 == "")
            {
                temp.Street2 = "N/A";
            }


            Console.Write("\n\tYou entered: ");
            Console.Write($"\n\t First Name: \t\t{temp.fname}");
            Console.Write($"\n\t Middle Name: \t\t{temp.mname}");
            Console.Write($"\n\t Last Name: \t\t{temp.lname}");
            Console.Write($"\n\t Address Line 1: \t{temp.Street1}");
            Console.Write($"\n\t Address Line 2: \t{temp.Street2}");
            Console.Write($"\n\t City: \t\t\t{temp.City}");
            Console.Write($"\n\t State: \t\t{temp.State}");
            Console.Write($"\n\t Zip Code: \t\t{temp.Zipcode}");
            Console.Write($"\n\t Phone: \t\t{temp.Phone}");
            Console.Write($"\n\t E-Mail: \t\t{temp.Email}");


            BasicTools.Pause();

        }











    }
}
