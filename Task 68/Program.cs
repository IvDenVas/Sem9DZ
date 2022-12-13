// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int m = UserInput("Введите целое число M: ", "Ошибка ввода!");
int n = UserInput("Введите целое число N: ", "Ошибка ввода!");

int result = Akerman(m, n);

Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {result}");

int Akerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akerman(m - 1, 1);
    return Akerman(m-1, Akerman(m, n-1));
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


