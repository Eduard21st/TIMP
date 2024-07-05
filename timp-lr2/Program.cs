using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace timp_lr2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool Check(int key, int[] mas, int kol)
            {
                for (int i = 0; i < kol; i++)
                    if (mas[i] == key)
                        return false;
                return true;
            }
            int kol;
            Console.WriteLine("Введите кол-во городов");
            kol = int.Parse(Console.ReadLine());
            int[,] arr = new int[kol, kol];
            int k = 0;
            for (int i = 0; i < kol; i++)
            {
                for (int j = k; j < kol; j++)
                {
                    if (i == j)
                        arr[i, j] = 0;
                    else
                    {
                        Console.WriteLine($"Путь от города {i+1} до города {j+1}");
                        arr[i, j] = int.Parse(Console.ReadLine());
                        arr[j, i] = arr[i, j];
                    }
                }
                k++;
            }
            Console.WriteLine("\nМатрица:\n");
            for (int i = 0; i < kol; i++)
            {
                for (int j = 0; j < kol; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }

            int[] path = new int[kol];
            for (int i = 0; i < kol; i++)    
                path[i] = -1;

            Console.WriteLine("Введите стартовый город");
            int start = int.Parse(Console.ReadLine());
            path[0] = start;
            int now = start;
            int path_len = 0;

            //k = 0;
            for (int i = 1; i < kol; i++)
            {     // i - индекс по маршруту и количество переходов, не считая возврата в стартовый город
                int min = 10000,min_town=10000;
                for (int j = 0; j < kol; j++)
                {
                    if (Check(j, path, kol) && arr[now,j] < min && arr[now,j] > 0)
                    {  //Нахождение минимума
                        min = arr[now,j];      // запомнили текущий минимум
                        min_town = j;           // запомнили номер города для текущего минимума
                    }
                }
                // а здесь min - действительный минимум и min_town - номер города с минимальным расстоянием от текущего
                path_len += min;            // добавляем к общему пути
                path[i] = min_town;    // добавляем город в маршрут
                Console.WriteLine($"{now} -> {path[i]} расстояние - {min}, путь - {path_len}");
               // cout << setw(2) << now << " -> " << setw(2) << path[i] << "   (расстояние " << min << ", путь " << path << ")" << endl;
                now = path[i];
            }
            path_len += arr[start,now];
            Console.WriteLine($"{now} -> {start} расстояние - {arr[start,now]}, путь - {path_len}");
            Console.WriteLine($"Общая длина пути: {path_len}");
            //cout << setw(2) << now << " -> " << setw(2) << start << "   (расстояние " << arr[start][now] << ", путь " << path << ")" << endl;
            //cout << "Общая длина пройденного пути: " << path << endl;
        }
    }
}
