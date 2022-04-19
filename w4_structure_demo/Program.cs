using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w4_structure_demo
{
    class Program
    {
        struct Book
        {
            public String Title;
            public String AuthorFirst;
            public String AuthorLast;
            public Double Price;
            public Int32 Pages;
            public DateTime PublishDate;
        }

        static void Main(string[] args)
        {

            BasicTools.credits();

            BasicTools.CreateBuffer(3);

            Console.WriteLine(" 7 + 6 = " + (7 + 6));

            BasicTools.pause();

            Book temp = new Book();
            //fill in the structure instance
            temp.Title "Star Wars"
            temp.AuthorFirst = "Scott"
            temp.AuthorLast = "Lambert"

            //hacker code runs
            temp.AuthorFirst += "-PoopyFace";
            //Print out structure instance info
            Console.WriteLine(temp.Title + " was directed by " + temp.AuthorFirst + " " + temp.AuthorLast);

            BasicTools.CreateBuffer(3);

            Book temp2 = new Book();
            //fill in the structure instance
            temp2.Title "Star Trek"
            temp2.AuthorFirst = "Scott"
            temp2.AuthorLast = "Lambert III"
            //Print out structure instance info
            Console.WriteLine(temp2.Title + " was directed by " + temp2.AuthorFirst + " " + temp2.AuthorLast);

            BasicTools.pause();
        }
    }
}
