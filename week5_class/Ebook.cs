using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5_class
{
    /*-Build your EBook class by inheriting the Book class and adding RentalDueDate and BookmarkPage
    -Upgrade your Validation class by adding the newer validation functions.
    -Upgrade the validation within the Book and EBook "sets" and add Errors to the class' Feedback property.
    -If there are Errors, display the error messages.  If there are No Errors, display the data you entered in your Feedback Label.
    -Test it a few times making sure only valid data is being printed.*/

    class Ebook : Book
    {
        private DateTime rentalDueDate;
        private int bookmarkPg;

        public DateTime RentalDueDue
        {
            get
            {
                return rentalDueDate;
            }

            set
            {

            }
                

        }

    }
}
