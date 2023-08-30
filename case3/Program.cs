/* Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120 */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!); 
}

int Fact(int num)
{
    int f = 1;
    for (int i = 2; i <= num; i++)
    {
        f *= i;
    }
    return f;
}

int number = InputNum("Введите число: ");
int result = Fact(number);
Console.WriteLine($"Факториал числа {number} равно {result}");