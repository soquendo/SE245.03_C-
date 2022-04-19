using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w4_structure_demo
{
    public class BasicTools
    {
        /*in the hallway*/
        public static void credits()
        {
            Console.WriteLine("Created by Sebastian Oquendo");
            Console.WriteLine("Produced by by Sebastian Oquendo");
            Console.WriteLine("Published by Sebastian Oquendo");

            Console.WriteLine("\n\nPress any key to continue..");
            pause();

        }

        public static void pause()
        {
            Console.WriteLine("\n\nPress any key to continue..");
            Console.ReadKey();

        }

        public static void CreateBuffer(int lines)
        {
            for (int i = 1; i <= lines; i++)
            {
                Console.WriteLine("");
            }
        }
    }
}
