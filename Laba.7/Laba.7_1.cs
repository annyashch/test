using System;
using System.IO;

namespace lab_bp
{
    class Program
    {
        static void Main()
        {
            string text;
            int counrOpen = 0, counrClose = 0;
            StreamReader read = new StreamReader("C:\\Users\\yasch\\OneDrive\\Рабочий стол\\безп прогр\\lab_bp\\Laba.7\\Laba7_1_text.txt");
            text = Convert.ToString(read.ReadToEnd());
            Console.WriteLine("Срока, считанная из файла:");
            Console.WriteLine(text);
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    counrOpen++;
                }
                else if (text[i] == ')')
                {
                    counrClose++;
                } 
            }
            if (counrOpen == counrClose)
            {
                Console.WriteLine("Количество открытых скобок равно количеству закрытых");
            }
            else
            {
                Console.WriteLine("В тексте разное количество открытых и закрытых скобок");
            }
        }
    }
}


    
