using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martyr2s_Mega_Project
{
    class VowelCount
    {
        static void Main(string[] args)
        {
            string message = "";
            int aCount = 0, eCount = 0, iCount = 0, oCount = 0, uCount = 0;
            
            message = System.Console.ReadLine();

            for (int i = 0; i < message.Length - 1; i++)
            {
                if(message[i].Equals('a'))
                    aCount++;
                else if(message[i].Equals('e'))
                    eCount++;
                else if(message[i].Equals('i'))
                    iCount++;
                else if(message[i].Equals('o'))
                    oCount++;
                else if(message[i].Equals('u'))
                    uCount++;
            }

            System.Console.WriteLine("A: {0}, E: {1}, I: {2}, O: {3}, U: {4}", aCount, eCount, iCount, oCount, uCount);
            System.Console.ReadLine();
        }
    }
}
