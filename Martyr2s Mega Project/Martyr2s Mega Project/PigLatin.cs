using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martyr2s_Mega_Project
{
    class PigLatin
    {
        static void Main(string[] args)
        {
            string text = "";
            string[] splitText;
            List<string> pigLatined = new List<string>();

            text = System.Console.ReadLine();

            splitText = text.Split(' ');

            foreach (string s in splitText)
            {
                switch (s[0])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        pigLatined.Add(s + "way");
                        break;
                    default:
                        pigLatined.Add(s.Substring(1) + "ay");
                        break;                        
                }
            }

            foreach (string s in pigLatined)
                System.Console.Write(s + ' ');

            System.Console.ReadKey();
        }
    }
}
