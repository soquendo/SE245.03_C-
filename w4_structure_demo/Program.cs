using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w4_structure_demo
{
    class Program
    {
        static void Main(string[] args)
        {

            BasicTools.credits();

            BasicTools.CreateBuffer(3);

            Console.WriteLine(" 7 + 6 = " + (7 + 6));

            BasicTools.pause();

        }
    }
}
