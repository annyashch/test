using System;
using System.IO;
using System.Collections.Generic;

namespace lab_bp
{
    class People
    {
        public string Name
        {
            set;
            get;
        }
        public string Surname
        {
            set;
            get;
        }        
        public int Vozrast
        {
            set;
            get;
        }
        public int Ves
        {
            set;
            get;
        }
        public People(string name, string surname, int let, int ves)
        {
            Name=name;
            Surname=surname;
            Vozrast=let;
            Ves=ves;
        }
        public void Print()
        {
            Console.WriteLine("Имя - "+Name);
            Console.WriteLine("Фамилия - "+Surname);
            Console.WriteLine("Возраст - "+Vozrast);
            Console.WriteLine("Вес - "+Ves);
        }
    }
    class Comparer : IComparer<People>
        {
            public int Compare(People person1, People person2)
            {
                if (person1.Vozrast > person2.Vozrast)
                {
                    return 1;
                }
                else if (person1.Vozrast < person2.Vozrast)           
                {
                    return -1;
                }
                else
                 {
                    return 0;
                 }   
            }
        }
    class Program
    {
        static void Main()
        {
            List<People> people = new List<People>();
            string text;
            StreamReader read = new StreamReader("C:\\Users\\yasch\\OneDrive\\Рабочий стол\\безп прогр\\lab_bp\\Laba.7\\Laba.7_2_text.txt");
            while ((text = read.ReadLine()) != null)
            {
                string[] split = text.Split(' ');
                string name = split[0];
                string surname = split[1];
                int vozrast = Convert.ToInt32(split[2]);
                int ves = Convert.ToInt32(split[3]);
                people.Add(new People(name, surname, vozrast, ves));
            }
            Console.WriteLine("Общий список людей");
            foreach (People i in people)
            {
                    i.Print();
            }
            people.Sort(new Comparer());
            Console.WriteLine("\nСписок людей, отсортированых по возрасту");
            foreach (People i in people)
            {
                i.Print();
            }
        }
    }
}


    
