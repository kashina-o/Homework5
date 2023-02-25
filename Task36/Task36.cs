// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int size)
 {
    return new int [size];
 }

void FillArray (int[] randomArray, int min, int max)
{
    for (int i = 0; i < randomArray.Length; i++) 
    {
        randomArray[i] = new Random().Next(min,max + 1);
        Console.WriteLine(randomArray[i] + " ");
    }
}

void SumOfOddNumbers(int[] array)
{
    int count = 0;
    for(int j = 0; j < array.Length; j++)
    {
        if (j % 2 != 0 && j != 0)
        count = count + array[j];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {count}");
}


int size = Input("Введите длину массива: ");
int min = Input("Введите минимальное значение массива: ");
int max = Input("Введите максимальное значение массива: ");
int[] array = CreateArray(size);
FillArray(array, min, max);
SumOfOddNumbers(array);