﻿using System;
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
        private string email;
        private DateTime datePublished;
        private int pages;
        private double price;

        protected string feedback;
       

        public string Title
        {
            get
            { 
                return title;
            }

            set 
            { 
                if (!ValidationLibrary.badWords(value))
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
            get 
            {
                return authorFirst;
            }

            set
            {
                if (!ValidationLibrary.badWords(value))
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
                if (!ValidationLibrary.badWords(value))
                {
                    authorLast = value;
                }
                else
                {
                    feedback += "\nERROR: Author's last name cannot contain bad words.";
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
                    feedback += "\nERROR: Invalid email.";
                }
            }

        }

        public DateTime DatePublished
        {
            get
            {
                return datePublished;
            }

            set
            {
                if (ValidationLibrary.IsAFutureDate(value) == false)
                {
                    datePublished = value;
                }
                else
                {
                    feedback += "\nERROR: You cannot enter future dates";
                }
            }
        }


        public int Pages
        {
            get
            {
                return pages;
            }

            set
            {
                if (ValidationLibrary.IsMinimumAmount(value, 1) == true)
                {
                    pages = value;
                }
                else
                {
                    feedback += "\nERROR: Sorry number of pages is invalid.";
                }

            }
        }


        public double Price
        {
            get { return price; }

            set
            {
                if (ValidationLibrary.IsMinimumAmount(value, 0) == true)
                {
                    price = value;
                }
                else
                {
                    feedback += "\nERROR: Price is not sufficient.";
                }
            }
        }


        public string Feedback
        {
            get { return feedback; }
        }
        
        public Book()
        {
            title = "";
            authorFirst = "";
            authorLast = "";
            pages = 0;
            datePublished = DateTime.Parse("1/1/1500");
            price = 0.0;
            feedback = "";
        }


    }
}
