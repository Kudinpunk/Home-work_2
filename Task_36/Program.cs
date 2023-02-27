/* 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int [] New_array_create (int size_array)
{
    int [] new_2_array = new int[size_array];
    for (int i = 0; i < size_array; i++)
    {
        new_2_array[i] = new Random().Next(-99, 100);
    }
    return new_2_array;
}

void Show_array (int [] new_array)
{
    for (int i = 0; i < new_array.Length; i++)
    {
        Console.Write(new_array[i] + " ");
    }
}

int Result (int [] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        summ += array[i];
    }
    return summ;
}

Console.Write("Input count of array elements: ");
int user_size_array = Convert.ToInt32(Console.ReadLine());
int [] user_array = New_array_create(user_size_array);
Show_array(user_array);
Console.Write(" -> ");
Console.Write(Result(user_array));