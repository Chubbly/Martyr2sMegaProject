using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martyr2s_Mega_Project
{
    class WordCount
    {
        static void Main(string[] args)
        {
            string text = "";
            string[] splitText;
            List<string> wordDic = new List<string>();
            List<int> wordNum = new List<int>();

            text = System.IO.File.ReadAllText(@"C:\Users\Adrian\Documents\GitHub\Martyr2sMegaProject\Martyr2s Mega Project\Martyr2s Mega Project\Reference files\textdoco.txt");

            splitText = text.Split(' ');
            

            foreach (string s in splitText)
            {
                int place = wordDic.FindIndex(e => e == s);

                if (place == -1)
                {
                    wordDic.Add(s);
                    wordNum.Add(1);
                }
                else
                    wordNum[place]++;
            }

            for (int i = 0; i < wordDic.Count - 1; i++)
            {
                System.Console.WriteLine("Word: {0}, Count: {1}", wordDic[i], wordNum[i]);
            }
            
            System.Console.ReadKey();
        }
    }
}
