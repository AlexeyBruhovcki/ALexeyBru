// Алгоритмы сортировки
// Задание 1
void BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] < arr[j])
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}
void InsertionSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int key = arr[i];
        int j = i - 1;
        while (j >= 0 && arr[j] < key)
        {
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = key;
    }
}

int[] mas = new int[5];
Random rnd = new Random();
for(int i=0; i<mas.Length; i++)
{
    mas[i] = rnd.Next(1,100);
    Console.Write(mas[i]+" ");
}
Console.WriteLine();
BubbleSort(mas);
for (int i = 0; i < mas.Length; i++)
{
    Console.Write(mas[i] + " ");
}
Console.WriteLine();
InsertionSort(mas);
for (int i = 0; i < mas.Length; i++)
{
    Console.Write(mas[i] + " ");
}

//Задание 2
Console.WriteLine();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = rnd.Next(1, 100);
    Console.Write(mas[i] + " ");
}
void EvenSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] % 2 == 0)
            {
                arr[i] = arr[i];
            }
            else if (arr[j]%2==0)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}
EvenSort(mas);
Console.WriteLine();
for (int i = 0; i < mas.Length; i++)
{
    Console.Write(mas[i] + " ");
}
