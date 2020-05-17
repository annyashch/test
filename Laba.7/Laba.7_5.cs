using System;
using System.IO;
using System.Collections.Generic;

namespace lab_bp
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            List<int> list = new List<int>();
            int N=1990, min=200, max=400;
            Console.WriteLine("Размерность списка = "+N);
            Console.WriteLine("Диапазон = "+min+" - "+max+"\n");
            for (int i = 0; i < N; i++)
            {
                list.Add(random.Next(min,max));
            }
            Console.WriteLine("Отсортированный список:");
            list.Sort();
            foreach(int i in list)
            {
                Console.Write(i+" ");
            }
            int var = 17;
            Console.WriteLine("\nВариант - "+var);
            list[var]=var;
            Console.WriteLine($"Число {var}, добавлено на позицию {var}");
            int num1 = random.Next(0,1017);
            Console.WriteLine($"Число 1 (диапазон - 0 - 1017) = {num1}");
            for (int i = 0; i < N; i++)
            {
                if(list[i]==num1)
                {
                    Console.WriteLine($"Это число находиться на позиции {i}");
                }
            }
            int num2 = random.Next(0,N);
            Console.WriteLine($"Число 2 (диапазон - 0 - {N}) = {num2}");
            list.Remove(num2);
            Console.WriteLine("Число 2 удалено");
            foreach(int i in list)
            {
                Console.Write(i+" ");
            }
            list.Clear();
            Console.WriteLine("\nСписок пуст");

        }
    }
}