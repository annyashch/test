using System;
using System.IO;
using System.Collections.Generic;

namespace lab_bp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Стeк, считанный из файла:");
            StreamReader text = new StreamReader("C:\\Users\\yasch\\OneDrive\\Рабочий стол\\безп прогр\\lab_bp\\Laba.7\\Laba.7_4_text.txt");
            Stack<int> stack = new Stack<int>();
            while (!text.EndOfStream)
            {
                int tmp = Convert.ToInt32(text.ReadLine());
                stack.Push(tmp);
                Console.Write(tmp+" ");
            }
            StreamWriter write = new StreamWriter("C:\\Users\\yasch\\OneDrive\\Рабочий стол\\безп прогр\\lab_bp\\Laba.7\\Laba.7_4_write.txt", false);
            Console.WriteLine("\nСтек в обратном порядке (записан в другой файл):");
            foreach( var i in stack)
            {
                write.WriteLine(i);
                Console.Write(i+" ");
            }
            write.Close();
        }
    }
}