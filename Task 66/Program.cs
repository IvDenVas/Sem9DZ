// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int m = UserInput("Введите целое число M: ", "Ошибка ввода!");
int n = UserInput("Введите целое число N: ", "Ошибка ввода!");

int result = SummNumbers(m, n);

Console.WriteLine($"M = {m}; N = {n} -> {result}");

int SummNumbers(int oneNumb, int twoNumb)
{
    if (twoNumb == oneNumb) return oneNumb;
    return oneNumb + SummNumbers(oneNumb + 1, twoNumb);
}

int UserInput (string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int num))
        if (num >= 0)
            return num;
        Console.WriteLine(errorMessage);
    }
}

