// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int size)
 {
    return new int [size];
 }

void FillArray (int[] randomArray)
{
    for (int i = 0; i < randomArray.Length; i++) 
    {
        randomArray[i] = new Random().Next(99,1000);
        Console.WriteLine(randomArray[i] + " ");
    }
}

void CountEvenNumbers(int[] array)
{
    int count = 0;
    for(int j = 0; j < array.Length; j++)
    {
        if (array[j] % 2 == 0)
        count++;
    }
    Console.Write($"Количество чётных чисел в массиве = {count}");
}

int[] array = CreateArray(Input("Введите размер массива: "));
FillArray(array);
CountEvenNumbers(array);
