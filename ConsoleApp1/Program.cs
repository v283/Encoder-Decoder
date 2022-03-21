using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(" \"\" ");
            string symbols = Console.ReadLine().ToUpper();
            string resualt = "";
            for (int i = 0; i < symbols.Length; i++)
            {
                if(symbols[i] == ' ')
                {
                    resualt += symbols[i];
                }
                else if (symbols[i] == ',')
                {
                    resualt += symbols[i];
                }
                else
                {
                    string t = "\"";
                    resualt += t + symbols[i] + t;
                    
                }

            }
            Console.WriteLine(resualt);

        }
    }
}
