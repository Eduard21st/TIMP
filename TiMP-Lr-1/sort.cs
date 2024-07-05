namespace TiMP_Lr_1
{
    class Sort
    {
        private int comp;
        private int perm;

        public int Comp { get => comp; set => comp = value; }
        public int Perm { get => perm; set => perm = value; }

       
        public void Qsort(int[] arr, int left, int right)
        {
            int pivot;
            int l_hold = left; //левая граница
            int r_hold = right; // правая граница
            pivot = arr[left];
            while (left < right) // пока границы не сомкнутся
            {
                while ((arr[right] >= pivot) && (left < right))
                {
                    right--;
                    comp++;
                }// сдвигаем правую границу пока элемент [right] больше [pivot]
                if (left != right) // если границы не сомкнулись
                {
                    arr[left] = arr[right]; // перемещаем элемент [right] на место разрешающего
                    left++; // сдвигаем левую границу вправо
                    comp++;
                    perm++;
                }
                while ((arr[left] <= pivot) && (left < right))
                { 
                    left++;
                    comp++;
                }// сдвигаем левую границу пока элемент [left] меньше [pivot]
                if (left != right) // если границы не сомкнулись
                {
                    arr[right] = arr[left]; // перемещаем элемент [left] на место [right]
                    right--; // сдвигаем правую границу влево
                    comp++;
                    perm++;
                }
            }
            arr[left] = pivot; // ставим разрешающий элемент на место
            pivot = left;
            left = l_hold;
            right = r_hold;
            if (left < pivot) // Рекурсивно вызываем сортировку для левой и правой части массива
            {
                comp++;
                Qsort(arr, left, pivot - 1);
            }
            if (right > pivot)
            {
                comp++;
                Qsort(arr, pivot + 1, right);
            }

        }

        void Heapify(int[] arr, int root, int bottom)
        {
            int maxChild;
            bool done = false;
            while ((root * 2 + 1 <= bottom) && (!done))
            {
                if (root * 2 + 2 <= bottom)
                {
                    if (arr[root * 2 + 2] > arr[root * 2 + 1])
                    {
                        maxChild = root * 2 + 2;
                        comp++;
                    }
                    else
                    {
                        maxChild = root * 2 + 1;
                        comp++;
                    }
                    comp++;
                }
                else
                {
                    maxChild = root * 2 + 1;
                    comp++;
                }
                if (arr[root] < arr[maxChild])
                {
                    int temp = arr[root];
                    arr[root] = arr[maxChild];
                    arr[maxChild] = temp;
                    root = maxChild;
                    comp++;
                    perm++;
                }
                else
                {
                    done = true;
                    comp++;
                }
                comp++;
            }
        }

       
        public void Heapsort(int[] arr, int arr_len)
        {
            for (int i = (arr_len / 2) - 1; i >= 0; i--)
            {
                comp++;
                Heapify(arr, i, arr_len - 1);
            }
            for (int i = arr_len - 1; i >= 1; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                perm++;
                comp++;
                Heapify(arr, 0, i - 1);
            }
        }

        public void Comb(int[] arr, int arr_len)
        {
            double factor = 1.247; //фактор уменьшения
            int step = arr_len - 1; //шаг сортировки
            int tmp; //переменная для обмена элементов
                     //когда step = 1, выполняется последняя итерация цикла (эквивалентна одному проходу
           // сортировки пузырьком)
            while (step >= 1)
            {
                for (int i = 0; i + step < arr_len; i++)
                {
                    if (arr[i] > arr[i + step])
                    {
                        tmp = arr[i];
                        arr[i] = arr[i + step];
                        arr[i + step] = tmp;
                        perm++; //увеличим количество перестановок
                    }
                    comp++; //увеличим количество сравнений (if)
                }
                step = (int)(step / factor); //уменьшим шаг сортировки
                comp++; //увеличим количество сравнений (while)
            }
            comp++; //увеличим количество сравнений (while, когда мы в него не зашли)
        }

        public void Shell(int[] arr, int size)
        {
            int tmp;
            for (int s = size / 2; s > 0; s /= 2)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = i + s; j < size; j += s)
                    {
                        if (arr[i] > arr[j])
                        {
                            tmp = arr[j];
                            arr[j] = arr[i];
                            arr[i] = tmp;
                            perm++;
                        }
                        comp++;
                    }
                }
            }
            comp++; //до того, как войти в цикл while
        }

    }
}
