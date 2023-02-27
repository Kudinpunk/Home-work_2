 /* 
 Задайте массив заполненный случайными положительными трёхзначными числами. 
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 
*/

int [] New_Array (int size_array)
{
    int [] new_1_array = new int[size_array];
    for (int i = 0; i < size_array; i++)
    {
        new_1_array[i] = new Random().Next(100, 1000);
    }
    return new_1_array;
}

void Show_array(int [] new_array)
{
    for (int i = 0; i < new_array.Length; i++)
        Console.Write(new_array[i] + " ");
} 

int Count_arry_even(int [] end_array_1)
{
    int count = 0;
    for (int i = 0; i < end_array_1.Length; i++)
    {
        if (end_array_1[i] % 2 == 0)
            count += 1;
    }
    return count;
}

Console.Write("Input count of array elements: ");
int size_array = Convert.ToInt32(Console.ReadLine());
int [] end_array = New_Array(size_array);
Show_array(end_array);
Console.Write("-> ");
Console.Write(Count_arry_even(end_array));
