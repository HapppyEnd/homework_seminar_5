// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] RandomArray()
{
    int[] arr = new int[new Random().Next(5, 10)];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 30);
    }
    return arr;
}

int SumOddIndexNum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            result += array[i];
        }
    }
    return result;
}

int[] myArray = RandomArray();
int sumNumber = SumOddIndexNum(myArray);
string Arr = "[" + string.Join(", ", myArray) + "]";

System.Console.WriteLine(
$"Сумма чисел, стоящих на нечетных индексах в массиве{Arr} равна {sumNumber}");