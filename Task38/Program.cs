// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// CreateArray(Размерность массива). Создаёт массив заданной размерности
double[] CreateArray(int lengthArray)
{
    Random rnd = new Random();
    double[] resultArray = new double[lengthArray];
    for (int i = 0; i < lengthArray; i++)
        resultArray[i] = Math.Round(100 * rnd.NextDouble(), 1); 
    return resultArray;
}

// PrintArray(Массив). Выводит элементы массива
void PrintArray(double[] arrayPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayPrint.Length; i++)
        if (i < arrayPrint.Length - 1)
            Console.Write($"{arrayPrint[i]}, ");
        else
            Console.Write($"{arrayPrint[i]}");
    Console.Write("]");
}

// FindDiffMinMaxArray(Массив). Разница максимального и минимального чисел массива
double FindDiffMinMaxArray(double[] arrayFind)
{
    double resultDiff = 0;
    double minValue = arrayFind[0];
    double maxValue = arrayFind[0];

    for (int i = 1; i < arrayFind.Length; i++)
    {
        if (arrayFind[i] < minValue)
            minValue = arrayFind[i];
        if (arrayFind[i] > maxValue)
            maxValue = arrayFind[i];
    }
    resultDiff = maxValue - minValue;
    return Math.Round(resultDiff, 1);
;
}

double[] array = CreateArray(4);
Console.Clear();
Console.WriteLine("Задача 38: Выводит разницу между максимальным и минимальным ВЕЩЕСТВЕННЫМИ числами массива");
PrintArray(array);
double diffMinMax = FindDiffMinMaxArray(array);
Console.Write($" -> {diffMinMax}");

