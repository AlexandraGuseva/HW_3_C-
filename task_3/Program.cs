// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Ввод с консоли “введите количество элементов массива”, “Введите минимальный порог случайных значений”,
// “Введите максимальный порог случайных значений”

// Variables

// Input
Console.Write("Please, input array length: ");
int input_array_length = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input random length: ");
int input_random_length = Convert.ToInt32(Console.ReadLine());
// Methods

int[] input_array = new int[input_array_length];
System.Console.WriteLine();
System.Console.WriteLine($"Your random array:");
Console.Write("[");
for (int i = 0; i < input_array.Length; i++)
{
    input_array[i] = new Random().Next(0, input_random_length);
    Console.Write($" {Method(i)}, ");
}
Console.Write("]");

int Method(int a)
{
    return input_array[a];
}

