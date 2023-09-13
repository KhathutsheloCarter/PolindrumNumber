using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            string test = Console.ReadLine();

            if (Check(test) == true)
            {

                Console.WriteLine(test + " Is a palindrom word ");
            }
            else {
                Console.WriteLine(test + " Is not a palindrom word ");
            }





            if (Check(test) == true)
            {

                Console.WriteLine(test + " Is a palindrom number ");
            }
            else
            {
                Console.WriteLine(test + " Is not a palindrom number ");
            }

            Console.Read();
        }

        static bool Check(string test) {

            bool Word = true;

            for (int i =0; i<test.Length-1;i++) {

                int ReverseWord = test.Length - 1 - i;

                if (test[i] != test[ReverseWord])
                {
                    return Word = false;
                }
            }
            return Word = true;


        }
       
    }
}
