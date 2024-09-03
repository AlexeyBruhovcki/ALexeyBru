using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme33Lesson1
{
    internal class Operations
    {
        public List<string>? ListStrings { get; set; } = new();

        public Operations()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите " + (i + 1 )+ " строку: ");
                ListStrings.Add(Console.ReadLine()!);
            }
        }
        public void Print()
        {
            for (int i = 0; i < ListStrings.Count; i++)
            {
                Console.WriteLine("№" + i + " " + ListStrings[i]);
            }
        }
        public void AddValue()
        {
            Console.Write("Введите значение для добавления:");
            string value= Console.ReadLine();
            ListStrings.Add(value);
        }
        public void DeleteByIndex()
        {
            Console.Write("Введите индекс элемента: ");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            try
            {
                ListStrings.RemoveAt(n);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void SearchByValue()
        {
            Console.Write("Введите значение для поиска: ");
            string? value = Console.ReadLine();
            if (ListStrings.IndexOf(value)!=-1)
            {
                Console.WriteLine("Элемент найден, индекс эелемента "+ (ListStrings.IndexOf(value)));
            }
            else Console.WriteLine("элемент не найден");
        }
        public void Clear()
        {
            ListStrings.Clear();
        }
        public void Sort() => ListStrings.Sort();
        public void FindAllValues()
        {
            Console.Write("Введите значение для поиска: ");
            string value= Console.ReadLine();
            int count = 0;
            int[] mas= new int[count];
            for (int i = 0; i < ListStrings.Count(); i++)
            {
                if  (ListStrings[i] == value) 
                {   count++;
                    Array.Resize(ref mas, count);
                    mas[count - 1] = i; 
                }
            }
            if (count == 0) Console.WriteLine("Элемент не найден");
            else
            {
                for(int i = 0; i < mas.Length; i++)
                {
                    Console.Write(mas[i]+" ");
                }
            }
        }
        public void Summ()
        {
            double sum= 0;
            foreach(string s in ListStrings)
            {
                try
                {
                    sum += double.Parse(s);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public void SaveToFile()
        {
            Console.Write("Введите путь: ");
            string path = Console.ReadLine();
            try
            {
                File.WriteAllLines(path, ListStrings);
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            
        }
        public void LoadFromFile()
        {
            Console.Write("Введите путь: ");
            string path = Console.ReadLine();
            try
            {
                if (File.Exists(path))
                {
                    ListStrings = new List<string>(File.ReadAllLines(path));
                }
                else
                {
                    Console.WriteLine("Файл не существует");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
