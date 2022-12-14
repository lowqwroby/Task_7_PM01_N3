using System;

namespace Variant10
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Введите строку: ");
                String s = new String(Console.ReadLine());
                Console.Write("Введите первую подстроку: ");
                String substr1 = new String(Console.ReadLine());
                Console.Write("Введите вторую подстроку: ");
                String substr2 = new String(Console.ReadLine());
                Console.WriteLine("Исходная строка: " + s);
                String news = s.Replace(substr1, substr2);
                if(s == news)
                {
                    Console.WriteLine("Строка не была изменена");
                    return;
                }
                Console.WriteLine("Измененная строка: " + news);
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверно введены значения");
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так");
            }
            

        }
    }
}
