// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// CreateArray(Размерность массива). Создаёт массив заданной размерности
int[] CreateArray(int lengthArray)
{
    Random rnd = new Random();
    int[] resultArray = new int[lengthArray];
    for (int i = 0; i < lengthArray; i++)
        resultArray[i] = rnd.Next(1, 20); 
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

// SummArray(Массив). Сумма нечётных позиций массива
int SummArray(int[] arrayFind)
{
    int resultSummNotEven = 0;
    for (int i = 0; i < arrayFind.Length; i++)
        if (i % 2 != 0)
            resultSummNotEven = resultSummNotEven + arrayFind[i];
    return resultSummNotEven;
;
}

int[] array = CreateArray(4);
Console.Clear();
Console.WriteLine("Задача 36: Выводит сумму элементов не чётных позиций массива");
PrintArray(array);
int countEven = SummArray(array);
Console.Write($" -> {countEven}");

