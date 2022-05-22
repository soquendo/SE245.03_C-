using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace midterm_oquendo
{
    class PersonV2 : Person
    {
        private string cellphone;
        private string instaURL;

        public PersonV2(): base()
        {
            cellphone = "";
            instaURL = "";
        }

        public string Cellphone
        {
            get
            {
                return cellphone;
            }

            set
            {
                if (ValidationLibrary.IsItFilledPhone(value) == true)
                {
                    cellphone = value;
                }
                else
                {
                    feedback += "\nERROR: Cell number can not be blank, Please enter only digits (Ex. 4019997777)";
                }
            }
        }

        public string IG
        {
            get
            {
                return instaURL;
            }

            set
            {
               
                if (ValidationLibrary.IsItFilledInsta(value) == true)
                {
                    if (ValidationLibrary.IsItValidIG(value) == true)
                    {
                        instaURL = value;
                    }
                    else
                    {
                        feedback += "\nERROR Please enter valid instagram URL";
                    }

                }
                else
                {
                    feedback += "\nERROR: Enter Instagram URL (Ex. instagram.com/username)";
                }
                
            }
        }

        

    }
    
}

