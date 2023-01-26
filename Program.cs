// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

int getUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int[] readArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

void printArray(int[] array)
{
    Console.Write("");
    for (int i = 0; i < array.Length; i++)
        {
          Console.Write(array[i]);
          if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
    Console.WriteLine("");
}

int countPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
       {
        if (array[i] > 0)
          {
            count = count + 1;
          }
       }
    return count;
}

Console.ForegroundColor = ConsoleColor.DarkCyan;
int length = getUserData("Введите количество элементов массива:");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Введите эл-ты массива: ");
int[] array = readArray(length);
Console.ForegroundColor = ConsoleColor.DarkMagenta;
printArray(array);
int count =  countPositiveNumbers(array);
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"Количество чисел больше 0: {count}");
Console.ResetColor();