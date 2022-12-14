using System;
using System.Text;

namespace Variant10
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите предложение: ");
            String s = new string(Console.ReadLine());
            string[] str = s.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder max = new StringBuilder("");
            int index = max.Length;
            for(int i = 0; i<str.Length; i++)
            {
                if(str[i].Length >= index)
                {
                    if (str[i].Length == index)
                    {
                        max.Append(" " + str[i]);
                        continue;
                    }
                    max.Clear();
                    max.Append(str[i]);
                    index = max.Length;
                }
            }
            Console.WriteLine("Самое длинное слово в предложении - " + max);
        }
    }
}
