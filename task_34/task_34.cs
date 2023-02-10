// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] RandomArray()
{
    int[] arr = new int[new Random().Next(5, 20)];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] myArray = RandomArray();
int even = EvenNumbers(myArray);
string ARR = "[" + string.Join(", ", myArray) + "]";

System.Console.WriteLine($"В массиве {ARR} - {even} четных чисел.");