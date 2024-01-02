// Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
//  выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
using System;

namespace kontrol
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] array = new string[] { "Happy", "new", "44", "24", "year", "5", "tru" };
            
            string[] array2 = CreateStringArray(array);
            Console.WriteLine(Print(array2));
        }
        
        static int CountSimvolArray(string[] array)
        {
            int count = 0;
            foreach (string element in array)
            {
                if (element.Length <= 3)
                {
                    count++;
                }
            }
            return count;
        }
        static string[] CreateStringArray(string [] array)
        {
            int count = CountSimvolArray(array);
            string[] result = new string[count];
            int index = 0;
            foreach (string element in array)
            {
                if (element.Length <= 3)
                {
                    result[index] = element;
                    index++;
                }
            }
            return result;
        }
        public static string Print(string[] array)
        {
            string result = string.Join(", ", array);
            return result;
        }
    }
}
