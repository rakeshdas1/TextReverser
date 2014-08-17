using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextReverser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Text Reverser Ver 1.0");
            Console.WriteLine("Enter the text you would like to be reversed");
            Console.ReadLine();
            string Text = Console.ReadLine();
            //string Text = "Test text";
            char[] charArray = Text.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);
            Console.ReadLine();

        }
    }
}
