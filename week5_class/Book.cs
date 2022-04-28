using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5_class
{
    class Book
    {
        private string title;
        private string authorFirst;
        private string authorLast;
        private double price;
        private string feedback;
        //private string feedback = "";

        public Book()
        {
            price = 0;
            feedback = "";
        }

        public string Title
        {
            get { return title; }

            set 
            { 
                if (value.ToUpper().Contains("HOMEWORK") == false)
                {
                    title = value;
                }
                else
                {
                    feedback += "\nERROR: Title cannot contain bad words.";
                }
            }
        }

        public string AuthorFirst
        {
            get { return authorFirst; }

            set
            {
                if (value.ToUpper().Contains("HOMEWORK") == false)
                {
                    authorFirst = value;
                }
                else
                {
                    feedback += "\nERROR: Author's first name cannot contain bad words.";
                }
            }
        }

        public string AuthorLast
        {
            get { return authorLast; }

            set
            {
                if (value.ToUpper().Contains("HOMEWORK") == false)
                {
                    authorLast = value;
                }
                else
                {
                    feedback += "\nERROR: Author's last name cannot contain bad words.";
                }
            }
        }

        public double Price
        {
            get { return price; }

            set
            {
                if (value  >= 0)
                {
                    price = value;
                }

                else
                {
                    feedback += "\nERROR: Price must be 0 or greater";
                }

            }
        }

        public string Feedback
        {
            get { return feedback; }
        }
        



    }
}
