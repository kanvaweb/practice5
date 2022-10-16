// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// CreateArray(Размерность массива). Создаёт массив заданной размерности
int[] CreateArray(int lengthArray)
{
    Random rnd = new Random();
    int[] resultArray = new int[lengthArray];
    for (int i = 0; i < lengthArray; i++)
        resultArray[i] = rnd.Next(100, 1000); // Поиск случайных трехзначных чисел
    return resultArray;
}

// PrintArray(Массив). Выводит элементы массива
void PrintArray(int[] arrayPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayPrint.Length; i++)
        if (i < arrayPrint.Length - 1)
            Console.Write($"{arrayPrint[i]}, ");
        else
            Console.Write($"{arrayPrint[i]}");
    Console.Write("]");
}

// FindArray(Массив). Поиск кол-ва чётных чисел в массиве
int FindArray(int[] arrayFind)
{
    int resultCountEven = 0;
    for (int i = 0; i < arrayFind.Length; i++)
        if (arrayFind[i] % 2 == 0)
            resultCountEven++;
    return resultCountEven;
}

int[] array = CreateArray(10);
Console.Clear();
Console.WriteLine("Задача 34: Выводит кол-во чётных элементов массива");
PrintArray(array);
int countEven = FindArray(array);
Console.Write($" -> {countEven}");

