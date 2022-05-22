using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_oquendo
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
                if (ValidationLibrary.IsItFilledIn(value) == false)
                {
                    Feedback += "\nERROR: First name cannot be left blank";
                }
                else
                {
                    if(ValidationLibrary.badWords(value) == true)
                    {
                        Feedback += "\nERROR: Cannot contain bad words";
                    }
                    else
                    {
                        fName = value;
                    }
                }
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
                if (ValidationLibrary.badWords(value) == true)
                {
                    Feedback += "\nERROR: Cannot contain bad words";
                }
                else
                {
                    mName = value;
                }
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
                if (ValidationLibrary.IsItFilledIn(value) == false)
                {
                    Feedback += "\nERROR: Last name cannot be left blank";
                }
                else
                {
                    if (ValidationLibrary.badWords(value) == true)
                    {
                        Feedback += "\nERROR: Cannot contain bad words";
                    }
                    else
                    {
                        lName = value;
                    }
                }
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
                if (ValidationLibrary.IsItFilledIn(value) == false)
                {
                    Feedback += "\nERROR: Address cannot be left blank";
                }
                else
                {
                    street1 = value;
                }
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
                if (ValidationLibrary.IsItFilledIn(value) == false)
                {
                    Feedback += "\nERROR: City cannot be left blank";
                }
                else
                {
                    city = value;
                }
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
                    Feedback = "\nERROR: Enter two-character state abbreviation (Ex. NY, MT, WA)";
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
                    Feedback += "\nERROR: Please enter 5 digit number (Ex. 02861)";
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
                    Feedback += "\nERROR: Please enter only digits (Ex. 4019997777)";
                }
                else
                {
                    if (ValidationLibrary.IsItNum(value) == false)
                    {
                        Feedback += "\nERROR: Please enter only digits (Ex. 4017776666)";
                    }
                    else
                    {
                        phone = value;
                    }
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
                    Feedback = "\nERROR: Invalid Email format";
                }

            }
        }


    }

}
