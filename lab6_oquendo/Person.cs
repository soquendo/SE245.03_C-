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
        protected string feedback;

        public Person()
        {
            fName = "";
            mName = "";
            lName = "";
            street1 = "";
            street2 = "";
            city = "";
            state = "";
            zipCode = "";
            phone = "";
            email = "";
            feedback = "";

        }

        public string Feedback
        {
            get
            {
                return feedback;
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
                    feedback += "\nERROR: First name cannot be left blank";
                }
                else
                {
                    if (ValidationLibrary.badWords(value) == true)
                    {
                        feedback += "\nERROR: Cannot contain bad words";
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
                    feedback += "\nERROR: Cannot contain bad words";
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
                    feedback += "\nERROR: Last name cannot be left blank";
                }
                else
                {
                    if (ValidationLibrary.badWords(value) == true)
                    {
                        feedback += "\nERROR: Cannot contain bad words";
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
                    feedback += "\nERROR: Address cannot be left blank";
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
                    feedback += "\nERROR: City cannot be left blank";
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
                    feedback = "\nERROR: Enter two-character state abbreviation (Ex. NY, MT, WA)";
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
                    feedback += "\nERROR: Please enter 5 digit number (Ex. 02861)";
                }
                if (ValidationLibrary.IsItNum(value) == false)
                {
                    feedback += "\nERROR: Please enter 5 digit number (Ex. 02861)";
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
                    feedback += "\nERROR: Phone number can not be blank, Please enter only digits (Ex. 4019997777)";
                }
                else
                {
                    if (ValidationLibrary.IsItNum(value) == false)
                    {
                        feedback += "\nERROR: Please enter only digits forphone number (Ex. 4017776666)";
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
                    feedback = "\nERROR: Invalid Email format";
                }

            }
        }


    }

}
