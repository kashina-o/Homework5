// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] CreateArray(int size)
 {
    return new int [size];
 }

void FillArray (int[] randomArray)
{
    for (int i = 0; i < randomArray.Length; i++) 
    {
        randomArray[i] = new Random().Next(99,1000);
        Console.Write(randomArray[i] + " ");
    }
}

int[] array = CreateArray(4);
FillArray(array);
