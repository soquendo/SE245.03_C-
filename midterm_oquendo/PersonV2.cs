using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_oquendo
{
    class PersonV2 : Person
    {
        private string cellphone;
        private string instaURL;

        public string Cellphone
        {
            get
            {
                return cellphone;
            }

            set
            {
                if (ValidationLibrary.IsItNum(value) == false)
                {
                    Feedback += "\nERROR: Please enter only digits (Ex. 4015551234)";
                }
                else 
                {
                    cellphone = value;
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
                instaURL = value;
            }
        }


    }

}

