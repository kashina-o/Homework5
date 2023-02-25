// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[] CreateArrayOfRealNumbers(int size)
 {
    return new double [size];
 }

void FillArrayOfRealNumbers(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
            Console.WriteLine(array[i] + " ");
        }
}

void DifOfMaxMin(double[] numbers)
{
double min = numbers.Min();
double max = numbers.Max();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {max-min}");  
}

int size = Input("Введите длину массива: ");
double[] array = CreateArrayOfRealNumbers(size);
FillArrayOfRealNumbers(array);
DifOfMaxMin(array);