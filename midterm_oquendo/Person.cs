using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_oquendo
{
    class Person
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
        private string feedback = "";

        public string Feedback
        {
            get
            {
                return feedback; 
            }

            set
            {
                feedback = value;
            }
        }

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
                if (ValidationLibrary.stateABV(value, 2) == true)
                {
                    state = value;
                }
                
                else
                {
                    Feedback = "ERROR: Enter two-character state abbreviation ex. NY, MT, WA";
                }

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
                if (ValidationLibrary.IsItFilledZip(value) == false)
                {
                    Feedback += "\nERROR: Please enter 5 digit number (Ex. 02861)";
                }
                if (ValidationLibrary.IsItNum(value) == false)
                {
                    Feedback += "\nERROR: Please enter 10 digit number (Ex. 02861)";
                }
                else
                {
                    zipCode = value;
                }

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
                if (ValidationLibrary.IsItFilledPhone(value) == false)
                {
                    Feedback += "\nERROR: Please enter only digits (Ex. 4015551234)";
                }
                if (ValidationLibrary.IsItNum(value) == false)
                {
                    Feedback += "\nERROR: Please enter only digits (Ex. 4015551234)";
                }
                else
                {
                    phone = value;
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
                    Feedback = "ERROR: Invalid Email format";
                }

            }
        }


    }

}
