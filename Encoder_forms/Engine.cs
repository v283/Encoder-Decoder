using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder_forms
{
    public static class Engine
    {
        public static string EncoderEngine(string text)
        {
            string result = "|";
            int code = 0;
            string temp = " ";
            for (int i = 0; i < text.Length; i++)
            {
                temp = text[i].ToString();
                for (int j = 0; j < Table1.table.Length; j++)
                {
                    if (Table1.table[j] == temp)
                    {
                        code = j;
                    }
                }
                result = result + code + "|";

            }

            return result;
        }

        public static string DecoderEngine(string text)
        {
            string[] text_array = new string[1];
            string result = "";
            int counter_text_array = 0;

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] != '|')
                {
                    result += text[i];
                }
                else
                {
                    text_array[counter_text_array] = result;
                    result = "";
                    if (i < text.Length)
                    {
                        string[] newArray = new string[text_array.Length + 1];
                        for (int j = 0; j < text_array.Length; j++)
                        {
                            newArray[j] = text_array[j];
                        }
                        text_array = newArray;

                    }
                    counter_text_array += 1;
                }
            }


            for (int i = 0; i < text_array.Length; i++)
            {
                for (int j = 0; j < Table1.table.Length; j++)
                {
                    if (text_array[i] == j.ToString())
                    {
                        result += Table1.table[j];
                    }

                }

            }
            return result;
        }

    }
}
