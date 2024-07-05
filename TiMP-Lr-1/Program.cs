using System;
using System.Diagnostics;

namespace TiMP_Lr_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] len_arr = new int[] { 1, 2, 3, 4, 5, 10, 15, 20, 25, 30, 50, 75, 100, 250, 500 };
            Random rand = new Random();

            Sort sort = new Sort();
            Stopwatch time1 = new Stopwatch();
            Console.WriteLine("БЫСТРАЯ СОРТИРОВКА\n");
            for (int i = 0; i < len_arr.Length; i++)
            {
                time1.Start();
                for (int j = 0; j < 1000; j++)
                {
                    int[] arr = new int[len_arr[i]];
                    for (int k = 0; k < arr.Length; k++)
                    {
                        arr[k] = rand.Next(-1000, 1000);
                    }
                    sort.Qsort(arr, 0, arr.Length - 1);
                }
                time1.Stop();
                double time = time1.Elapsed.TotalMilliseconds;
                Console.Write($"Размер: {len_arr[i]} | Кол-во сравнений: {sort.Comp / 1000} | " +
                    $"Кол-во перестановок: {sort.Perm / 1000} | Всего операций: {sort.Comp / 1000 + sort.Perm / 1000} | " +
                    $"Время вып-я: {Math.Round(time / 1000, 5)}\n");

                sort.Comp = 0;
                sort.Perm = 0;
            }
            Console.WriteLine("\n\n");


            Stopwatch time2 = new Stopwatch();
            Console.WriteLine("ПИРАМИДАЛЬНАЯ СОРТИРОВКА\n");
            for (int i = 0; i < len_arr.Length; i++)
            {
                time2.Start();
                for (int j = 0; j < 1000; j++)
                {
                    int[] arr = new int[len_arr[i]];
                    for (int k = 0; k < arr.Length; k++)
                    {
                        arr[k] = rand.Next(-1000, 1000);
                    }
                    sort.Heapsort(arr, arr.Length);
                }
                time2.Stop();
                double time = time2.Elapsed.TotalMilliseconds;
                Console.Write($"Размер: {len_arr[i]} | Кол-во сравнений: {sort.Comp / 1000} | " +
                    $"Кол-во перестановок: {sort.Perm / 1000} | Всего операций: {sort.Comp / 1000 + sort.Perm / 1000} | " +
                    $"Время вып-я: {Math.Round(time / 1000, 5)}\n");
                sort.Comp = 0;
                sort.Perm = 0;
            }
            Console.WriteLine("\n\n");


            Stopwatch time3 = new Stopwatch();
            Console.WriteLine("СОРТИРОВКА РАСЧЁСКОЙ\n");
            for (int i = 0; i < len_arr.Length; i++)
            {
                time3.Start();
                for (int j = 0; j < 1000; j++)
                {
                    int[] arr = new int[len_arr[i]];
                    for (int k = 0; k < arr.Length; k++)
                    {
                        arr[k] = rand.Next(-1000, 1000);
                    }
                    sort.Comb(arr, arr.Length);
                }
                time3.Stop();
                double time = time3.Elapsed.TotalMilliseconds;
                Console.Write($"Размер: {len_arr[i]} | Кол-во сравнений: {sort.Comp / 1000} | " +
                    $"Кол-во перестановок: {sort.Perm / 1000} | Всего операций: {sort.Comp / 1000 + sort.Perm / 1000} | " +
                    $"Время вып-я: {Math.Round(time / 1000, 5)}\n");

                sort.Comp = 0;
                sort.Perm = 0;
            }
            Console.WriteLine("\n\n");


            Stopwatch time4 = new Stopwatch();
            Console.WriteLine("СОРТИРОВКА ШЕЛЛА\n");
            for (int i = 0; i < len_arr.Length; i++)
            {
                time4.Start();
                for (int j = 0; j < 1000; j++)
                {
                    int[] arr = new int[len_arr[i]];
                    for (int k = 0; k < arr.Length; k++)
                    {
                        arr[k] = rand.Next(-1000, 1000);
                    }
                    sort.Shell(arr, arr.Length);
                }
                time4.Stop();
                double time = time4.Elapsed.TotalMilliseconds;
                Console.Write($"Размер: {len_arr[i]} | Кол-во сравнений: {sort.Comp / 1000} | " +
                    $"Кол-во перестановок: {sort.Perm / 1000} | Всего операций: {sort.Comp / 1000 + sort.Perm / 1000} | " +
                    $"Время вып-я: {Math.Round(time / 1000, 5)}\n");

                sort.Comp = 0;
                sort.Perm = 0;
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("ЛУЧШИЙ И ХУДШИЙ РЕЗУЛЬТАТЫ:");

            Stopwatch time5 = new Stopwatch();
            Console.WriteLine("БЫСТРАЯ СОРТИРОВКА - 10 массивов\n");
            for (int i = 0; i < 10; i++)
            {
                time5.Start();

                for (int j = 0; j < 1000; j++)
                {
                    int[] arr = new int[100];
                    for (int k = 0; k < arr.Length; k++)
                    {
                        arr[k] = rand.Next(-1000, 1000);
                    }
                    sort.Qsort(arr, 0, arr.Length - 1);
                }
                time5.Stop();
                double time = time5.Elapsed.TotalMilliseconds;
                Console.Write($"Массив: {i+1} | Всего операций: {sort.Comp / 1000 + sort.Perm / 1000} | " +
                    $"Время вып-я: {Math.Round(time / 1000, 5)}\n");

                sort.Comp = 0;
                sort.Perm = 0;
            }
            Console.WriteLine("\n\n");

            Stopwatch time6 = new Stopwatch();
            Console.WriteLine("ПИРАМИДАЛЬНАЯ СОРТИРОВКА - 10 массивов\n");
            for (int i = 0; i < 10; i++)
            {
                time6.Start();

                for (int j = 0; j < 1000; j++)
                {
                    int[] arr = new int[100];
                    for (int k = 0; k < arr.Length; k++)
                    {
                        arr[k] = rand.Next(-1000, 1000);
                    }
                    sort.Heapsort(arr, arr.Length);
                }
                time6.Stop();
                double time = time6.Elapsed.TotalMilliseconds;
                Console.Write($"Массив: {i + 1} | Всего операций: {sort.Comp / 1000 + sort.Perm / 1000} | " +
                    $"Время вып-я: {Math.Round(time / 1000, 5)}\n");

                sort.Comp = 0;
                sort.Perm = 0;
            }
            Console.WriteLine("\n\n");

            Stopwatch time7 = new Stopwatch();
            Console.WriteLine("СОРТИРОВКА РАСЧЁСКОЙ - 10 массивов\n");
            for (int i = 0; i < 10; i++)
            {
                time7.Start();

                for (int j = 0; j < 1000; j++)
                {
                    int[] arr = new int[100];
                    for (int k = 0; k < arr.Length; k++)
                    {
                        arr[k] = rand.Next(-1000, 1000);
                    }
                    sort.Comb(arr, arr.Length);
                }
                time7.Stop();
                double time = time7.Elapsed.TotalMilliseconds;
                Console.Write($"Массив: {i + 1} | Всего операций: {sort.Comp / 1000 + sort.Perm / 1000} | " +
                    $"Время вып-я: {Math.Round(time / 1000, 5)}\n");

                sort.Comp = 0;
                sort.Perm = 0;
            }
            Console.WriteLine("\n\n");

            Stopwatch time8 = new Stopwatch();
            Console.WriteLine("СОРТИРОВКА ШЕЛЛА- 10 массивов\n");
            for (int i = 0; i < 10; i++)
            {
                time8.Start();

                for (int j = 0; j < 1000; j++)
                {
                    int[] arr = new int[100];
                    for (int k = 0; k < arr.Length; k++)
                    {
                        arr[k] = rand.Next(-1000, 1000);
                    }
                    sort.Shell(arr, arr.Length);
                }
                time8.Stop();
                double time = time8.Elapsed.TotalMilliseconds;
                Console.Write($"Массив: {i + 1} | Всего операций: {sort.Comp / 1000 + sort.Perm / 1000} | " +
                    $"Время вып-я: {Math.Round(time / 1000, 5)}\n");

                sort.Comp = 0;
                sort.Perm = 0;
            }
            Console.WriteLine("\n\n");
        }
    }
}