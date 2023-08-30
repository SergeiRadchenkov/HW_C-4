/* Напишите программу, которая
выводит массив из любого числа элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!); 
}

/* int[] ArrayOfNumbers(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int size = InputNum("Введите размер массива: ");
int[] result = ArrayOfNumbers(size);
PrintArray(result); */

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] ints)
{
    Random rnd = new Random();
    for (int i = 0; i < ints.Length; i++)
        ints[i] = rnd.Next(2);
}

string PrintArray(int[] ints)
{
    string res = ""; // res = String.Empty;
    for (int i = 0; i < ints.Length; i++)
        res += $"{ints[i]} ";
    return res;
}

int size = InputNum("Введите размер массива: ");
int[] myArray = CreateArray(size);
FillArray(myArray);
string answer = PrintArray(myArray);
Console.WriteLine(answer);