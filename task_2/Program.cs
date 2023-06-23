// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Variables
int result = 0;
// Input
Console.WriteLine("Please, input number: ");
int input_number = Convert.ToInt32(Console.ReadLine());

// Methods
int Sum_number(int input_number)
{
    int number_length = Convert.ToString(input_number).Length;
    for (int i = 0; i < number_length; i++)
    {
        int move = input_number - input_number % 10;
        result = result + (input_number - move);
        input_number /= 10;
    }
    return result;
}
// Body
int sum_number = Sum_number(input_number);
System.Console.WriteLine($"Sum nubers of {input_number} is: {result} .");    

