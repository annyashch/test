using System;
using System.IO;
using System.Linq;

namespace lab_bp
{
    class Program
    {
        static void Show(string line)
        {
            Console.WriteLine(line);
        }
        static string Zamena(string line)
        {
            line = line.Replace(',',' ');
            line = line.Replace('.',' ');
            line = line.Replace('*',' ');
            line = line.Replace('(',' ');
            line = line.Replace(')',' ');         
            return line;
        }
        static void ReadFile(string line, Action<string> action)
        {
            action(line);
        }
        static string ReadFile(string line, Func<string,string> func)
        {
            return func(line);
        }
        static void Main(string[] args)
        {
            StreamReader read = new StreamReader("C:\\Users\\yasch\\OneDrive\\Рабочий стол\\безп прогр\\lab_bp\\Laba.8\\Laba.8_2_text.txt");
            string text = Convert.ToString(read.ReadToEnd());
            Console.WriteLine("Первоначальная строка:");
            Action<string> action = Show;
            ReadFile(text,action);
            Console.WriteLine("Строка после замены:");
            Func<string,string> func = Zamena;
            string res = ReadFile(text, func);
            ReadFile(res,action);
        }
    }
}