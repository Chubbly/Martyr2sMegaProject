using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martyr2s_Mega_Project
{
    class PalindromeCheck
    {
        static void Main(string[] args)
        {
            string message = "";
            bool isPalindrome = true;

            message = System.Console.ReadLine();
            for (int i = 0; i <= message.Length / 2; i++)
            {
                if (message[i] != message[message.Length-1 - i])
                    isPalindrome = false;
            }

            System.Console.WriteLine("Is Palindrome?: {0}", isPalindrome);

            System.Console.ReadLine();
        }
    }
}
