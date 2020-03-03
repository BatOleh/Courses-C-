using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Домашнє завдання - сортування методом "Бульбашки"

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];  //Об'явлення масиву
            Random random = new Random();  //Об'явлення рандому

            Console.Write("Array = ");

            for (int i = 0; i < array.Length; i++) //Заповнення масиву
            {
                array[i] = random.Next(1, 99);  
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            int temp = 0;

            for (int i =0; i < array.Length; i++) //Сортування масиву
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])    // Від знаку > або < залежить тип сортування(зростання/спадання)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine();
            Console.Write("Sorted Array = ");

            for (int i = 0; i < array.Length; i++) //Виведення відсортованого масиву
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
