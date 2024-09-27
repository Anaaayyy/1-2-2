using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Элементы между минимальным и максимальным----------------");
            Console.Write("Введите размер массива K: ");
            int K = int.Parse(Console.ReadLine()); // Вводит размер массива
            Console.Write("Введите диапазон [A, B): ");
            int A = int.Parse(Console.ReadLine()); // Вводит начало диапазона
            int B = int.Parse(Console.ReadLine()); // Вводит конец диапазона

            // Создаёт массив случайных чисел
            Random rand = new Random();
            int[] array = Enumerable.Range(0, K).Select(_ => rand.Next(A, B)).ToArray();

            // Находит индексы минимального и максимального элементов
            int minIndex = Array.IndexOf(array, array.Min());
            int maxIndex = Array.IndexOf(array, array.Max());

            Console.WriteLine("Массив: " + string.Join(", ", array));

            // Определяет диапазон индексов и выводит элементы между ними
            int start = Math.Min(minIndex, maxIndex);
            int end = Math.Max(minIndex, maxIndex);

            Console.WriteLine("Элементы между минимальным и максимальным: ");
            for (int i = start; i <= end; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadLine();



            Console.WriteLine("-----------------символьный массив ----------------");
            Console.Write("Введите размер массива K: ");
            int K5 = Convert.ToInt32(Console.ReadLine()); // Вводит размер массива

            Random rand5 = new Random();
            char[] alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray(); // Алфавит
            HashSet<char> vowels = new HashSet<char>("аеёиоуыэюя"); // Преобразует гласные в HashSet для эффективного поиска

            // Заполняет массив случайными буквами из алфавита
            char[] array5 = new char[K];
            for (int i = 0; i < K; i++)
            {
                array5[i] = alphabet[rand.Next(alphabet.Length)];
            }

            // Фильтрует массив, оставляя только согласные буквы
            List<char> consonants = new List<char>();
            foreach (char c in array5)
            {
                if (!vowels.Contains(c)) // Проверяет на принадлежность к гласным
                {
                    consonants.Add(c);
                }
            }

            // Выводит массивы
            Console.WriteLine("Исходный массив: " + string.Join(", ", array));
            Console.WriteLine("Массив согласных: " + string.Join(", ", consonants));
            Console.ReadLine();



            Console.WriteLine("-----------------вещественный массив из 10-ти элементов----------------");
            // Создаем массив из 10 элементов
            double[] array6 = new double[10];
            Random rand6 = new Random();

            // Заполняем массив случайными значениями в диапазоне [-10, 10)
            for (int i = 0; i < array6.Length; i++)
            {
                array6[i] = rand6.NextDouble() * 20 - 10; // [-10, 10)
            }

            // Выводим исходный массив
            Console.WriteLine("Исходный массив: " + string.Join(", ", array6));

            // Сортируем индексы массива по возрастанию значений элементов
            int[] sortedIndices = array6
                .Select((value, index) => new { Value = value, Index = index })
                .OrderBy(item => item.Value)
                .Select(item => item.Index)
                .ToArray();

            // Выводим массив индексов
            Console.WriteLine("Массив индексов (по возрастанию элементов): " + string.Join(", ", sortedIndices));

            // Выводим отсортированные элементы для проверки
            Console.WriteLine("Отсортированные элементы: " + string.Join(", ", sortedIndices.Select(i => array6[i])));
            Console.ReadLine();




        }
    }
}
