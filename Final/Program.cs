// Напишите программу, которая из имеющегося массива строк формирует массив из строк, доина которых меньше либо равна 3
// символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении
// не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.Clear();

int userInput = UserInput("Введите длину одномерного массива: ", "Ошибка ввода!");
string[] array = new string[userInput];

GetArray(array);
string[] arrayFinish = GetArrayFinish(array);

Console.Write("[");
PrintArray(array);
Console.Write("] -> [");
PrintArray(arrayFinish);
Console.Write("]");

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

void GetArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new string(Console.ReadLine());
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write($"\"{array[i]}\"");
        else Console.Write($"\"{array[i]}\", ");
    }
}

string[] GetArrayFinish(string[] inArray)
{
    int sizeArray = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
       if (inArray[i].Length <= 3) sizeArray++; 
    }
    string[] array = new string[sizeArray];
    int index = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
 
        if (inArray[i].Length <= 3)
        {
            array[index] = inArray[i];
            index++;
        }
    }
    return array;
}