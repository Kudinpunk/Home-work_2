/* 
Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива. Math.Min Math.Max не использовать
[3.0 7.1 22.5 2.7 78.8] -> 76.1
*/ 

double [] Create_array (int size_array)
{
    double [] new_array = new double[size_array];
    for (int i = 0; i < size_array; i++)
    {
        new_array[i] = Math.Round((new Random().NextDouble() * 100), 1);
    }
    return new_array;
}

void Show_array (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    { 
        Console.Write(array[i] + " ");
    }
}

double Max_number (double [] user_array)
{
    double max = user_array[0];
    for (int i = 0; i < user_array.Length; i++)
    {
        if (user_array[i] > max)
            max = user_array[i];
    }
    return max;   
}

double Min_number (double [] user_array)
{
    double min = user_array[0];
    for (int i = 0; i < user_array.Length; i++)
    {
        if (user_array[i] < min)
            min = user_array[i];
    }
    return min;   
}

Console.Write("Input count of array elements: ");
int user_size_array = Convert.ToInt32(Console.ReadLine());

double [] new_user_array = Create_array(user_size_array);
Show_array(new_user_array);
Console.Write("-> ");
Console.WriteLine(Max_number(new_user_array) - Min_number(new_user_array));
