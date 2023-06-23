// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Input
Console.WriteLine("Please, input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

// Methods
int Exponentiation(int number1, int number2)
{
    int result = number1;
    for (int i = 1; i <= number2; i++)
        {
        result = result * i;
        }
        return result;
}

// Body
int exponentation = Exponentiation(number1, number2);
System.Console.WriteLine($"Raising the first number to the power of the second is: {exponentation}.");