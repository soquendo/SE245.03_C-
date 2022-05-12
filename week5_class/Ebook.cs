using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace week5_class
{
    /*-Build your EBook class by inheriting the Book class and adding RentalDueDate and BookmarkPage
    -Upgrade your Validation class by adding the newer validation functions.
    -Upgrade the validation within the Book and EBook "sets" and add Errors to the class' Feedback property.
    -If there are Errors, display the error messages.  If there are No Errors, display the data you entered in your Feedback Label.
    -Test it a few times making sure only valid data is being printed.*/

    class Ebook: Book
    {
        private DateTime rentalDueDate;
        private int bookmarkPg;

        public DateTime RentalDueDate
        {
            get
            {
                return rentalDueDate;
            }

            set
            {
                if (ValidationLibrary.IsAFutureDate(value))
                {
                    rentalDueDate = value;
                }
                else
                {
                    feedback += "\nERROR: Please enter a future date";
                }

            }
        }

        public int BookmarkPg
        {
            get
            {
                return bookmarkPg;
            }

            set
            {
                if (value >= 0 && value <= Pages)
                {
                    bookmarkPg = value;
                }
                else
                {
                    feedback += "\nERROR: You entered an invalid bookmark page number.";
                }
            }
        }

        public Ebook(): base ()
        {
            BookmarkPg = 0;
            rentalDueDate = DateTime.Now.AddDays(14);
        }

    }
}
