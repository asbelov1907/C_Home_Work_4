// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}



    int[] array = new int[8];
    Random randomaiser = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = randomaiser.Next(1,100);
}



PrintArray(array);
