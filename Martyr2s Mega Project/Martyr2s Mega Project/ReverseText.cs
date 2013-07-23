using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martyr2s_Mega_Project
{
    class ReverseText
    {
        static void Main(string[] args)
        {
            string message = "";
            string reversedMessage = "";

            message = System.Console.ReadLine();

            for (int i = message.Length-1; i >= 0; i--)
            {
                reversedMessage += message[i];
            }

            System.Console.WriteLine(reversedMessage);

            //Wait to exit
            System.Console.ReadLine();
        }
    }
}
