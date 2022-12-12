// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
int userInput = UserInput("Введите целое число N: ", "Ошибка ввода!");
int start = 1;
string result = NaturalNumbers(start, userInput);


Console.WriteLine($"N = {userInput} -> \"{result}\"");
string NaturalNumbers(int start,int n)
{
    if (n == 1) return start.ToString();
    return n + ", " + NaturalNumbers(start, n - 1);
}

int UserInput (string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int num))
        if (num > 0)
            return num;
        Console.WriteLine(errorMessage);
    }
}