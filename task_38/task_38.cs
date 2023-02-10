// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] GenerateArray()
{
    double[] arr = new double[new Random().Next(5, 10)];
    for (int i = 0; i < arr.Length; i++)
    {
        Random rand = new Random();
        arr[i] = rand.Next(-10, 10) + Math.Round(rand.NextDouble(), 1);
    }
    return arr;
}

double NumberSubtraction(double[] array)
{
    return array.Max() - array.Min();
}


double[] myArray = GenerateArray();
double result = NumberSubtraction(myArray);
string Arr = "[" + string.Join(", ", myArray) + "]";

System.Console.WriteLine(
$"Разница между максимальным и минимальным элементами массива{Arr} равна {result}.");