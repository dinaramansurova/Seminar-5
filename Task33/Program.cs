// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10); // [-9, 9]
}


string ReleaseArray(int[] array, int number)
{
    foreach (int element in array)
    {
        if (element == number)
            return "yes";
    }
    return "no";
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.Write("Введите число, которое Вы ищите внутри массива: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ReleaseArray(array, number));